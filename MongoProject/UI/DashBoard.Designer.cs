
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
            LogoutButton = new Button();
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
            id = new ColumnHeader();
            EmailAddress = new ColumnHeader();
            Username = new ColumnHeader();
            date = new ColumnHeader();
            priority = new ColumnHeader();
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
            gardenGroupLogo.Location = new Point(3, -2);
            gardenGroupLogo.Name = "gardenGroupLogo";
<<<<<<< HEAD
            gardenGroupLogo.Size = new Size(220, 64);
=======
            gardenGroupLogo.Size = new Size(410, 136);
>>>>>>> Louise
            gardenGroupLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            gardenGroupLogo.TabIndex = 1;
            gardenGroupLogo.TabStop = false;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.White;
            DashboardPanel.BorderStyle = BorderStyle.FixedSingle;
            DashboardPanel.Controls.Add(LogoutButton);
            DashboardPanel.Controls.Add(userManagementButton);
            DashboardPanel.Controls.Add(incidentManagementButton);
            DashboardPanel.Controls.Add(DashBoardButton);
            DashboardPanel.Controls.Add(licensedToLabel);
            DashboardPanel.Controls.Add(noDeskLabel);
            DashboardPanel.Controls.Add(gardenGroupLogo);
<<<<<<< HEAD
            DashboardPanel.Location = new Point(8, 5);
            DashboardPanel.Margin = new Padding(2);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(923, 94);
=======
            DashboardPanel.Location = new Point(15, 11);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(1713, 199);
>>>>>>> Louise
            DashboardPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            LogoutButton.Location = new Point(835, 64);
            LogoutButton.Margin = new Padding(3, 2, 3, 2);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(88, 26);
=======
            LogoutButton.Location = new Point(1550, 138);
            LogoutButton.Margin = new Padding(5);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(162, 54);
>>>>>>> Louise
            LogoutButton.TabIndex = 7;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // userManagementButton
            // 
            userManagementButton.BackColor = Color.White;
            userManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            userManagementButton.Location = new Point(559, 64);
            userManagementButton.Margin = new Padding(2);
            userManagementButton.Name = "userManagementButton";
            userManagementButton.Size = new Size(276, 26);
=======
            userManagementButton.Location = new Point(1038, 138);
            userManagementButton.Name = "userManagementButton";
            userManagementButton.Size = new Size(514, 56);
>>>>>>> Louise
            userManagementButton.TabIndex = 6;
            userManagementButton.Text = "User Management";
            userManagementButton.UseVisualStyleBackColor = false;
            userManagementButton.Click += userManagementButton_Click;
            // 
            // incidentManagementButton
            // 
            incidentManagementButton.BackColor = Color.White;
            incidentManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            incidentManagementButton.Location = new Point(279, 64);
            incidentManagementButton.Margin = new Padding(2);
            incidentManagementButton.Name = "incidentManagementButton";
            incidentManagementButton.Size = new Size(276, 26);
=======
            incidentManagementButton.Location = new Point(518, 138);
            incidentManagementButton.Name = "incidentManagementButton";
            incidentManagementButton.Size = new Size(514, 56);
>>>>>>> Louise
            incidentManagementButton.TabIndex = 5;
            incidentManagementButton.Text = "Incident Management";
            incidentManagementButton.UseVisualStyleBackColor = false;
            incidentManagementButton.Click += incidentManagementButton_Click;
            // 
            // DashBoardButton
            // 
            DashBoardButton.BackColor = Color.White;
            DashBoardButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            DashBoardButton.Location = new Point(-1, 64);
            DashBoardButton.Margin = new Padding(2);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(276, 26);
=======
            DashBoardButton.Location = new Point(-2, 138);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(514, 56);
>>>>>>> Louise
            DashBoardButton.TabIndex = 4;
            DashBoardButton.Text = "Dashboard";
            DashBoardButton.UseVisualStyleBackColor = false;
            // 
            // licensedToLabel
            // 
            licensedToLabel.AutoSize = true;
            licensedToLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            licensedToLabel.Location = new Point(614, 34);
            licensedToLabel.Margin = new Padding(2, 0, 2, 0);
            licensedToLabel.Name = "licensedToLabel";
            licensedToLabel.Size = new Size(288, 25);
