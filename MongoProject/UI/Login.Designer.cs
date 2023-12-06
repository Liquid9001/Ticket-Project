namespace MongoProject.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            DashboardPanel = new Panel();
            licensedToLabel = new Label();
            noDeskLabel = new Label();
            gardenGroupLogo = new PictureBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            noDeskTextLabel = new Label();
            label2 = new Label();
            rememberMeCheckBox = new CheckBox();
            loginButton = new Button();
            DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).BeginInit();
            SuspendLayout();
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.BorderStyle = BorderStyle.FixedSingle;
            DashboardPanel.Controls.Add(licensedToLabel);
            DashboardPanel.Controls.Add(noDeskLabel);
            DashboardPanel.Controls.Add(gardenGroupLogo);
            DashboardPanel.Location = new Point(0, 1);
            DashboardPanel.Margin = new Padding(2);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(932, 72);
            DashboardPanel.TabIndex = 2;
            // 
            // licensedToLabel
            // 
            licensedToLabel.AutoSize = true;
            licensedToLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            licensedToLabel.Location = new Point(614, 33);
            licensedToLabel.Margin = new Padding(2, 0, 2, 0);
            licensedToLabel.Name = "licensedToLabel";
            licensedToLabel.Size = new Size(288, 25);
            licensedToLabel.TabIndex = 3;
            licensedToLabel.Text = "Licensed to: The Garden Group";
            // 
            // noDeskLabel
            // 
            noDeskLabel.AutoSize = true;
            noDeskLabel.BackColor = Color.Transparent;
            noDeskLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            noDeskLabel.Location = new Point(793, 0);
            noDeskLabel.Margin = new Padding(2, 0, 2, 0);
            noDeskLabel.Name = "noDeskLabel";
            noDeskLabel.Size = new Size(117, 37);
            noDeskLabel.TabIndex = 2;
            noDeskLabel.Text = "NoDesk";
            // 
            // gardenGroupLogo
            // 
            gardenGroupLogo.Image = (Image)resources.GetObject("gardenGroupLogo.Image");
            gardenGroupLogo.Location = new Point(2, -1);
            gardenGroupLogo.Margin = new Padding(2);
            gardenGroupLogo.Name = "gardenGroupLogo";
            gardenGroupLogo.Size = new Size(412, 59);
            gardenGroupLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            gardenGroupLogo.TabIndex = 1;
            gardenGroupLogo.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(322, 206);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(322, 273);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(322, 223);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(245, 23);
            usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(322, 298);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(245, 23);
            passwordTextBox.TabIndex = 6;
            // 
            // noDeskTextLabel
            // 
            noDeskTextLabel.AutoSize = true;
            noDeskTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            noDeskTextLabel.Location = new Point(377, 103);
            noDeskTextLabel.Name = "noDeskTextLabel";
            noDeskTextLabel.Size = new Size(101, 21);
            noDeskTextLabel.TabIndex = 7;
            noDeskTextLabel.Text = "NoDesk: TGG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 140);
            label2.Name = "label2";
            label2.Size = new Size(308, 42);
            label2.TabIndex = 8;
            label2.Text = "Please provide login credentials to login to \r\nNoDesk for The Garden Group";
            // 
            // rememberMeCheckBox
            // 
            rememberMeCheckBox.AutoSize = true;
            rememberMeCheckBox.Location = new Point(322, 334);
            rememberMeCheckBox.Margin = new Padding(3, 2, 3, 2);
            rememberMeCheckBox.Name = "rememberMeCheckBox";
            rememberMeCheckBox.Size = new Size(104, 19);
            rememberMeCheckBox.TabIndex = 10;
            rememberMeCheckBox.Text = "Remember Me";
            rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DeepSkyBlue;
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(339, 370);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(191, 44);
            loginButton.TabIndex = 11;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(934, 446);
            Controls.Add(loginButton);
            Controls.Add(rememberMeCheckBox);
            Controls.Add(label2);
            Controls.Add(noDeskTextLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(DashboardPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_load;
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DashboardPanel;
        private Label licensedToLabel;
        private Label noDeskLabel;
        private PictureBox gardenGroupLogo;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label noDeskTextLabel;
        private Label label2;
        private CheckBox rememberMeCheckBox;
        private Button loginButton;
    }
}