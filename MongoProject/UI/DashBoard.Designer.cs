
namespace DemoApp
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            gardenGroupLogo = new PictureBox();
            DashboardPanel = new Panel();
            userManagementButton = new Button();
            incidentManagementButton = new Button();
            DashBoardButton = new Button();
            licensedToLabel = new Label();
            noDeskLabel = new Label();
            addIncidentPanel = new Panel();
            outputReportedDate = new Label();
            deadlineFollowUpInput = new ComboBox();
            priorityInput = new ComboBox();
            userReportedInput = new ComboBox();
            incidentTypeInput = new ComboBox();
            subjectInput = new TextBox();
            submitTicketButton = new Button();
            cancelButton = new Button();
            descriptionInput = new TextBox();
            descriptionLabel = new Label();
            deadlineFollowUpLabel = new Label();
            priorityLabel = new Label();
            userReportedLabel = new Label();
            incidentTypeLabel = new Label();
            subjectIncidentLabel = new Label();
            reportedDateLabel = new Label();
            newIncidentLabel = new Label();
            userManagementPanel = new Panel();
            textBoxFilterUser = new TextBox();
            labelUserManagement = new Label();
            buttonAddUser = new Button();
            listViewUsers = new ListView();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            emailAddress = new ColumnHeader();
            numberOfTickets = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).BeginInit();
            DashboardPanel.SuspendLayout();
            addIncidentPanel.SuspendLayout();
            userManagementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gardenGroupLogo
            // 
            gardenGroupLogo.Image = (Image)resources.GetObject("gardenGroupLogo.Image");
            gardenGroupLogo.Location = new Point(3, -1);
            gardenGroupLogo.Name = "gardenGroupLogo";
            gardenGroupLogo.Size = new Size(378, 128);
            gardenGroupLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            gardenGroupLogo.TabIndex = 1;
            gardenGroupLogo.TabStop = false;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.BorderStyle = BorderStyle.FixedSingle;
            DashboardPanel.Controls.Add(userManagementButton);
            DashboardPanel.Controls.Add(incidentManagementButton);
            DashboardPanel.Controls.Add(DashBoardButton);
            DashboardPanel.Controls.Add(licensedToLabel);
            DashboardPanel.Controls.Add(noDeskLabel);
            DashboardPanel.Controls.Add(gardenGroupLogo);
            DashboardPanel.Location = new Point(13, 11);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(1581, 186);
            DashboardPanel.TabIndex = 1;
            // 
            // userManagementButton
            // 
            userManagementButton.BackColor = Color.White;
            userManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            userManagementButton.Location = new Point(1053, 129);
            userManagementButton.Name = "userManagementButton";
            userManagementButton.Size = new Size(524, 52);
            userManagementButton.TabIndex = 6;
            userManagementButton.Text = "User Management";
            userManagementButton.UseVisualStyleBackColor = false;
            // 
            // incidentManagementButton
            // 
            incidentManagementButton.BackColor = Color.White;
            incidentManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            incidentManagementButton.Location = new Point(529, 129);
            incidentManagementButton.Name = "incidentManagementButton";
            incidentManagementButton.Size = new Size(524, 52);
            incidentManagementButton.TabIndex = 5;
            incidentManagementButton.Text = "Incident Management";
            incidentManagementButton.UseVisualStyleBackColor = false;
            // 
            // DashBoardButton
            // 
            DashBoardButton.BackColor = Color.White;
            DashBoardButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            DashBoardButton.Location = new Point(-1, 129);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(524, 52);
            DashBoardButton.TabIndex = 4;
            DashBoardButton.Text = "Dashboard";
            DashBoardButton.UseVisualStyleBackColor = false;
            // 
            // licensedToLabel
            // 
            licensedToLabel.AutoSize = true;
            licensedToLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            licensedToLabel.Location = new Point(1053, 67);
            licensedToLabel.Name = "licensedToLabel";
            licensedToLabel.Size = new Size(496, 45);
            licensedToLabel.TabIndex = 3;
            licensedToLabel.Text = "Licensed to: The Garden Group";
            // 
            // noDeskLabel
            // 
            noDeskLabel.AutoSize = true;
            noDeskLabel.BackColor = Color.Transparent;
            noDeskLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            noDeskLabel.Location = new Point(1360, 0);
            noDeskLabel.Name = "noDeskLabel";
            noDeskLabel.Size = new Size(200, 62);
            noDeskLabel.TabIndex = 2;
            noDeskLabel.Text = "NoDesk";
            // 
            // addIncidentPanel
            // 
            addIncidentPanel.BackColor = Color.White;
            addIncidentPanel.Controls.Add(outputReportedDate);
            addIncidentPanel.Controls.Add(deadlineFollowUpInput);
            addIncidentPanel.Controls.Add(priorityInput);
            addIncidentPanel.Controls.Add(userReportedInput);
            addIncidentPanel.Controls.Add(incidentTypeInput);
            addIncidentPanel.Controls.Add(subjectInput);
            addIncidentPanel.Controls.Add(submitTicketButton);
            addIncidentPanel.Controls.Add(cancelButton);
            addIncidentPanel.Controls.Add(descriptionInput);
            addIncidentPanel.Controls.Add(descriptionLabel);
            addIncidentPanel.Controls.Add(deadlineFollowUpLabel);
            addIncidentPanel.Controls.Add(priorityLabel);
            addIncidentPanel.Controls.Add(userReportedLabel);
            addIncidentPanel.Controls.Add(incidentTypeLabel);
            addIncidentPanel.Controls.Add(subjectIncidentLabel);
            addIncidentPanel.Controls.Add(reportedDateLabel);
            addIncidentPanel.Controls.Add(newIncidentLabel);
            addIncidentPanel.Location = new Point(13, 202);
            addIncidentPanel.Name = "addIncidentPanel";
            addIncidentPanel.Size = new Size(1581, 1070);
            addIncidentPanel.TabIndex = 2;
            // 
            // outputReportedDate
            // 
            outputReportedDate.BorderStyle = BorderStyle.FixedSingle;
            outputReportedDate.Location = new Point(358, 104);
            outputReportedDate.Name = "outputReportedDate";
            outputReportedDate.Size = new Size(462, 37);
            outputReportedDate.TabIndex = 23;
            // 
            // deadlineFollowUpInput
            // 
            deadlineFollowUpInput.FormattingEnabled = true;
            deadlineFollowUpInput.Location = new Point(358, 514);
            deadlineFollowUpInput.Name = "deadlineFollowUpInput";
            deadlineFollowUpInput.Size = new Size(462, 38);
            deadlineFollowUpInput.TabIndex = 22;
            // 
            // priorityInput
            // 
            priorityInput.FormattingEnabled = true;
            priorityInput.Location = new Point(358, 430);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(462, 38);
            priorityInput.TabIndex = 21;
            // 
            // userReportedInput
            // 
            userReportedInput.FormattingEnabled = true;
            userReportedInput.Location = new Point(358, 348);
            userReportedInput.Name = "userReportedInput";
            userReportedInput.Size = new Size(462, 38);
            userReportedInput.TabIndex = 20;
            userReportedInput.Text = " Select user";
            // 
            // incidentTypeInput
            // 
            incidentTypeInput.FormattingEnabled = true;
            incidentTypeInput.Location = new Point(358, 260);
            incidentTypeInput.Name = "incidentTypeInput";
            incidentTypeInput.Size = new Size(462, 38);
            incidentTypeInput.TabIndex = 19;
            incidentTypeInput.Text = " Select type";
            // 
            // subjectInput
            // 
            subjectInput.Location = new Point(358, 179);
            subjectInput.Name = "subjectInput";
            subjectInput.Size = new Size(462, 35);
            subjectInput.TabIndex = 18;
            // 
            // submitTicketButton
            // 
            submitTicketButton.BackColor = Color.DeepSkyBlue;
            submitTicketButton.FlatAppearance.BorderColor = Color.Black;
            submitTicketButton.FlatAppearance.MouseDownBackColor = Color.White;
            submitTicketButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            submitTicketButton.Location = new Point(597, 908);
            submitTicketButton.Name = "submitTicketButton";
            submitTicketButton.Size = new Size(222, 68);
            submitTicketButton.TabIndex = 17;
            submitTicketButton.Text = "SUBMIT TICKET";
            submitTicketButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(358, 908);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 68);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(358, 613);
            descriptionInput.MinimumSize = new Size(4, 188);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(462, 241);
            descriptionInput.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(65, 613);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(123, 30);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // deadlineFollowUpLabel
            // 
            deadlineFollowUpLabel.AutoSize = true;
            deadlineFollowUpLabel.Location = new Point(63, 514);
            deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            deadlineFollowUpLabel.Size = new Size(194, 30);
            deadlineFollowUpLabel.TabIndex = 13;
            deadlineFollowUpLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(63, 430);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(83, 30);
            priorityLabel.TabIndex = 12;
            priorityLabel.Text = "Priority:";
            // 
            // userReportedLabel
            // 
            userReportedLabel.AutoSize = true;
            userReportedLabel.Location = new Point(63, 348);
            userReportedLabel.Name = "userReportedLabel";
            userReportedLabel.Size = new Size(175, 30);
            userReportedLabel.TabIndex = 11;
            userReportedLabel.Text = "Reported by user:";
            // 
            // incidentTypeLabel
            // 
            incidentTypeLabel.AutoSize = true;
            incidentTypeLabel.Location = new Point(63, 260);
            incidentTypeLabel.Name = "incidentTypeLabel";
            incidentTypeLabel.Size = new Size(166, 30);
            incidentTypeLabel.TabIndex = 10;
            incidentTypeLabel.Text = "Type of incident:";
            // 
            // subjectIncidentLabel
            // 
            subjectIncidentLabel.AutoSize = true;
            subjectIncidentLabel.Location = new Point(63, 179);
            subjectIncidentLabel.Name = "subjectIncidentLabel";
            subjectIncidentLabel.Size = new Size(186, 30);
            subjectIncidentLabel.TabIndex = 9;
            subjectIncidentLabel.Text = "Subject of incident";
            // 
            // reportedDateLabel
            // 
            reportedDateLabel.AutoSize = true;
            reportedDateLabel.Location = new Point(63, 104);
            reportedDateLabel.Name = "reportedDateLabel";
            reportedDateLabel.Size = new Size(196, 30);
            reportedDateLabel.TabIndex = 8;
            reportedDateLabel.Text = "Date/time reported:";
            // 
            // newIncidentLabel
            // 
            newIncidentLabel.AutoSize = true;
            newIncidentLabel.BackColor = Color.Transparent;
            newIncidentLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            newIncidentLabel.Location = new Point(15, 12);
            newIncidentLabel.Name = "newIncidentLabel";
            newIncidentLabel.Size = new Size(596, 62);
            newIncidentLabel.TabIndex = 7;
            newIncidentLabel.Text = "Create new incident ticket";
            // 
            // userManagementPanel
            // 
            userManagementPanel.BackColor = Color.White;
            userManagementPanel.Controls.Add(textBoxFilterUser);
            userManagementPanel.Controls.Add(labelUserManagement);
            userManagementPanel.Controls.Add(buttonAddUser);
            userManagementPanel.Controls.Add(listViewUsers);
            userManagementPanel.Location = new Point(13, 202);
            userManagementPanel.Name = "userManagementPanel";
            userManagementPanel.Size = new Size(1581, 1070);
            userManagementPanel.TabIndex = 7;
            userManagementPanel.Paint += userManagementPanel_Paint;
            // 
            // textBoxFilterUser
            // 
            textBoxFilterUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFilterUser.Location = new Point(271, 104);
            textBoxFilterUser.Name = "textBoxFilterUser";
            textBoxFilterUser.Size = new Size(285, 45);
            textBoxFilterUser.TabIndex = 3;
            textBoxFilterUser.Text = "Filter by email";
            // 
            // labelUserManagement
            // 
            labelUserManagement.AutoSize = true;
            labelUserManagement.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserManagement.Location = new Point(15, 12);
            labelUserManagement.Name = "labelUserManagement";
            labelUserManagement.Size = new Size(485, 74);
            labelUserManagement.TabIndex = 2;
            labelUserManagement.Text = "User Management";
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.Chartreuse;
            buttonAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddUser.Location = new Point(1085, 50);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(231, 84);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "Add User";
            buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { firstName, lastName, emailAddress, numberOfTickets });
            listViewUsers.FullRowSelect = true;
            listViewUsers.Location = new Point(271, 179);
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(1045, 776);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            listViewUsers.SelectedIndexChanged += listViewUsers_SelectedIndexChanged;
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            firstName.Width = 220;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.Width = 320;
            // 
            // emailAddress
            // 
            emailAddress.Text = "Email Address";
            emailAddress.Width = 400;
            // 
            // numberOfTickets
            // 
            numberOfTickets.Text = "#Tickets";
            numberOfTickets.Width = 100;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 1283);
            Controls.Add(userManagementPanel);
            Controls.Add(addIncidentPanel);
            Controls.Add(DashboardPanel);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DashBoard";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).EndInit();
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            addIncidentPanel.ResumeLayout(false);
            addIncidentPanel.PerformLayout();
            userManagementPanel.ResumeLayout(false);
            userManagementPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox gardenGroupLogo;
        private Panel DashboardPanel;
        private Button userManagementButton;
        private Button incidentManagementButton;
        private Button DashBoardButton;
        private Label licensedToLabel;
        private Label noDeskLabel;
        private Panel addIncidentPanel;
        private TextBox descriptionInput;
        private Label descriptionLabel;
        private Label deadlineFollowUpLabel;
        private Label priorityLabel;
        private Label userReportedLabel;
        private Label incidentTypeLabel;
        private Label subjectIncidentLabel;
        private Label reportedDateLabel;
        private Label newIncidentLabel;
        private TextBox subjectInput;
        private Button submitTicketButton;
        private Button cancelButton;
        private ComboBox incidentTypeInput;
        private Label outputReportedDate;
        private ComboBox deadlineFollowUpInput;
        private ComboBox priorityInput;
        private ComboBox userReportedInput;
        private Panel userManagementPanel;
        private ListView listViewUsers;
        private ColumnHeader firstName;
        private ColumnHeader lastName;
        private ColumnHeader emailAddress;
        private ColumnHeader numberOfTickets;
        private TextBox textBoxFilterUser;
        private Label labelUserManagement;
        private Button buttonAddUser;
    }
}