=======
            licensedToLabel.Location = new Point(1141, 72);
            licensedToLabel.Name = "licensedToLabel";
            licensedToLabel.Size = new Size(557, 50);
>>>>>>> Louise
            licensedToLabel.TabIndex = 3;
            licensedToLabel.Text = "Licensed to: The Garden Group";
            // 
            // noDeskLabel
            // 
            noDeskLabel.AutoSize = true;
            noDeskLabel.BackColor = Color.Transparent;
            noDeskLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            noDeskLabel.Location = new Point(794, 0);
            noDeskLabel.Margin = new Padding(2, 0, 2, 0);
            noDeskLabel.Name = "noDeskLabel";
            noDeskLabel.Size = new Size(117, 37);
=======
            noDeskLabel.Location = new Point(1474, 0);
            noDeskLabel.Name = "noDeskLabel";
            noDeskLabel.Size = new Size(225, 71);
>>>>>>> Louise
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
<<<<<<< HEAD
            addIncidentPanel.Location = new Point(8, 101);
            addIncidentPanel.Margin = new Padding(2);
            addIncidentPanel.Name = "addIncidentPanel";
            addIncidentPanel.Size = new Size(922, 535);
=======
            addIncidentPanel.Location = new Point(15, 216);
            addIncidentPanel.Name = "addIncidentPanel";
            addIncidentPanel.Size = new Size(1713, 1141);
>>>>>>> Louise
            addIncidentPanel.TabIndex = 2;
            // 
            // deadlineFollowUpInput
            // 
            deadlineFollowUpInput.FormattingEnabled = true;
<<<<<<< HEAD
            deadlineFollowUpInput.Location = new Point(211, 238);
            deadlineFollowUpInput.Margin = new Padding(2);
            deadlineFollowUpInput.Name = "deadlineFollowUpInput";
            deadlineFollowUpInput.Size = new Size(271, 23);
=======
            deadlineFollowUpInput.Location = new Point(392, 507);
            deadlineFollowUpInput.Name = "deadlineFollowUpInput";
            deadlineFollowUpInput.Size = new Size(500, 40);
>>>>>>> Louise
            deadlineFollowUpInput.TabIndex = 22;
            // 
            // priorityInput
            // 
            priorityInput.FormattingEnabled = true;
<<<<<<< HEAD
            priorityInput.Location = new Point(211, 196);
            priorityInput.Margin = new Padding(2);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(271, 23);
=======
            priorityInput.Location = new Point(392, 419);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(500, 40);
>>>>>>> Louise
            priorityInput.TabIndex = 21;
            // 
            // userReportedInput
            // 
            userReportedInput.FormattingEnabled = true;
<<<<<<< HEAD
            userReportedInput.Location = new Point(211, 155);
            userReportedInput.Margin = new Padding(2);
            userReportedInput.Name = "userReportedInput";
            userReportedInput.Size = new Size(271, 23);
=======
            userReportedInput.Location = new Point(392, 331);
            userReportedInput.Name = "userReportedInput";
            userReportedInput.Size = new Size(500, 40);
>>>>>>> Louise
            userReportedInput.TabIndex = 20;
            userReportedInput.Text = " Select user";
            // 
            // incidentTypeInput
            // 
            incidentTypeInput.FormattingEnabled = true;
<<<<<<< HEAD
            incidentTypeInput.Location = new Point(211, 111);
            incidentTypeInput.Margin = new Padding(2);
            incidentTypeInput.Name = "incidentTypeInput";
            incidentTypeInput.Size = new Size(271, 23);
=======
            incidentTypeInput.Location = new Point(392, 237);
            incidentTypeInput.Name = "incidentTypeInput";
            incidentTypeInput.Size = new Size(500, 40);
>>>>>>> Louise
            incidentTypeInput.TabIndex = 19;
            incidentTypeInput.Text = " Select type";
            // 
            // subjectInput
            // 
