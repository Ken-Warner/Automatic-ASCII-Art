
namespace ASCIIArter
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileChosenTextbox = new System.Windows.Forms.TextBox();
            this.charWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dimsGroupBox = new System.Windows.Forms.GroupBox();
            this.aspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.thumbnailPictureBox = new System.Windows.Forms.PictureBox();
            this.asciiPreviewTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.charWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charHeightNumericUpDown)).BeginInit();
            this.dimsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(109, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Choose File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // fileChosenTextbox
            // 
            this.fileChosenTextbox.Location = new System.Drawing.Point(127, 12);
            this.fileChosenTextbox.Name = "fileChosenTextbox";
            this.fileChosenTextbox.ReadOnly = true;
            this.fileChosenTextbox.Size = new System.Drawing.Size(153, 23);
            this.fileChosenTextbox.TabIndex = 1;
            this.fileChosenTextbox.Text = "No file currently chosen";
            // 
            // charWidthNumericUpDown
            // 
            this.charWidthNumericUpDown.Location = new System.Drawing.Point(126, 29);
            this.charWidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charWidthNumericUpDown.Name = "charWidthNumericUpDown";
            this.charWidthNumericUpDown.Size = new System.Drawing.Size(60, 23);
            this.charWidthNumericUpDown.TabIndex = 2;
            this.charWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charWidthNumericUpDown.ValueChanged += new System.EventHandler(this.charWidthNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Character Height:";
            // 
            // charHeightNumericUpDown
            // 
            this.charHeightNumericUpDown.Location = new System.Drawing.Point(126, 99);
            this.charHeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charHeightNumericUpDown.Name = "charHeightNumericUpDown";
            this.charHeightNumericUpDown.Size = new System.Drawing.Size(60, 23);
            this.charHeightNumericUpDown.TabIndex = 5;
            this.charHeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charHeightNumericUpDown.ValueChanged += new System.EventHandler(this.charHeightNumericUpDown_ValueChanged);
            // 
            // dimsGroupBox
            // 
            this.dimsGroupBox.Controls.Add(this.aspectRatioCheckBox);
            this.dimsGroupBox.Controls.Add(this.charWidthNumericUpDown);
            this.dimsGroupBox.Controls.Add(this.charHeightNumericUpDown);
            this.dimsGroupBox.Controls.Add(this.label1);
            this.dimsGroupBox.Controls.Add(this.label2);
            this.dimsGroupBox.Location = new System.Drawing.Point(12, 41);
            this.dimsGroupBox.Name = "dimsGroupBox";
            this.dimsGroupBox.Size = new System.Drawing.Size(268, 149);
            this.dimsGroupBox.TabIndex = 6;
            this.dimsGroupBox.TabStop = false;
            this.dimsGroupBox.Text = "Output Dimensions";
            // 
            // aspectRatioCheckBox
            // 
            this.aspectRatioCheckBox.AutoSize = true;
            this.aspectRatioCheckBox.Checked = true;
            this.aspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aspectRatioCheckBox.Location = new System.Drawing.Point(126, 66);
            this.aspectRatioCheckBox.Name = "aspectRatioCheckBox";
            this.aspectRatioCheckBox.Size = new System.Drawing.Size(139, 19);
            this.aspectRatioCheckBox.TabIndex = 6;
            this.aspectRatioCheckBox.Text = "Preserve Aspect Ratio";
            this.aspectRatioCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(12, 197);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(109, 23);
            this.saveFileButton.TabIndex = 7;
            this.saveFileButton.Text = "Save Text File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            this.openFileDialog.Title = "Open";
            // 
            // thumbnailPictureBox
            // 
            this.thumbnailPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailPictureBox.Location = new System.Drawing.Point(286, 12);
            this.thumbnailPictureBox.Name = "thumbnailPictureBox";
            this.thumbnailPictureBox.Size = new System.Drawing.Size(209, 209);
            this.thumbnailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailPictureBox.TabIndex = 8;
            this.thumbnailPictureBox.TabStop = false;
            // 
            // asciiPreviewTextBox
            // 
            this.asciiPreviewTextBox.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asciiPreviewTextBox.Location = new System.Drawing.Point(501, 12);
            this.asciiPreviewTextBox.Multiline = true;
            this.asciiPreviewTextBox.Name = "asciiPreviewTextBox";
            this.asciiPreviewTextBox.ReadOnly = true;
            this.asciiPreviewTextBox.Size = new System.Drawing.Size(209, 209);
            this.asciiPreviewTextBox.TabIndex = 9;
            this.asciiPreviewTextBox.Text = "testing if this works";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Plain Text(*.txt)|*.txt";
            this.saveFileDialog.Title = "Save";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 233);
            this.Controls.Add(this.asciiPreviewTextBox);
            this.Controls.Add(this.thumbnailPictureBox);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.dimsGroupBox);
            this.Controls.Add(this.fileChosenTextbox);
            this.Controls.Add(this.selectFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCII Arter";
            ((System.ComponentModel.ISupportInitialize)(this.charWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charHeightNumericUpDown)).EndInit();
            this.dimsGroupBox.ResumeLayout(false);
            this.dimsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox fileChosenTextbox;
        private System.Windows.Forms.NumericUpDown charWidthNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown charHeightNumericUpDown;
        private System.Windows.Forms.GroupBox dimsGroupBox;
        private System.Windows.Forms.CheckBox aspectRatioCheckBox;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox thumbnailPictureBox;
        private System.Windows.Forms.TextBox asciiPreviewTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

