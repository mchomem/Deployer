namespace Deployer.Views
{
    partial class AboutForm
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
            labelTextAbout = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // labelTextAbout
            // 
            labelTextAbout.Location = new Point(12, 178);
            labelTextAbout.Name = "labelTextAbout";
            labelTextAbout.Size = new Size(558, 131);
            labelTextAbout.TabIndex = 0;
            labelTextAbout.Text = "...";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.deployer_pb;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(572, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 334);
            Controls.Add(pictureBox);
            Controls.Add(labelTextAbout);
            Name = "AboutForm";
            ShowIcon = false;
            Text = "About";
            Load += AboutForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTextAbout;
        private PictureBox pictureBox;
    }
}