<<<<<<< HEAD
            subjectInput.Location = new Point(211, 71);
            subjectInput.Margin = new Padding(2);
            subjectInput.Name = "subjectInput";
            subjectInput.Size = new Size(271, 23);
=======
            subjectInput.Location = new Point(392, 152);
            subjectInput.Name = "subjectInput";
            subjectInput.Size = new Size(500, 39);
>>>>>>> Louise
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
<<<<<<< HEAD
            submitTicketButton.Location = new Point(350, 436);
            submitTicketButton.Margin = new Padding(2);
            submitTicketButton.Name = "submitTicketButton";
            submitTicketButton.Size = new Size(130, 34);
=======
            submitTicketButton.Location = new Point(650, 930);
            submitTicketButton.Name = "submitTicketButton";
            submitTicketButton.Size = new Size(240, 72);
>>>>>>> Louise
            submitTicketButton.TabIndex = 17;
            submitTicketButton.Text = "SUBMIT TICKET";
            submitTicketButton.UseVisualStyleBackColor = false;
            submitTicketButton.Click += submitTicketButton_Click_1;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            cancelButton.Location = new Point(211, 436);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(109, 34);
=======
            cancelButton.Location = new Point(392, 930);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(203, 72);
>>>>>>> Louise
            cancelButton.TabIndex = 16;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // descriptionInput
            // 
<<<<<<< HEAD
            descriptionInput.Location = new Point(211, 288);
            descriptionInput.Margin = new Padding(2);
            descriptionInput.MinimumSize = new Size(4, 96);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(271, 122);
=======
            descriptionInput.Location = new Point(392, 614);
            descriptionInput.MinimumSize = new Size(4, 201);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(500, 257);
>>>>>>> Louise
            descriptionInput.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
<<<<<<< HEAD
            descriptionLabel.Location = new Point(39, 288);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
=======
            descriptionLabel.Location = new Point(73, 614);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(140, 32);
>>>>>>> Louise
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // deadlineFollowUpLabel
            // 
            deadlineFollowUpLabel.AutoSize = true;
<<<<<<< HEAD
            deadlineFollowUpLabel.Location = new Point(37, 238);
            deadlineFollowUpLabel.Margin = new Padding(2, 0, 2, 0);
            deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            deadlineFollowUpLabel.Size = new Size(111, 15);
=======
            deadlineFollowUpLabel.Location = new Point(68, 507);
            deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            deadlineFollowUpLabel.Size = new Size(223, 32);
>>>>>>> Louise
            deadlineFollowUpLabel.TabIndex = 13;
            deadlineFollowUpLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
<<<<<<< HEAD
            priorityLabel.Location = new Point(38, 196);
            priorityLabel.Margin = new Padding(2, 0, 2, 0);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(48, 15);
=======
            priorityLabel.Location = new Point(72, 419);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(94, 32);
>>>>>>> Louise
            priorityLabel.TabIndex = 12;
            priorityLabel.Text = "Priority:";
            // 
            // userReportedLabel
            // 
            userReportedLabel.AutoSize = true;
<<<<<<< HEAD
            userReportedLabel.Location = new Point(38, 155);
            userReportedLabel.Margin = new Padding(2, 0, 2, 0);
            userReportedLabel.Name = "userReportedLabel";
            userReportedLabel.Size = new Size(99, 15);
=======
            userReportedLabel.Location = new Point(72, 331);
            userReportedLabel.Name = "userReportedLabel";
            userReportedLabel.Size = new Size(201, 32);
>>>>>>> Louise
            userReportedLabel.TabIndex = 11;
            userReportedLabel.Text = "Reported by user:";
            // 
            // incidentTypeLabel
            // 
            incidentTypeLabel.AutoSize = true;
<<<<<<< HEAD
            incidentTypeLabel.Location = new Point(38, 111);
            incidentTypeLabel.Margin = new Padding(2, 0, 2, 0);
            incidentTypeLabel.Name = "incidentTypeLabel";
            incidentTypeLabel.Size = new Size(94, 15);
=======
            incidentTypeLabel.Location = new Point(72, 237);
            incidentTypeLabel.Name = "incidentTypeLabel";
            incidentTypeLabel.Size = new Size(192, 32);
