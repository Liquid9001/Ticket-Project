
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
            newIncidentLabel = new Label();
            ticketOverviewPanel = new Panel();
            listViewTicketOverview = new ListView();
            filterTextBoxInput = new TextBox();
            createIncidentButton = new Button();
            overviewTicketLabel = new Label();
            userManagementPanel = new Panel();
            addUserButton = new Button();
            userSearchBox = new TextBox();
            userOverviewLV = new ListView();
            number = new ColumnHeader();
            email = new ColumnHeader();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            numberOfTickets = new ColumnHeader();
            addUserPanel = new Panel();
            serviceDeskLabel = new Label();
            isServiceDeskCheckBox = new CheckBox();
            locationLabel = new Label();
            locationTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            createUserCreateButton = new Button();
            createUserCancelButton = new Button();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            lastNamelabel = new Label();
            addUserNameLabel = new Label();
            addUserLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).BeginInit();
            DashboardPanel.SuspendLayout();
            addIncidentPanel.SuspendLayout();
            ticketOverviewPanel.SuspendLayout();
            userManagementPanel.SuspendLayout();
            addUserPanel.SuspendLayout();
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
            userManagementButton.Click += userManagementButton_Click;
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
            addIncidentPanel.Controls.Add(newIncidentLabel);
            addIncidentPanel.Location = new Point(13, 202);
            addIncidentPanel.Name = "addIncidentPanel";
            addIncidentPanel.Size = new Size(1581, 1070);
            addIncidentPanel.TabIndex = 2;
            // 
            // deadlineFollowUpInput
            // 
            deadlineFollowUpInput.FormattingEnabled = true;
            deadlineFollowUpInput.Location = new Point(361, 476);
            deadlineFollowUpInput.Name = "deadlineFollowUpInput";
            deadlineFollowUpInput.Size = new Size(462, 38);
            deadlineFollowUpInput.TabIndex = 22;
            // 
            // priorityInput
            // 
            priorityInput.FormattingEnabled = true;
            priorityInput.Location = new Point(361, 393);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(462, 38);
            priorityInput.TabIndex = 21;
            // 
            // userReportedInput
            // 
            userReportedInput.FormattingEnabled = true;
            userReportedInput.Location = new Point(361, 310);
            userReportedInput.Name = "userReportedInput";
            userReportedInput.Size = new Size(462, 38);
            userReportedInput.TabIndex = 20;
            userReportedInput.Text = " Select user";
            // 
            // incidentTypeInput
            // 
            incidentTypeInput.FormattingEnabled = true;
            incidentTypeInput.Location = new Point(361, 222);
            incidentTypeInput.Name = "incidentTypeInput";
            incidentTypeInput.Size = new Size(462, 38);
            incidentTypeInput.TabIndex = 19;
            incidentTypeInput.Text = " Select type";
            // 
            // subjectInput
            // 
            subjectInput.Location = new Point(361, 142);
            subjectInput.Name = "subjectInput";
            subjectInput.Size = new Size(462, 35);
            subjectInput.TabIndex = 18;
            subjectInput.TextChanged += subjectInput_TextChanged;
            // 
            // submitTicketButton
            // 
            submitTicketButton.BackColor = Color.DeepSkyBlue;
            submitTicketButton.FlatAppearance.BorderColor = Color.Black;
            submitTicketButton.FlatAppearance.MouseDownBackColor = Color.White;
            submitTicketButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            submitTicketButton.ForeColor = Color.White;
            submitTicketButton.Location = new Point(600, 871);
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
            cancelButton.Location = new Point(361, 871);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 68);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(361, 576);
            descriptionInput.MinimumSize = new Size(4, 188);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(462, 241);
            descriptionInput.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(67, 576);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(123, 30);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // deadlineFollowUpLabel
            // 
            deadlineFollowUpLabel.AutoSize = true;
            deadlineFollowUpLabel.Location = new Point(63, 476);
            deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            deadlineFollowUpLabel.Size = new Size(194, 30);
            deadlineFollowUpLabel.TabIndex = 13;
            deadlineFollowUpLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(66, 393);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(83, 30);
            priorityLabel.TabIndex = 12;
            priorityLabel.Text = "Priority:";
            // 
            // userReportedLabel
            // 
            userReportedLabel.AutoSize = true;
            userReportedLabel.Location = new Point(66, 310);
            userReportedLabel.Name = "userReportedLabel";
            userReportedLabel.Size = new Size(175, 30);
            userReportedLabel.TabIndex = 11;
            userReportedLabel.Text = "Reported by user:";
            // 
            // incidentTypeLabel
            // 
            incidentTypeLabel.AutoSize = true;
            incidentTypeLabel.Location = new Point(66, 222);
            incidentTypeLabel.Name = "incidentTypeLabel";
            incidentTypeLabel.Size = new Size(166, 30);
            incidentTypeLabel.TabIndex = 10;
            incidentTypeLabel.Text = "Type of incident:";
            // 
            // subjectIncidentLabel
            // 
            subjectIncidentLabel.AutoSize = true;
            subjectIncidentLabel.Location = new Point(66, 142);
            subjectIncidentLabel.Name = "subjectIncidentLabel";
            subjectIncidentLabel.Size = new Size(186, 30);
            subjectIncidentLabel.TabIndex = 9;
            subjectIncidentLabel.Text = "Subject of incident";
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
            // ticketOverviewPanel
            // 
            ticketOverviewPanel.BackColor = Color.White;
            ticketOverviewPanel.Controls.Add(listViewTicketOverview);
            ticketOverviewPanel.Controls.Add(filterTextBoxInput);
            ticketOverviewPanel.Controls.Add(createIncidentButton);
            ticketOverviewPanel.Controls.Add(overviewTicketLabel);
            ticketOverviewPanel.Location = new Point(13, 202);
            ticketOverviewPanel.Name = "ticketOverviewPanel";
            ticketOverviewPanel.Size = new Size(1581, 1070);
            ticketOverviewPanel.TabIndex = 24;
            // 
            // listViewTicketOverview
            // 
            listViewTicketOverview.FullRowSelect = true;
            listViewTicketOverview.GridLines = true;
            listViewTicketOverview.Location = new Point(63, 221);
            listViewTicketOverview.Name = "listViewTicketOverview";
            listViewTicketOverview.Size = new Size(1456, 809);
            listViewTicketOverview.TabIndex = 20;
            listViewTicketOverview.UseCompatibleStateImageBehavior = false;
            // 
            // filterTextBoxInput
            // 
            filterTextBoxInput.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            filterTextBoxInput.ForeColor = Color.Silver;
            filterTextBoxInput.Location = new Point(63, 137);
            filterTextBoxInput.Multiline = true;
            filterTextBoxInput.Name = "filterTextBoxInput";
            filterTextBoxInput.Size = new Size(432, 69);
            filterTextBoxInput.TabIndex = 19;
            filterTextBoxInput.Text = " Filter by email";
            // 
            // createIncidentButton
            // 
            createIncidentButton.BackColor = Color.DeepSkyBlue;
            createIncidentButton.FlatAppearance.BorderColor = Color.Black;
            createIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            createIncidentButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createIncidentButton.ForeColor = Color.White;
            createIncidentButton.Location = new Point(1296, 137);
            createIncidentButton.Name = "createIncidentButton";
            createIncidentButton.Size = new Size(222, 68);
            createIncidentButton.TabIndex = 18;
            createIncidentButton.Text = "CREATE INCIDENT";
            createIncidentButton.UseVisualStyleBackColor = false;
            createIncidentButton.Click += createIncidentButton_Click;
            // 
            // overviewTicketLabel
            // 
            overviewTicketLabel.AutoSize = true;
            overviewTicketLabel.BackColor = Color.Transparent;
            overviewTicketLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            overviewTicketLabel.Location = new Point(15, 12);
            overviewTicketLabel.Name = "overviewTicketLabel";
            overviewTicketLabel.Size = new Size(400, 62);
            overviewTicketLabel.TabIndex = 8;
            overviewTicketLabel.Text = "Overview Tickets";
            // 
            // userManagementPanel
            // 
            userManagementPanel.BackColor = Color.White;
            userManagementPanel.Controls.Add(addUserButton);
            userManagementPanel.Controls.Add(userSearchBox);
            userManagementPanel.Controls.Add(userOverviewLV);
            userManagementPanel.Location = new Point(13, 202);
            userManagementPanel.Name = "userManagementPanel";
            userManagementPanel.Size = new Size(1581, 1070);
            userManagementPanel.TabIndex = 23;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(1164, 45);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(180, 40);
            addUserButton.TabIndex = 2;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // userSearchBox
            // 
            userSearchBox.Location = new Point(213, 50);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(311, 35);
            userSearchBox.TabIndex = 1;
            // 
            // userOverviewLV
            // 
            userOverviewLV.Columns.AddRange(new ColumnHeader[] { number, email, firstName, lastName, numberOfTickets });
            userOverviewLV.FullRowSelect = true;
            userOverviewLV.Location = new Point(213, 142);
            userOverviewLV.Name = "userOverviewLV";
            userOverviewLV.Size = new Size(1131, 888);
            userOverviewLV.TabIndex = 0;
            userOverviewLV.UseCompatibleStateImageBehavior = false;
            userOverviewLV.View = View.Details;
            // 
            // number
            // 
            number.Tag = "#";
            number.Text = "#";
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 100;
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            firstName.Width = 150;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.Width = 150;
            // 
            // numberOfTickets
            // 
            numberOfTickets.Text = "# Tickets";
            numberOfTickets.Width = 100;
            // 
            // addUserPanel
            // 
            addUserPanel.BackColor = Color.White;
            addUserPanel.Controls.Add(serviceDeskLabel);
            addUserPanel.Controls.Add(isServiceDeskCheckBox);
            addUserPanel.Controls.Add(locationLabel);
            addUserPanel.Controls.Add(locationTextBox);
            addUserPanel.Controls.Add(phoneNumberTextBox);
            addUserPanel.Controls.Add(emailTextBox);
            addUserPanel.Controls.Add(passwordTextBox);
            addUserPanel.Controls.Add(usernameTextBox);
            addUserPanel.Controls.Add(lastNameTextBox);
            addUserPanel.Controls.Add(firstNameTextBox);
            addUserPanel.Controls.Add(createUserCreateButton);
            addUserPanel.Controls.Add(createUserCancelButton);
            addUserPanel.Controls.Add(phoneNumberLabel);
            addUserPanel.Controls.Add(emailLabel);
            addUserPanel.Controls.Add(passwordLabel);
            addUserPanel.Controls.Add(usernameLabel);
            addUserPanel.Controls.Add(lastNamelabel);
            addUserPanel.Controls.Add(addUserNameLabel);
            addUserPanel.Controls.Add(addUserLabel);
            addUserPanel.Location = new Point(10, 199);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(1581, 1070);
            addUserPanel.TabIndex = 25;
            // 
            // serviceDeskLabel
            // 
            serviceDeskLabel.AutoSize = true;
            serviceDeskLabel.Location = new Point(66, 761);
            serviceDeskLabel.Name = "serviceDeskLabel";
            serviceDeskLabel.Size = new Size(225, 30);
            serviceDeskLabel.TabIndex = 31;
            serviceDeskLabel.Text = "Service Desk Employee";
            // 
            // isServiceDeskCheckBox
            // 
            isServiceDeskCheckBox.AutoSize = true;
            isServiceDeskCheckBox.Location = new Point(364, 770);
            isServiceDeskCheckBox.Name = "isServiceDeskCheckBox";
            isServiceDeskCheckBox.Size = new Size(22, 21);
            isServiceDeskCheckBox.TabIndex = 30;
            isServiceDeskCheckBox.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(66, 680);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(92, 30);
            locationLabel.TabIndex = 29;
            locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(360, 675);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(462, 35);
            locationTextBox.TabIndex = 28;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(360, 579);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(462, 35);
            phoneNumberTextBox.TabIndex = 27;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(360, 482);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(462, 35);
            emailTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(360, 399);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(462, 35);
            passwordTextBox.TabIndex = 25;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(360, 310);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(462, 35);
            usernameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(361, 228);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(462, 35);
            lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(361, 142);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(462, 35);
            firstNameTextBox.TabIndex = 18;
            // 
            // createUserCreateButton
            // 
            createUserCreateButton.BackColor = Color.DeepSkyBlue;
            createUserCreateButton.FlatAppearance.BorderColor = Color.Black;
            createUserCreateButton.FlatAppearance.MouseDownBackColor = Color.White;
            createUserCreateButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCreateButton.ForeColor = Color.White;
            createUserCreateButton.Location = new Point(600, 871);
            createUserCreateButton.Name = "createUserCreateButton";
            createUserCreateButton.Size = new Size(222, 68);
            createUserCreateButton.TabIndex = 17;
            createUserCreateButton.Text = "CREATE USER";
            createUserCreateButton.UseVisualStyleBackColor = false;
            createUserCreateButton.Click += createUserCreateButton_Click;
            // 
            // createUserCancelButton
            // 
            createUserCancelButton.BackColor = Color.White;
            createUserCancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCancelButton.Location = new Point(361, 871);
            createUserCancelButton.Name = "createUserCancelButton";
            createUserCancelButton.Size = new Size(188, 68);
            createUserCancelButton.TabIndex = 16;
            createUserCancelButton.Text = "CANCEL";
            createUserCancelButton.UseVisualStyleBackColor = false;
            createUserCancelButton.Click += createUserCancelButton_Click;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(67, 576);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(154, 30);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(69, 479);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(66, 393);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 30);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(66, 310);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(106, 30);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username";
            // 
            // lastNamelabel
            // 
            lastNamelabel.AutoSize = true;
            lastNamelabel.Location = new Point(66, 222);
            lastNamelabel.Name = "lastNamelabel";
            lastNamelabel.Size = new Size(112, 30);
            lastNamelabel.TabIndex = 10;
            lastNamelabel.Text = "Last Name";
            // 
            // addUserNameLabel
            // 
            addUserNameLabel.AutoSize = true;
            addUserNameLabel.Location = new Point(66, 142);
            addUserNameLabel.Name = "addUserNameLabel";
            addUserNameLabel.Size = new Size(113, 30);
            addUserNameLabel.TabIndex = 9;
            addUserNameLabel.Text = "First Name";
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.BackColor = Color.Transparent;
            addUserLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            addUserLabel.Location = new Point(15, 12);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(327, 62);
            addUserLabel.TabIndex = 7;
            addUserLabel.Text = "Add new user";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 1283);
            Controls.Add(ticketOverviewPanel);
            Controls.Add(userManagementPanel);
            Controls.Add(addIncidentPanel);
            Controls.Add(DashboardPanel);
            Controls.Add(addUserPanel);
            Margin = new Padding(6, 7, 6, 7);
            Name = "DashBoard";
            Text = "Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).EndInit();
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            addIncidentPanel.ResumeLayout(false);
            addIncidentPanel.PerformLayout();
            ticketOverviewPanel.ResumeLayout(false);
            ticketOverviewPanel.PerformLayout();
            userManagementPanel.ResumeLayout(false);
            userManagementPanel.PerformLayout();
            addUserPanel.ResumeLayout(false);
            addUserPanel.PerformLayout();
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
        private Label newIncidentLabel;
        private TextBox subjectInput;
        private Button submitTicketButton;
        private Button cancelButton;
        private ComboBox incidentTypeInput;
        private ComboBox deadlineFollowUpInput;
        private ComboBox priorityInput;
        private ComboBox userReportedInput;
        private Panel ticketOverviewPanel;
        private ListView listViewTicketOverview;
        private TextBox filterTextBoxInput;
        private Button createIncidentButton;
        private Label overviewTicketLabel;
        private Panel userManagementPanel;
        private ListView userOverviewLV;
        private TextBox userSearchBox;
        private ColumnHeader number;
        private ColumnHeader email;
        private ColumnHeader firstName;
        private ColumnHeader lastName;
        private ColumnHeader numberOfTickets;
        private Button addUserButton;
        private Panel addUserPanel;
        private TextBox firstNameTextBox;
        private Button createUserCreateButton;
        private Button createUserCancelButton;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label lastNamelabel;
        private Label addUserNameLabel;
        private Label addUserLabel;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private TextBox phoneNumberTextBox;
        private Label locationLabel;
        private TextBox locationTextBox;
        private Label serviceDeskLabel;
        private CheckBox isServiceDeskCheckBox;
    }
}

