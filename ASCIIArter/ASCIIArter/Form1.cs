using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCIIArter
{
    public partial class MainWindow : Form
    {
        private Bitmap loadedImage = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void charWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //nothing to calculate if there is no image and the user doesn't want to preserve aspect ratio
            if (aspectRatioCheckBox.Checked && loadedImage != null)
            {
                //todo implement
            }
        }

        private void charHeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (aspectRatioCheckBox.Checked && loadedImage != null)
            {
                //todo implement
            }
        }

        /// <summary>
        /// Attempts to open bitmap from the file chosen by the user.
        /// </summary>
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            //get a path from the user
            DialogResult result = openFileDialog.ShowDialog();
            //if path was accepted by user
            if (result == DialogResult.OK)
            {
                //show the path in the textbox of the main form
                fileChosenTextbox.Text = openFileDialog.FileName;

                try
                {
                    //try to open the bitmap and display a thumbnail for the image
                    loadedImage = new Bitmap(openFileDialog.FileName);
                    thumbnailPictureBox.Image = loadedImage;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Unable to open the file specified.");
                    loadedImage = null;
                }
            }
            else
            {
                loadedImage = null; //set to null if no image is loaded
                thumbnailPictureBox.Image = null;
            }
        }

        /// <summary>
        /// Writes the plain text generated from the image to a plain text file at a location chosen by the user
        /// </summary>
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            //check to make sure an image has been loaded
            if (loadedImage == null)
            {
                MessageBox.Show("Please choose an image before saving your text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //get a path from the user for saving
                DialogResult result = saveFileDialog.ShowDialog();
                //if path recieved successfully, write the text to the file
                if (result == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, asciiPreviewTextBox.Text);
                }
            }
        }

        /// <summary>
        /// Grayscales the pixels of a bitmap
        /// </summary>
        /// <param name="bitmap">The bitmap to grayscale</param>
        /// <returns>A new grayscaled version of the input</returns>
        private Bitmap GrayscaleBitmap(Bitmap bitmap)
        {
            //check if the bitmap exists
            if (bitmap != null)
            {
                //create a new bitmap of the same dimensions
                Bitmap grayBmp = new Bitmap(bitmap.Width, bitmap.Height);

                //foreach pixel in the bitmap
                for (int w = 0; w < bitmap.Width; w++)
                    for (int h = 0; h < bitmap.Height; h++)
                    {
                        //get that pixel
                        Color pixelColor = bitmap.GetPixel(w, h);
                        //get it's grayscaled value
                        int grayValue = (int)((pixelColor.R * .3) + (pixelColor.G * .59) + (pixelColor.B * .11));
                        //set it in the new bitmap
                        grayBmp.SetPixel(w, h, Color.FromArgb(grayValue, grayValue, grayValue));
                    }

                return grayBmp;
            } else
            {
                return null; //if the input parameter was null
            }
        }

        /// <summary>
        /// Resizes a bitmap according to the Width and Height provided
        /// </summary>
        /// <param name="bitmap">The bitmap to resize</param>
        /// <param name="Width">The new height of the bitmap</param>
        /// <param name="Height">The new width of the bitmap</param>
        /// <returns>A new bitmap created from the original one with the specified dimensions</returns>
        private Bitmap ResizeBitmap(Bitmap bitmap, int Width, int Height)
        {
            if (bitmap == null)
                return null;
            else
                return new Bitmap(bitmap, Width, Height);
        }

        private void ClampValues(Bitmap bitmap, int numberOfValues)
        {
            //must have at least 2 pixel values in the bitmap
            if (numberOfValues < 2 || numberOfValues > byte.MaxValue)
                return;

            //calculate the step for each clamping
            //one of the clamped values are accounted for in the edge case in the main loop.
            //this is due to the rounding error of 255/numberOfValues. Because of this, the
            //method creates numberOfValues - 1 bins automatically and the other is the edge case.
            int step = (int)(255.0 / numberOfValues - 1);

            //foreach pixel in the image
            for (int w = 0; w < bitmap.Width; w++)
                for (int h = 0; h < bitmap.Height; h++)
                {
                    //get the value
                    byte pixelColor = bitmap.GetPixel(w, h).R;
                    byte clampedColor = 0;

                    //check an edge case
                    if (pixelColor >= (step * (numberOfValues - 1)))
                    {
                        clampedColor = byte.MaxValue;
                    } else
                    { //no edge case
                        //find out what the value should be clamped to
                        for (int i = 1; i <= numberOfValues - 1; i++)
                        {
                            if (pixelColor < (step * i) && pixelColor >= (step * (i - 1)))
                                clampedColor = (byte)(step * (i - 1));
                        }
                    }

                    //set the new pixel values
                    bitmap.SetPixel(w, h, Color.FromArgb(clampedColor, clampedColor, clampedColor));
                }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (loadedImage == null)
                return;


            Bitmap preprocessedBmp = ResizeBitmap(GrayscaleBitmap(loadedImage), 400, 400);
            ClampValues(preprocessedBmp, 5);
            

            testWindow window = new testWindow()
            {
                normalImage = preprocessedBmp,
            };

            window.Show();

        }
    }
}