>>>>>>> Louise
            incidentTypeLabel.TabIndex = 10;
            incidentTypeLabel.Text = "Type of incident:";
            // 
            // subjectIncidentLabel
            // 
            subjectIncidentLabel.AutoSize = true;
<<<<<<< HEAD
            subjectIncidentLabel.Location = new Point(38, 71);
            subjectIncidentLabel.Margin = new Padding(2, 0, 2, 0);
            subjectIncidentLabel.Name = "subjectIncidentLabel";
            subjectIncidentLabel.Size = new Size(106, 15);
=======
            subjectIncidentLabel.Location = new Point(72, 152);
            subjectIncidentLabel.Name = "subjectIncidentLabel";
            subjectIncidentLabel.Size = new Size(215, 32);
>>>>>>> Louise
            subjectIncidentLabel.TabIndex = 9;
            subjectIncidentLabel.Text = "Subject of incident";
            // 
            // newIncidentLabel
            // 
            newIncidentLabel.AutoSize = true;
            newIncidentLabel.BackColor = Color.Transparent;
            newIncidentLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            newIncidentLabel.Location = new Point(9, 6);
            newIncidentLabel.Margin = new Padding(2, 0, 2, 0);
            newIncidentLabel.Name = "newIncidentLabel";
            newIncidentLabel.Size = new Size(352, 37);
=======
            newIncidentLabel.Location = new Point(16, 13);
            newIncidentLabel.Name = "newIncidentLabel";
            newIncidentLabel.Size = new Size(682, 71);
>>>>>>> Louise
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
<<<<<<< HEAD
            ticketOverviewPanel.Location = new Point(8, 101);
            ticketOverviewPanel.Margin = new Padding(2);
            ticketOverviewPanel.Name = "ticketOverviewPanel";
            ticketOverviewPanel.Size = new Size(922, 535);
=======
            ticketOverviewPanel.Location = new Point(15, 216);
            ticketOverviewPanel.Name = "ticketOverviewPanel";
            ticketOverviewPanel.Size = new Size(1713, 1141);
>>>>>>> Louise
            ticketOverviewPanel.TabIndex = 24;
            // 
            // listViewTicketOverview
            // 
            listViewTicketOverview.Columns.AddRange(new ColumnHeader[] { id, EmailAddress, Username, date, priority });
            listViewTicketOverview.FullRowSelect = true;
            listViewTicketOverview.GridLines = true;
<<<<<<< HEAD
            listViewTicketOverview.Location = new Point(37, 110);
            listViewTicketOverview.Margin = new Padding(2);
            listViewTicketOverview.Name = "listViewTicketOverview";
            listViewTicketOverview.Size = new Size(851, 407);
=======
            listViewTicketOverview.Location = new Point(68, 235);
            listViewTicketOverview.Name = "listViewTicketOverview";
            listViewTicketOverview.Size = new Size(1577, 863);
>>>>>>> Louise
            listViewTicketOverview.TabIndex = 20;
            listViewTicketOverview.UseCompatibleStateImageBehavior = false;
            listViewTicketOverview.View = View.Details;
            listViewTicketOverview.SelectedIndexChanged += listViewTicketOverview_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // EmailAddress
            // 
            EmailAddress.Text = "Email address";
            EmailAddress.Width = 350;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 200;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 270;
            // 
            // priority
            // 
            priority.Text = "Priority";
            priority.Width = 70;
            // 
            // filterTextBoxInput
            // 
            filterTextBoxInput.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            filterTextBoxInput.ForeColor = Color.Silver;
<<<<<<< HEAD
            filterTextBoxInput.Location = new Point(37, 68);
            filterTextBoxInput.Margin = new Padding(2);
            filterTextBoxInput.Multiline = true;
            filterTextBoxInput.Name = "filterTextBoxInput";
            filterTextBoxInput.Size = new Size(253, 36);
=======
            filterTextBoxInput.Location = new Point(68, 146);
            filterTextBoxInput.Multiline = true;
            filterTextBoxInput.Name = "filterTextBoxInput";
            filterTextBoxInput.Size = new Size(467, 73);
