
namespace ASCIIArter
{
    partial class testWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // testPictureBox
            // 
            this.testPictureBox.Location = new System.Drawing.Point(12, 12);
            this.testPictureBox.Name = "testPictureBox";
            this.testPictureBox.Size = new System.Drawing.Size(400, 400);
            this.testPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testPictureBox.TabIndex = 0;
            this.testPictureBox.TabStop = false;
            // 
            // testWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 420);
            this.Controls.Add(this.testPictureBox);
            this.Name = "testWindow";
            this.Text = "Testing";
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox testPictureBox;
    }
}