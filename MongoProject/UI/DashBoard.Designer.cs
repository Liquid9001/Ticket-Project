
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            deleteIncidentButton = new Button();
            updateIncidentButton = new Button();
            checkBoxPriorityFilter = new CheckBox();
            listViewTicketOverview = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            filterTextBoxInput = new TextBox();
            createIncidentButton = new Button();
            overviewTicketLabel = new Label();
            userManagementPanel = new Panel();
            editUserButton = new Button();
            addUserButton = new Button();
            userSearchBox = new TextBox();
            userOverviewLV = new ListView();
            number = new ColumnHeader();
            email = new ColumnHeader();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            numberOfTickets = new ColumnHeader();
            addUserPanel = new Panel();
            modifyUserLabel = new Label();
            deleteUserButton = new Button();
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
            panelDashboard = new Panel();
            ShowListButton = new Button();
            CurrentIncidentsLabel = new Label();
            ClosedTicketsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            OpenTicketsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            modifyIncidentPanel = new Panel();
            statusComboBox = new ComboBox();
            statusLabel = new Label();
            labelTicket = new Label();
            deadlineInputModify = new ComboBox();
            priorityInputModify = new ComboBox();
            reportedbyInputModify = new ComboBox();
            typeinputModify = new ComboBox();
            subjectInputModify = new TextBox();
            modifyTicketButton = new Button();
            cancelModifyButton = new Button();
            descriptionModifyInput = new TextBox();
            labelDescription = new Label();
            labelDeadline = new Label();
            labelPriority = new Label();
            labelReportedBy = new Label();
            labelTypeOfIncident = new Label();
            labelSubject = new Label();
            labelModify = new Label();
            ((System.ComponentModel.ISupportInitialize)gardenGroupLogo).BeginInit();
            DashboardPanel.SuspendLayout();
            addIncidentPanel.SuspendLayout();
            ticketOverviewPanel.SuspendLayout();
            userManagementPanel.SuspendLayout();
            addUserPanel.SuspendLayout();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClosedTicketsChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenTicketsChart).BeginInit();
            modifyIncidentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gardenGroupLogo
            // 
            gardenGroupLogo.Image = (Image)resources.GetObject("gardenGroupLogo.Image");
            gardenGroupLogo.Location = new Point(2, -1);
            gardenGroupLogo.Margin = new Padding(2, 2, 2, 2);
            gardenGroupLogo.Name = "gardenGroupLogo";
            gardenGroupLogo.Size = new Size(418, 60);
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
            DashboardPanel.Location = new Point(8, 5);
            DashboardPanel.Margin = new Padding(2, 2, 2, 2);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(924, 94);
            DashboardPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(835, 64);
            LogoutButton.Margin = new Padding(2, 2, 2, 2);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(89, 26);
            LogoutButton.TabIndex = 7;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // userManagementButton
            // 
            userManagementButton.BackColor = Color.White;
            userManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            userManagementButton.Location = new Point(559, 64);
            userManagementButton.Margin = new Padding(2, 2, 2, 2);
            userManagementButton.Name = "userManagementButton";
            userManagementButton.Size = new Size(275, 26);
            userManagementButton.TabIndex = 6;
            userManagementButton.Text = "User Management";
            userManagementButton.UseVisualStyleBackColor = false;
            userManagementButton.Click += userManagementButton_Click;
            // 
            // incidentManagementButton
            // 
            incidentManagementButton.BackColor = Color.White;
            incidentManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            incidentManagementButton.Location = new Point(279, 64);
            incidentManagementButton.Margin = new Padding(2, 2, 2, 2);
            incidentManagementButton.Name = "incidentManagementButton";
            incidentManagementButton.Size = new Size(275, 26);
            incidentManagementButton.TabIndex = 5;
            incidentManagementButton.Text = "Incident Management";
            incidentManagementButton.UseVisualStyleBackColor = false;
            incidentManagementButton.Click += incidentManagementButton_Click;
            // 
            // DashBoardButton
            // 
            DashBoardButton.BackColor = Color.White;
            DashBoardButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            DashBoardButton.Location = new Point(-1, 64);
            DashBoardButton.Margin = new Padding(2, 2, 2, 2);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(275, 26);
            DashBoardButton.TabIndex = 4;
            DashBoardButton.Text = "Dashboard";
            DashBoardButton.UseVisualStyleBackColor = false;
            DashBoardButton.Click += DashBoardButton_Click;
            // 
            // licensedToLabel
            // 
            licensedToLabel.AutoSize = true;
            licensedToLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            licensedToLabel.Location = new Point(614, 34);
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
            addIncidentPanel.Location = new Point(8, 101);
            addIncidentPanel.Margin = new Padding(2, 2, 2, 2);
            addIncidentPanel.Name = "addIncidentPanel";
            addIncidentPanel.Size = new Size(922, 535);
            addIncidentPanel.TabIndex = 2;
            // 
            // deadlineFollowUpInput
            // 
            deadlineFollowUpInput.DropDownStyle = ComboBoxStyle.DropDownList;
            deadlineFollowUpInput.FormattingEnabled = true;
            deadlineFollowUpInput.Location = new Point(211, 238);
            deadlineFollowUpInput.Margin = new Padding(2, 2, 2, 2);
            deadlineFollowUpInput.Name = "deadlineFollowUpInput";
            deadlineFollowUpInput.Size = new Size(271, 23);
            deadlineFollowUpInput.TabIndex = 22;
            // 
            // priorityInput
            // 
            priorityInput.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityInput.FormattingEnabled = true;
            priorityInput.Location = new Point(211, 196);
            priorityInput.Margin = new Padding(2, 2, 2, 2);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(271, 23);
            priorityInput.TabIndex = 21;
            // 
            // userReportedInput
            // 
            userReportedInput.DropDownStyle = ComboBoxStyle.DropDownList;
            userReportedInput.FormattingEnabled = true;
            userReportedInput.Location = new Point(211, 155);
            userReportedInput.Margin = new Padding(2, 2, 2, 2);
            userReportedInput.Name = "userReportedInput";
            userReportedInput.Size = new Size(271, 23);
            userReportedInput.TabIndex = 20;
            // 
            // incidentTypeInput
            // 
            incidentTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            incidentTypeInput.FormattingEnabled = true;
            incidentTypeInput.Location = new Point(211, 111);
            incidentTypeInput.Margin = new Padding(2, 2, 2, 2);
            incidentTypeInput.Name = "incidentTypeInput";
            incidentTypeInput.Size = new Size(271, 23);
            incidentTypeInput.TabIndex = 19;
            // 
            // subjectInput
            // 
            subjectInput.Location = new Point(211, 71);
            subjectInput.Margin = new Padding(2, 2, 2, 2);
            subjectInput.Name = "subjectInput";
            subjectInput.Size = new Size(271, 23);
            subjectInput.TabIndex = 18;
            // 
            // submitTicketButton
            // 
            submitTicketButton.BackColor = Color.DeepSkyBlue;
            submitTicketButton.FlatAppearance.BorderColor = Color.Black;
            submitTicketButton.FlatAppearance.MouseDownBackColor = Color.White;
            submitTicketButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            submitTicketButton.ForeColor = Color.White;
            submitTicketButton.Location = new Point(350, 436);
            submitTicketButton.Margin = new Padding(2, 2, 2, 2);
            submitTicketButton.Name = "submitTicketButton";
            submitTicketButton.Size = new Size(131, 34);
            submitTicketButton.TabIndex = 17;
            submitTicketButton.Text = "SUBMIT TICKET";
            submitTicketButton.UseVisualStyleBackColor = false;
            submitTicketButton.Click += submitTicketButton_Click_1;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(211, 436);
            cancelButton.Margin = new Padding(2, 2, 2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(110, 34);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click_1;
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(211, 288);
            descriptionInput.Margin = new Padding(2, 2, 2, 2);
            descriptionInput.MinimumSize = new Size(4, 96);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(271, 122);
            descriptionInput.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(40, 288);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // deadlineFollowUpLabel
            // 
            deadlineFollowUpLabel.AutoSize = true;
            deadlineFollowUpLabel.Location = new Point(37, 238);
            deadlineFollowUpLabel.Margin = new Padding(2, 0, 2, 0);
            deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            deadlineFollowUpLabel.Size = new Size(111, 15);
            deadlineFollowUpLabel.TabIndex = 13;
            deadlineFollowUpLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(37, 196);
            priorityLabel.Margin = new Padding(2, 0, 2, 0);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(48, 15);
            priorityLabel.TabIndex = 12;
            priorityLabel.Text = "Priority:";
            // 
            // userReportedLabel
            // 
            userReportedLabel.AutoSize = true;
            userReportedLabel.Location = new Point(37, 155);
            userReportedLabel.Margin = new Padding(2, 0, 2, 0);
            userReportedLabel.Name = "userReportedLabel";
            userReportedLabel.Size = new Size(99, 15);
            userReportedLabel.TabIndex = 11;
            userReportedLabel.Text = "Reported by user:";
            // 
            // incidentTypeLabel
            // 
            incidentTypeLabel.AutoSize = true;
            incidentTypeLabel.Location = new Point(37, 111);
            incidentTypeLabel.Margin = new Padding(2, 0, 2, 0);
            incidentTypeLabel.Name = "incidentTypeLabel";
            incidentTypeLabel.Size = new Size(94, 15);
            incidentTypeLabel.TabIndex = 10;
            incidentTypeLabel.Text = "Type of incident:";
            // 
            // subjectIncidentLabel
            // 
            subjectIncidentLabel.AutoSize = true;
            subjectIncidentLabel.Location = new Point(37, 71);
            subjectIncidentLabel.Margin = new Padding(2, 0, 2, 0);
            subjectIncidentLabel.Name = "subjectIncidentLabel";
            subjectIncidentLabel.Size = new Size(106, 15);
            subjectIncidentLabel.TabIndex = 9;
            subjectIncidentLabel.Text = "Subject of incident";
            // 
            // newIncidentLabel
            // 
            newIncidentLabel.AutoSize = true;
            newIncidentLabel.BackColor = Color.Transparent;
            newIncidentLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            newIncidentLabel.Location = new Point(9, 6);
            newIncidentLabel.Margin = new Padding(2, 0, 2, 0);
            newIncidentLabel.Name = "newIncidentLabel";
            newIncidentLabel.Size = new Size(352, 37);
            newIncidentLabel.TabIndex = 7;
            newIncidentLabel.Text = "Create new incident ticket";
            // 
            // ticketOverviewPanel
            // 
            ticketOverviewPanel.BackColor = Color.White;
            ticketOverviewPanel.Controls.Add(deleteIncidentButton);
            ticketOverviewPanel.Controls.Add(updateIncidentButton);
            ticketOverviewPanel.Controls.Add(checkBoxPriorityFilter);
            ticketOverviewPanel.Controls.Add(listViewTicketOverview);
            ticketOverviewPanel.Controls.Add(filterTextBoxInput);
            ticketOverviewPanel.Controls.Add(createIncidentButton);
            ticketOverviewPanel.Controls.Add(overviewTicketLabel);
            ticketOverviewPanel.Location = new Point(8, 101);
            ticketOverviewPanel.Margin = new Padding(2, 2, 2, 2);
            ticketOverviewPanel.Name = "ticketOverviewPanel";
            ticketOverviewPanel.Size = new Size(922, 535);
            ticketOverviewPanel.TabIndex = 24;
            // 
            // deleteIncidentButton
            // 
            deleteIncidentButton.BackColor = Color.Crimson;
            deleteIncidentButton.FlatAppearance.BorderColor = Color.Black;
            deleteIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            deleteIncidentButton.Font = new Font("Segoe UI", 8.125F, FontStyle.Regular, GraphicsUnit.Point);
            deleteIncidentButton.ForeColor = Color.White;
            deleteIncidentButton.Location = new Point(490, 68);
            deleteIncidentButton.Margin = new Padding(2, 2, 2, 2);
            deleteIncidentButton.Name = "deleteIncidentButton";
            deleteIncidentButton.Size = new Size(128, 34);
            deleteIncidentButton.TabIndex = 22;
            deleteIncidentButton.Text = "REMOVE INCIDENT";
            deleteIncidentButton.UseVisualStyleBackColor = false;
            deleteIncidentButton.Click += DeleteIncidentButton_Click;
            // 
            // updateIncidentButton
            // 
            updateIncidentButton.BackColor = Color.DarkGreen;
            updateIncidentButton.FlatAppearance.BorderColor = Color.Black;
            updateIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            updateIncidentButton.Font = new Font("Segoe UI", 8.125F, FontStyle.Regular, GraphicsUnit.Point);
            updateIncidentButton.ForeColor = Color.White;
            updateIncidentButton.Location = new Point(623, 68);
            updateIncidentButton.Margin = new Padding(2, 2, 2, 2);
            updateIncidentButton.Name = "updateIncidentButton";
            updateIncidentButton.Size = new Size(128, 34);
            updateIncidentButton.TabIndex = 21;
            updateIncidentButton.Text = "UPDATE/VIEW INCIDENT";
            updateIncidentButton.UseVisualStyleBackColor = false;
            updateIncidentButton.Click += updateIncidentButton_Click;
            // 
            // checkBoxPriorityFilter
            // 
            checkBoxPriorityFilter.AutoSize = true;
            checkBoxPriorityFilter.Location = new Point(756, 40);
            checkBoxPriorityFilter.Margin = new Padding(2, 2, 2, 2);
            checkBoxPriorityFilter.Name = "checkBoxPriorityFilter";
            checkBoxPriorityFilter.Size = new Size(129, 19);
            checkBoxPriorityFilter.TabIndex = 21;
            checkBoxPriorityFilter.Text = "Priority (high - low)";
            checkBoxPriorityFilter.UseVisualStyleBackColor = true;
            checkBoxPriorityFilter.CheckedChanged += checkBoxPriorityFilter_CheckedChanged;
            // 
            // listViewTicketOverview
            // 
            listViewTicketOverview.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader1, columnHeader6, columnHeader2, columnHeader3, columnHeader4 });
            listViewTicketOverview.FullRowSelect = true;
            listViewTicketOverview.GridLines = true;
            listViewTicketOverview.Location = new Point(37, 110);
            listViewTicketOverview.Margin = new Padding(2, 2, 2, 2);
            listViewTicketOverview.Name = "listViewTicketOverview";
            listViewTicketOverview.Size = new Size(851, 407);
            listViewTicketOverview.TabIndex = 20;
            listViewTicketOverview.UseCompatibleStateImageBehavior = false;
            listViewTicketOverview.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            columnHeader1.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Title";
            columnHeader6.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Username";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Created";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Priority";
            columnHeader4.Width = 120;
            // 
            // filterTextBoxInput
            // 
            filterTextBoxInput.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            filterTextBoxInput.ForeColor = Color.Silver;
            filterTextBoxInput.Location = new Point(37, 68);
            filterTextBoxInput.Margin = new Padding(2, 2, 2, 2);
            filterTextBoxInput.Multiline = true;
            filterTextBoxInput.Name = "filterTextBoxInput";
            filterTextBoxInput.Size = new Size(254, 36);
            filterTextBoxInput.TabIndex = 19;
            filterTextBoxInput.Text = "Filter by email or username";
            filterTextBoxInput.TextChanged += filterTextBoxInput_TextChanged;
            filterTextBoxInput.Enter += filterTextBoxInput_Enter;
            filterTextBoxInput.KeyDown += filterTextBoxInput_KeyDown;
            // 
            // createIncidentButton
            // 
            createIncidentButton.BackColor = Color.DeepSkyBlue;
            createIncidentButton.FlatAppearance.BorderColor = Color.Black;
            createIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            createIncidentButton.Font = new Font("Segoe UI", 8.125F, FontStyle.Regular, GraphicsUnit.Point);
            createIncidentButton.ForeColor = Color.White;
            createIncidentButton.Location = new Point(756, 68);
            createIncidentButton.Margin = new Padding(2, 2, 2, 2);
            createIncidentButton.Name = "createIncidentButton";
            createIncidentButton.Size = new Size(131, 34);
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
            overviewTicketLabel.Location = new Point(9, 6);
            overviewTicketLabel.Margin = new Padding(2, 0, 2, 0);
            overviewTicketLabel.Name = "overviewTicketLabel";
            overviewTicketLabel.Size = new Size(236, 37);
            overviewTicketLabel.TabIndex = 8;
            overviewTicketLabel.Text = "Overview Tickets";
            // 
            // userManagementPanel
            // 
            userManagementPanel.BackColor = Color.White;
            userManagementPanel.Controls.Add(editUserButton);
            userManagementPanel.Controls.Add(addUserButton);
            userManagementPanel.Controls.Add(userSearchBox);
            userManagementPanel.Controls.Add(userOverviewLV);
            userManagementPanel.Location = new Point(8, 101);
            userManagementPanel.Margin = new Padding(2, 2, 2, 2);
            userManagementPanel.Name = "userManagementPanel";
            userManagementPanel.Size = new Size(922, 535);
            userManagementPanel.TabIndex = 23;
            // 
            // editUserButton
            // 
            editUserButton.BackColor = Color.DarkGreen;
            editUserButton.ForeColor = Color.White;
            editUserButton.Location = new Point(570, 22);
            editUserButton.Margin = new Padding(2, 2, 2, 2);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(105, 26);
            editUserButton.TabIndex = 3;
            editUserButton.Text = "View User";
            editUserButton.UseVisualStyleBackColor = false;
            editUserButton.Click += editUserButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.DeepSkyBlue;
            addUserButton.ForeColor = Color.White;
            addUserButton.Location = new Point(679, 22);
            addUserButton.Margin = new Padding(2, 2, 2, 2);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(105, 26);
            addUserButton.TabIndex = 2;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // userSearchBox
            // 
            userSearchBox.Location = new Point(124, 25);
            userSearchBox.Margin = new Padding(2, 2, 2, 2);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(184, 23);
            userSearchBox.TabIndex = 1;
            userSearchBox.Enter += userSearchBox_Enter;
            userSearchBox.KeyDown += userSearchBox_KeyDown;
            userSearchBox.Leave += userSearchBox_Leave;
            // 
            // userOverviewLV
            // 
            userOverviewLV.Columns.AddRange(new ColumnHeader[] { number, email, firstName, lastName, numberOfTickets });
            userOverviewLV.FullRowSelect = true;
            userOverviewLV.Location = new Point(124, 71);
            userOverviewLV.Margin = new Padding(2, 2, 2, 2);
            userOverviewLV.Name = "userOverviewLV";
            userOverviewLV.Size = new Size(661, 446);
            userOverviewLV.TabIndex = 0;
            userOverviewLV.UseCompatibleStateImageBehavior = false;
            userOverviewLV.View = View.Details;
            // 
            // number
            // 
            number.Tag = "#";
            number.Text = "#";
            number.Width = 50;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 190;
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
            addUserPanel.Controls.Add(modifyUserLabel);
            addUserPanel.Controls.Add(deleteUserButton);
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
            addUserPanel.Location = new Point(6, 100);
            addUserPanel.Margin = new Padding(2, 2, 2, 2);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(922, 535);
            addUserPanel.TabIndex = 25;
            // 
            // modifyUserLabel
            // 
            modifyUserLabel.AutoSize = true;
            modifyUserLabel.Location = new Point(734, 127);
            modifyUserLabel.Name = "modifyUserLabel";
            modifyUserLabel.Size = new Size(0, 15);
            modifyUserLabel.TabIndex = 34;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.DarkRed;
            deleteUserButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            deleteUserButton.ForeColor = Color.White;
            deleteUserButton.Location = new Point(211, 426);
            deleteUserButton.Margin = new Padding(2, 2, 2, 2);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(110, 34);
            deleteUserButton.TabIndex = 32;
            deleteUserButton.Text = "DELETE USER";
            deleteUserButton.UseVisualStyleBackColor = false;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // serviceDeskLabel
            // 
            serviceDeskLabel.AutoSize = true;
            serviceDeskLabel.Location = new Point(37, 380);
            serviceDeskLabel.Margin = new Padding(2, 0, 2, 0);
            serviceDeskLabel.Name = "serviceDeskLabel";
            serviceDeskLabel.Size = new Size(127, 15);
            serviceDeskLabel.TabIndex = 31;
            serviceDeskLabel.Text = "Service Desk Employee";
            // 
            // isServiceDeskCheckBox
            // 
            isServiceDeskCheckBox.AutoSize = true;
            isServiceDeskCheckBox.Location = new Point(212, 385);
            isServiceDeskCheckBox.Margin = new Padding(2, 2, 2, 2);
            isServiceDeskCheckBox.Name = "isServiceDeskCheckBox";
            isServiceDeskCheckBox.Size = new Size(15, 14);
            isServiceDeskCheckBox.TabIndex = 30;
            isServiceDeskCheckBox.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(37, 340);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
            locationLabel.TabIndex = 29;
            locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(210, 338);
            locationTextBox.Margin = new Padding(2, 2, 2, 2);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(271, 23);
            locationTextBox.TabIndex = 28;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(210, 290);
            phoneNumberTextBox.Margin = new Padding(2, 2, 2, 2);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(271, 23);
            phoneNumberTextBox.TabIndex = 27;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(210, 241);
            emailTextBox.Margin = new Padding(2, 2, 2, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(271, 23);
            emailTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(210, 200);
            passwordTextBox.Margin = new Padding(2, 2, 2, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(271, 23);
            passwordTextBox.TabIndex = 25;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(210, 155);
            usernameTextBox.Margin = new Padding(2, 2, 2, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(271, 23);
            usernameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(211, 114);
            lastNameTextBox.Margin = new Padding(2, 2, 2, 2);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(271, 23);
            lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(211, 71);
            firstNameTextBox.Margin = new Padding(2, 2, 2, 2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(271, 23);
            firstNameTextBox.TabIndex = 18;
            // 
            // createUserCreateButton
            // 
            createUserCreateButton.BackColor = Color.DeepSkyBlue;
            createUserCreateButton.FlatAppearance.BorderColor = Color.Black;
            createUserCreateButton.FlatAppearance.MouseDownBackColor = Color.White;
            createUserCreateButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCreateButton.ForeColor = Color.White;
            createUserCreateButton.Location = new Point(350, 475);
            createUserCreateButton.Margin = new Padding(2, 2, 2, 2);
            createUserCreateButton.Name = "createUserCreateButton";
            createUserCreateButton.Size = new Size(131, 34);
            createUserCreateButton.TabIndex = 17;
            createUserCreateButton.Text = "CREATE USER";
            createUserCreateButton.UseVisualStyleBackColor = false;
            createUserCreateButton.Click += createUserCreateButton_Click;
            // 
            // createUserCancelButton
            // 
            createUserCancelButton.BackColor = Color.White;
            createUserCancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCancelButton.Location = new Point(211, 475);
            createUserCancelButton.Margin = new Padding(2, 2, 2, 2);
            createUserCancelButton.Name = "createUserCancelButton";
            createUserCancelButton.Size = new Size(110, 34);
            createUserCancelButton.TabIndex = 16;
            createUserCancelButton.Text = "CANCEL";
            createUserCancelButton.UseVisualStyleBackColor = false;
            createUserCancelButton.Click += createUserCancelButton_Click;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(40, 288);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(40, 239);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(37, 196);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(37, 155);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username";
            // 
            // lastNamelabel
            // 
            lastNamelabel.AutoSize = true;
            lastNamelabel.Location = new Point(37, 111);
            lastNamelabel.Margin = new Padding(2, 0, 2, 0);
            lastNamelabel.Name = "lastNamelabel";
            lastNamelabel.Size = new Size(63, 15);
            lastNamelabel.TabIndex = 10;
            lastNamelabel.Text = "Last Name";
            // 
            // addUserNameLabel
            // 
            addUserNameLabel.AutoSize = true;
            addUserNameLabel.Location = new Point(37, 71);
            addUserNameLabel.Margin = new Padding(2, 0, 2, 0);
            addUserNameLabel.Name = "addUserNameLabel";
            addUserNameLabel.Size = new Size(64, 15);
            addUserNameLabel.TabIndex = 9;
            addUserNameLabel.Text = "First Name";
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.BackColor = Color.Transparent;
            addUserLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            addUserLabel.Location = new Point(9, 6);
            addUserLabel.Margin = new Padding(2, 0, 2, 0);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(191, 37);
            addUserLabel.TabIndex = 7;
            addUserLabel.Text = "Add new user";
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(ShowListButton);
            panelDashboard.Controls.Add(CurrentIncidentsLabel);
            panelDashboard.Controls.Add(ClosedTicketsChart);
            panelDashboard.Controls.Add(OpenTicketsChart);
            panelDashboard.Location = new Point(5, 99);
            panelDashboard.Margin = new Padding(2, 2, 2, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(922, 535);
            panelDashboard.TabIndex = 26;
            // 
            // ShowListButton
            // 
            ShowListButton.BackColor = Color.DeepSkyBlue;
            ShowListButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowListButton.ForeColor = Color.White;
            ShowListButton.Location = new Point(719, 20);
            ShowListButton.Margin = new Padding(2, 2, 2, 2);
            ShowListButton.Name = "ShowListButton";
            ShowListButton.Size = new Size(133, 56);
            ShowListButton.TabIndex = 4;
            ShowListButton.Text = "Show List";
            ShowListButton.UseVisualStyleBackColor = false;
            ShowListButton.Click += ShowListButton_Click;
            // 
            // CurrentIncidentsLabel
            // 
            CurrentIncidentsLabel.AutoSize = true;
            CurrentIncidentsLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentIncidentsLabel.Location = new Point(72, 27);
            CurrentIncidentsLabel.Margin = new Padding(2, 0, 2, 0);
            CurrentIncidentsLabel.Name = "CurrentIncidentsLabel";
            CurrentIncidentsLabel.Size = new Size(237, 37);
            CurrentIncidentsLabel.TabIndex = 3;
            CurrentIncidentsLabel.Text = "Current incidents";
            // 
            // ClosedTicketsChart
            // 
            chartArea1.Name = "ChartArea1";
            ClosedTicketsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ClosedTicketsChart.Legends.Add(legend1);
            ClosedTicketsChart.Location = new Point(519, 158);
            ClosedTicketsChart.Margin = new Padding(2, 2, 2, 2);
            ClosedTicketsChart.Name = "ClosedTicketsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            ClosedTicketsChart.Series.Add(series1);
            ClosedTicketsChart.Size = new Size(371, 339);
            ClosedTicketsChart.TabIndex = 1;
            ClosedTicketsChart.Text = "chart2";
            // 
            // OpenTicketsChart
            // 
            chartArea2.Name = "ChartArea1";
            OpenTicketsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            OpenTicketsChart.Legends.Add(legend2);
            OpenTicketsChart.Location = new Point(65, 158);
            OpenTicketsChart.Margin = new Padding(2, 2, 2, 2);
            OpenTicketsChart.Name = "OpenTicketsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            OpenTicketsChart.Series.Add(series2);
            OpenTicketsChart.Size = new Size(371, 339);
            OpenTicketsChart.TabIndex = 0;
            OpenTicketsChart.Text = "chart1";
            // 
            // modifyIncidentPanel
            // 
            modifyIncidentPanel.BackColor = Color.White;
            modifyIncidentPanel.Controls.Add(statusComboBox);
            modifyIncidentPanel.Controls.Add(statusLabel);
            modifyIncidentPanel.Controls.Add(labelTicket);
            modifyIncidentPanel.Controls.Add(deadlineInputModify);
            modifyIncidentPanel.Controls.Add(priorityInputModify);
            modifyIncidentPanel.Controls.Add(reportedbyInputModify);
            modifyIncidentPanel.Controls.Add(typeinputModify);
            modifyIncidentPanel.Controls.Add(subjectInputModify);
            modifyIncidentPanel.Controls.Add(modifyTicketButton);
            modifyIncidentPanel.Controls.Add(cancelModifyButton);
            modifyIncidentPanel.Controls.Add(descriptionModifyInput);
            modifyIncidentPanel.Controls.Add(labelDescription);
            modifyIncidentPanel.Controls.Add(labelDeadline);
            modifyIncidentPanel.Controls.Add(labelPriority);
            modifyIncidentPanel.Controls.Add(labelReportedBy);
            modifyIncidentPanel.Controls.Add(labelTypeOfIncident);
            modifyIncidentPanel.Controls.Add(labelSubject);
            modifyIncidentPanel.Controls.Add(labelModify);
            modifyIncidentPanel.Location = new Point(8, 101);
            modifyIncidentPanel.Margin = new Padding(2, 2, 2, 2);
            modifyIncidentPanel.Name = "modifyIncidentPanel";
            modifyIncidentPanel.Size = new Size(918, 471);
            modifyIncidentPanel.TabIndex = 23;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(184, 213);
            statusComboBox.Margin = new Padding(2, 2, 2, 2);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(237, 23);
            statusComboBox.TabIndex = 25;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(33, 213);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 24;
            statusLabel.Text = "Status";
            // 
            // labelTicket
            // 
            labelTicket.AutoSize = true;
            labelTicket.Location = new Point(624, 148);
            labelTicket.Margin = new Padding(2, 0, 2, 0);
            labelTicket.Name = "labelTicket";
            labelTicket.Size = new Size(0, 15);
            labelTicket.TabIndex = 23;
            // 
            // deadlineInputModify
            // 
            deadlineInputModify.DropDownStyle = ComboBoxStyle.DropDownList;
            deadlineInputModify.FormattingEnabled = true;
            deadlineInputModify.Location = new Point(184, 178);
            deadlineInputModify.Margin = new Padding(2, 2, 2, 2);
            deadlineInputModify.Name = "deadlineInputModify";
            deadlineInputModify.Size = new Size(237, 23);
            deadlineInputModify.TabIndex = 22;
            // 
            // priorityInputModify
            // 
            priorityInputModify.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityInputModify.FormattingEnabled = true;
            priorityInputModify.Location = new Point(184, 147);
            priorityInputModify.Margin = new Padding(2, 2, 2, 2);
            priorityInputModify.Name = "priorityInputModify";
            priorityInputModify.Size = new Size(237, 23);
            priorityInputModify.TabIndex = 21;
            // 
            // reportedbyInputModify
            // 
            reportedbyInputModify.DropDownStyle = ComboBoxStyle.DropDownList;
            reportedbyInputModify.FormattingEnabled = true;
            reportedbyInputModify.Location = new Point(184, 116);
            reportedbyInputModify.Margin = new Padding(2, 2, 2, 2);
            reportedbyInputModify.Name = "reportedbyInputModify";
            reportedbyInputModify.Size = new Size(237, 23);
            reportedbyInputModify.TabIndex = 20;
            // 
            // typeinputModify
            // 
            typeinputModify.DropDownStyle = ComboBoxStyle.DropDownList;
            typeinputModify.FormattingEnabled = true;
            typeinputModify.Location = new Point(184, 83);
            typeinputModify.Margin = new Padding(2, 2, 2, 2);
            typeinputModify.Name = "typeinputModify";
            typeinputModify.Size = new Size(237, 23);
            typeinputModify.TabIndex = 19;
            // 
            // subjectInputModify
            // 
            subjectInputModify.Location = new Point(184, 53);
            subjectInputModify.Margin = new Padding(2, 2, 2, 2);
            subjectInputModify.Name = "subjectInputModify";
            subjectInputModify.Size = new Size(237, 23);
            subjectInputModify.TabIndex = 18;
            // 
            // modifyTicketButton
            // 
            modifyTicketButton.BackColor = Color.DeepSkyBlue;
            modifyTicketButton.FlatAppearance.BorderColor = Color.Black;
            modifyTicketButton.FlatAppearance.MouseDownBackColor = Color.White;
            modifyTicketButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            modifyTicketButton.ForeColor = Color.White;
            modifyTicketButton.Location = new Point(306, 367);
            modifyTicketButton.Margin = new Padding(2, 2, 2, 2);
            modifyTicketButton.Name = "modifyTicketButton";
            modifyTicketButton.Size = new Size(114, 26);
            modifyTicketButton.TabIndex = 17;
            modifyTicketButton.Text = "MODIFY TICKET";
            modifyTicketButton.UseVisualStyleBackColor = false;
            modifyTicketButton.Click += modifyTicketButton_Click;
            // 
            // cancelModifyButton
            // 
            cancelModifyButton.BackColor = Color.White;
            cancelModifyButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cancelModifyButton.Location = new Point(184, 367);
            cancelModifyButton.Margin = new Padding(2, 2, 2, 2);
            cancelModifyButton.Name = "cancelModifyButton";
            cancelModifyButton.Size = new Size(96, 26);
            cancelModifyButton.TabIndex = 16;
            cancelModifyButton.Text = "CANCEL";
            cancelModifyButton.UseVisualStyleBackColor = false;
            cancelModifyButton.Click += cancelModifyButton_Click;
            // 
            // descriptionModifyInput
            // 
            descriptionModifyInput.Location = new Point(184, 256);
            descriptionModifyInput.Margin = new Padding(2, 2, 2, 2);
            descriptionModifyInput.MinimumSize = new Size(4, 73);
            descriptionModifyInput.Multiline = true;
            descriptionModifyInput.Name = "descriptionModifyInput";
            descriptionModifyInput.Size = new Size(237, 92);
            descriptionModifyInput.TabIndex = 15;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(34, 256);
            labelDescription.Margin = new Padding(2, 0, 2, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 14;
            labelDescription.Text = "Description:";
            // 
            // labelDeadline
            // 
            labelDeadline.AutoSize = true;
            labelDeadline.Location = new Point(33, 178);
            labelDeadline.Margin = new Padding(2, 0, 2, 0);
            labelDeadline.Name = "labelDeadline";
            labelDeadline.Size = new Size(111, 15);
            labelDeadline.TabIndex = 13;
            labelDeadline.Text = "Deadline/follow up:";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Location = new Point(33, 147);
            labelPriority.Margin = new Padding(2, 0, 2, 0);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(48, 15);
            labelPriority.TabIndex = 12;
            labelPriority.Text = "Priority:";
            // 
            // labelReportedBy
            // 
            labelReportedBy.AutoSize = true;
            labelReportedBy.Location = new Point(33, 116);
            labelReportedBy.Margin = new Padding(2, 0, 2, 0);
            labelReportedBy.Name = "labelReportedBy";
            labelReportedBy.Size = new Size(99, 15);
            labelReportedBy.TabIndex = 11;
            labelReportedBy.Text = "Reported by user:";
            // 
            // labelTypeOfIncident
            // 
            labelTypeOfIncident.AutoSize = true;
            labelTypeOfIncident.Location = new Point(33, 83);
            labelTypeOfIncident.Margin = new Padding(2, 0, 2, 0);
            labelTypeOfIncident.Name = "labelTypeOfIncident";
            labelTypeOfIncident.Size = new Size(94, 15);
            labelTypeOfIncident.TabIndex = 10;
            labelTypeOfIncident.Text = "Type of incident:";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(33, 53);
            labelSubject.Margin = new Padding(2, 0, 2, 0);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(106, 15);
            labelSubject.TabIndex = 9;
            labelSubject.Text = "Subject of incident";
            // 
            // labelModify
            // 
            labelModify.AutoSize = true;
            labelModify.BackColor = Color.Transparent;
            labelModify.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            labelModify.Location = new Point(8, 4);
            labelModify.Margin = new Padding(2, 0, 2, 0);
            labelModify.Name = "labelModify";
            labelModify.Size = new Size(302, 37);
            labelModify.TabIndex = 7;
            labelModify.Text = "Modify incident ticket";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 638);
            Controls.Add(panelDashboard);
            Controls.Add(ticketOverviewPanel);
            Controls.Add(userManagementPanel);
            Controls.Add(addUserPanel);
            Controls.Add(modifyIncidentPanel);
            Controls.Add(addIncidentPanel);
            Controls.Add(DashboardPanel);
            Margin = new Padding(5, 4, 5, 4);
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
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClosedTicketsChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenTicketsChart).EndInit();
            modifyIncidentPanel.ResumeLayout(false);
            modifyIncidentPanel.PerformLayout();
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button updateIncidentButton;
        private Panel panelDashboard;
        private Label CurrentIncidentsLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ClosedTicketsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OpenTicketsChart;
        private Button ShowListButton;
        private ColumnHeader columnHeader5;
        private Panel modifyIncidentPanel;
        private ComboBox deadlineInputModify;
        private ComboBox priorityInputModify;
        private ComboBox reportedbyInputModify;
        private ComboBox typeinputModify;
        private TextBox subjectInputModify;
        private Button modifyTicketButton;
        private Button cancelModifyButton;
        private TextBox descriptionModifyInput;
        private Label labelDescription;
        private Label labelDeadline;
        private Label labelPriority;
        private Label labelReportedBy;
        private Label labelTypeOfIncident;
        private Label labelSubject;
        private Label labelModify;
        private Label labelTicket;
        private Button deleteIncidentButton;
        private ColumnHeader id;
        private ColumnHeader EmailAddress;
        private ColumnHeader Username;
        private ColumnHeader date;
        private ColumnHeader priority;
        private CheckBox checkBoxPriorityFilter;
        private ComboBox statusComboBox;
        private Label statusLabel;
        private Button editUserButton;
        private Button deleteUserButton;
        private Label modifyUserLabel;
        private ColumnHeader columnHeader6;
    }
}