>>>>>>> Louise
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
<<<<<<< HEAD
            createIncidentButton.Location = new Point(756, 68);
            createIncidentButton.Margin = new Padding(2);
            createIncidentButton.Name = "createIncidentButton";
            createIncidentButton.Size = new Size(130, 34);
=======
            createIncidentButton.Location = new Point(1404, 146);
            createIncidentButton.Name = "createIncidentButton";
            createIncidentButton.Size = new Size(240, 72);
>>>>>>> Louise
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
<<<<<<< HEAD
            overviewTicketLabel.Location = new Point(9, 6);
            overviewTicketLabel.Margin = new Padding(2, 0, 2, 0);
            overviewTicketLabel.Name = "overviewTicketLabel";
            overviewTicketLabel.Size = new Size(236, 37);
=======
            overviewTicketLabel.Location = new Point(16, 13);
            overviewTicketLabel.Name = "overviewTicketLabel";
            overviewTicketLabel.Size = new Size(453, 71);
>>>>>>> Louise
            overviewTicketLabel.TabIndex = 8;
            overviewTicketLabel.Text = "Overview Tickets";
            // 
            // userManagementPanel
            // 
            userManagementPanel.BackColor = Color.White;
            userManagementPanel.Controls.Add(addUserButton);
            userManagementPanel.Controls.Add(userSearchBox);
            userManagementPanel.Controls.Add(userOverviewLV);
<<<<<<< HEAD
            userManagementPanel.Location = new Point(8, 101);
            userManagementPanel.Margin = new Padding(2);
            userManagementPanel.Name = "userManagementPanel";
            userManagementPanel.Size = new Size(922, 535);
=======
            userManagementPanel.Location = new Point(15, 216);
            userManagementPanel.Name = "userManagementPanel";
            userManagementPanel.Size = new Size(1713, 1141);
>>>>>>> Louise
            userManagementPanel.TabIndex = 23;
            // 
            // addUserButton
            // 
<<<<<<< HEAD
            addUserButton.Location = new Point(679, 22);
            addUserButton.Margin = new Padding(2);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(105, 20);
=======
            addUserButton.Location = new Point(1261, 48);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(195, 43);
>>>>>>> Louise
            addUserButton.TabIndex = 2;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // userSearchBox
            // 
<<<<<<< HEAD
            userSearchBox.Location = new Point(124, 25);
            userSearchBox.Margin = new Padding(2);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(183, 23);
=======
            userSearchBox.Location = new Point(231, 53);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(337, 39);
>>>>>>> Louise
            userSearchBox.TabIndex = 1;
            userSearchBox.TextChanged += userSearchBox_TextChanged;
            // 
            // userOverviewLV
            // 
            userOverviewLV.Columns.AddRange(new ColumnHeader[] { number, email, firstName, lastName, numberOfTickets });
            userOverviewLV.FullRowSelect = true;
<<<<<<< HEAD
            userOverviewLV.Location = new Point(124, 71);
            userOverviewLV.Margin = new Padding(2);
            userOverviewLV.Name = "userOverviewLV";
            userOverviewLV.Size = new Size(661, 446);
=======
            userOverviewLV.Location = new Point(231, 152);
            userOverviewLV.Name = "userOverviewLV";
            userOverviewLV.Size = new Size(1224, 946);
>>>>>>> Louise
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
            email.Width = 200;
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
<<<<<<< HEAD
            addUserPanel.Location = new Point(6, 100);
            addUserPanel.Margin = new Padding(2);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(922, 535);
=======
            addUserPanel.Location = new Point(11, 213);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(1713, 1141);
>>>>>>> Louise
            addUserPanel.TabIndex = 25;
            // 
            // serviceDeskLabel
            // 
            serviceDeskLabel.AutoSize = true;
<<<<<<< HEAD
            serviceDeskLabel.Location = new Point(38, 380);
            serviceDeskLabel.Margin = new Padding(2, 0, 2, 0);
            serviceDeskLabel.Name = "serviceDeskLabel";
            serviceDeskLabel.Size = new Size(127, 15);
