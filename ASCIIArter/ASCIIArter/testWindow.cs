using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ASCIIArter
{
    public partial class testWindow : Form
    {
        public Bitmap normalImage
        {
            set
            {
                testPictureBox.Image = value;
            }
        }

        public testWindow()
        {
            InitializeComponent();
        }
    }
}
