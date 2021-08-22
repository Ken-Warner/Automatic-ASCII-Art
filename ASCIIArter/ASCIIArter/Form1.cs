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

            }
        }

        private void charHeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (aspectRatioCheckBox.Checked && loadedImage != null)
            {

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
    }
}