=======
            serviceDeskLabel.Location = new Point(72, 811);
            serviceDeskLabel.Name = "serviceDeskLabel";
            serviceDeskLabel.Size = new Size(261, 32);
>>>>>>> Louise
            serviceDeskLabel.TabIndex = 31;
            serviceDeskLabel.Text = "Service Desk Employee";
            // 
            // isServiceDeskCheckBox
            // 
            isServiceDeskCheckBox.AutoSize = true;
<<<<<<< HEAD
            isServiceDeskCheckBox.Location = new Point(213, 385);
            isServiceDeskCheckBox.Margin = new Padding(2);
            isServiceDeskCheckBox.Name = "isServiceDeskCheckBox";
            isServiceDeskCheckBox.Size = new Size(15, 14);
=======
            isServiceDeskCheckBox.Location = new Point(395, 821);
            isServiceDeskCheckBox.Name = "isServiceDeskCheckBox";
            isServiceDeskCheckBox.Size = new Size(28, 27);
>>>>>>> Louise
            isServiceDeskCheckBox.TabIndex = 30;
            isServiceDeskCheckBox.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
<<<<<<< HEAD
            locationLabel.Location = new Point(38, 340);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
=======
            locationLabel.Location = new Point(72, 725);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(104, 32);
>>>>>>> Louise
            locationLabel.TabIndex = 29;
            locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
<<<<<<< HEAD
            locationTextBox.Location = new Point(210, 338);
            locationTextBox.Margin = new Padding(2);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(271, 23);
=======
            locationTextBox.Location = new Point(390, 720);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            locationTextBox.TabIndex = 28;
            // 
            // phoneNumberTextBox
            // 
<<<<<<< HEAD
            phoneNumberTextBox.Location = new Point(210, 290);
            phoneNumberTextBox.Margin = new Padding(2);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(271, 23);
=======
            phoneNumberTextBox.Location = new Point(390, 618);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            phoneNumberTextBox.TabIndex = 27;
            // 
            // emailTextBox
            // 
<<<<<<< HEAD
            emailTextBox.Location = new Point(210, 241);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(271, 23);
=======
            emailTextBox.Location = new Point(390, 514);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            emailTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
<<<<<<< HEAD
            passwordTextBox.Location = new Point(210, 200);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(271, 23);
=======
            passwordTextBox.Location = new Point(390, 426);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            passwordTextBox.TabIndex = 25;
            // 
            // usernameTextBox
            // 
<<<<<<< HEAD
            usernameTextBox.Location = new Point(210, 155);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(271, 23);
=======
            usernameTextBox.Location = new Point(390, 331);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            usernameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
<<<<<<< HEAD
            lastNameTextBox.Location = new Point(211, 114);
            lastNameTextBox.Margin = new Padding(2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(271, 23);
=======
            lastNameTextBox.Location = new Point(392, 243);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
<<<<<<< HEAD
            firstNameTextBox.Location = new Point(211, 71);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(271, 23);
=======
            firstNameTextBox.Location = new Point(392, 152);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(500, 39);
>>>>>>> Louise
            firstNameTextBox.TabIndex = 18;
            // 
            // createUserCreateButton
            // 
            createUserCreateButton.BackColor = Color.DeepSkyBlue;
            createUserCreateButton.FlatAppearance.BorderColor = Color.Black;
            createUserCreateButton.FlatAppearance.MouseDownBackColor = Color.White;
            createUserCreateButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCreateButton.ForeColor = Color.White;
<<<<<<< HEAD
            createUserCreateButton.Location = new Point(350, 436);
            createUserCreateButton.Margin = new Padding(2);
            createUserCreateButton.Name = "createUserCreateButton";
            createUserCreateButton.Size = new Size(130, 34);
=======
            createUserCreateButton.Location = new Point(650, 930);
            createUserCreateButton.Name = "createUserCreateButton";
            createUserCreateButton.Size = new Size(240, 72);
>>>>>>> Louise
            createUserCreateButton.TabIndex = 17;
            createUserCreateButton.Text = "CREATE USER";
            createUserCreateButton.UseVisualStyleBackColor = false;
            createUserCreateButton.Click += createUserCreateButton_Click;
            // 
            // createUserCancelButton
            // 
            createUserCancelButton.BackColor = Color.White;
            createUserCancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            createUserCancelButton.Location = new Point(211, 436);
            createUserCancelButton.Margin = new Padding(2);
            createUserCancelButton.Name = "createUserCancelButton";
            createUserCancelButton.Size = new Size(109, 34);
=======
            createUserCancelButton.Location = new Point(392, 930);
            createUserCancelButton.Name = "createUserCancelButton";
            createUserCancelButton.Size = new Size(203, 72);
>>>>>>> Louise
            createUserCancelButton.TabIndex = 16;
            createUserCancelButton.Text = "CANCEL";
            createUserCancelButton.UseVisualStyleBackColor = false;
            createUserCancelButton.Click += createUserCancelButton_Click;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
<<<<<<< HEAD
            phoneNumberLabel.Location = new Point(39, 288);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
=======
            phoneNumberLabel.Location = new Point(73, 614);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(177, 32);
>>>>>>> Louise
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
<<<<<<< HEAD
            emailLabel.Location = new Point(40, 239);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
=======
            emailLabel.Location = new Point(75, 510);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 32);
