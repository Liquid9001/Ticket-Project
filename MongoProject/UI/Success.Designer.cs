namespace MongoProject.UI
{
    partial class Success
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
            pictureBox1 = new PictureBox();
            LoggedOutLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bye_goodbye;
            pictureBox1.Location = new Point(147, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoggedOutLabel
            // 
            LoggedOutLabel.AutoSize = true;
            LoggedOutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoggedOutLabel.Location = new Point(298, 52);
            LoggedOutLabel.Name = "LoggedOutLabel";
            LoggedOutLabel.Size = new Size(211, 28);
            LoggedOutLabel.TabIndex = 1;
            LoggedOutLabel.Text = "Logged out succesfully";
            // 
            // Success
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 601);
            Controls.Add(LoggedOutLabel);
            Controls.Add(pictureBox1);
            Name = "Success";
            Text = "GoodBye";
            Load += Success_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LoggedOutLabel;
    }
}