>>>>>>> Louise
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
<<<<<<< HEAD
            passwordLabel.Location = new Point(38, 196);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
=======
            passwordLabel.Location = new Point(72, 419);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(111, 32);
>>>>>>> Louise
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
<<<<<<< HEAD
            usernameLabel.Location = new Point(38, 155);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
=======
            usernameLabel.Location = new Point(72, 331);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(121, 32);
>>>>>>> Louise
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username";
            // 
            // lastNamelabel
            // 
            lastNamelabel.AutoSize = true;
<<<<<<< HEAD
            lastNamelabel.Location = new Point(38, 111);
            lastNamelabel.Margin = new Padding(2, 0, 2, 0);
            lastNamelabel.Name = "lastNamelabel";
            lastNamelabel.Size = new Size(63, 15);
=======
            lastNamelabel.Location = new Point(72, 237);
            lastNamelabel.Name = "lastNamelabel";
            lastNamelabel.Size = new Size(126, 32);
>>>>>>> Louise
            lastNamelabel.TabIndex = 10;
            lastNamelabel.Text = "Last Name";
            // 
            // addUserNameLabel
            // 
            addUserNameLabel.AutoSize = true;
<<<<<<< HEAD
            addUserNameLabel.Location = new Point(38, 71);
            addUserNameLabel.Margin = new Padding(2, 0, 2, 0);
            addUserNameLabel.Name = "addUserNameLabel";
            addUserNameLabel.Size = new Size(64, 15);
=======
            addUserNameLabel.Location = new Point(72, 152);
            addUserNameLabel.Name = "addUserNameLabel";
            addUserNameLabel.Size = new Size(129, 32);
>>>>>>> Louise
            addUserNameLabel.TabIndex = 9;
            addUserNameLabel.Text = "First Name";
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.BackColor = Color.Transparent;
            addUserLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
<<<<<<< HEAD
            addUserLabel.Location = new Point(9, 6);
            addUserLabel.Margin = new Padding(2, 0, 2, 0);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(191, 37);
=======
            addUserLabel.Location = new Point(16, 13);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(371, 71);
>>>>>>> Louise
            addUserLabel.TabIndex = 7;
            addUserLabel.Text = "Add new user";
            // 
            // DashBoard
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 641);
=======
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 1368);
>>>>>>> Louise
            Controls.Add(ticketOverviewPanel);
            Controls.Add(addIncidentPanel);
            Controls.Add(userManagementPanel);
            Controls.Add(addIncidentPanel);
            Controls.Add(DashboardPanel);
            Controls.Add(addUserPanel);
<<<<<<< HEAD
            Margin = new Padding(4);
=======
            Margin = new Padding(6, 8, 6, 8);
>>>>>>> Louise
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
        private Button LogoutButton;
        private ColumnHeader id;
        private ColumnHeader EmailAddress;
        private ColumnHeader Username;
        private ColumnHeader date;
        private ColumnHeader priority;
    }
}

