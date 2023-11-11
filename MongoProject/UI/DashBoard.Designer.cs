
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
<<<<<<< HEAD
            updateIncidentButton = new Button();
=======
            checkBoxPriorityFilter = new CheckBox();
>>>>>>> Louise
            listViewTicketOverview = new ListView();

            columnHeader5 = new ColumnHeader();

            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
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

            panelDashboard = new Panel();
            CurrentIncidentsLabel = new Label();
            ClosedTicketsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            OpenTicketsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ShowListButton = new Button();

            modifyIncidentPanel = new Panel();
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
            deleteIncidentButton = new Button();

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
            gardenGroupLogo.Margin = new Padding(2, 3, 2, 3);
            gardenGroupLogo.Name = "gardenGroupLogo";
            gardenGroupLogo.Size = new Size(251, 85);
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
            DashboardPanel.Location = new Point(9, 7);
            DashboardPanel.Margin = new Padding(2, 3, 2, 3);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(1055, 125);
            DashboardPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(954, 85);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(101, 35);
            LogoutButton.TabIndex = 7;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // userManagementButton
            // 
            userManagementButton.BackColor = Color.White;
            userManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            userManagementButton.Location = new Point(639, 85);
            userManagementButton.Margin = new Padding(2, 3, 2, 3);
            userManagementButton.Name = "userManagementButton";
            userManagementButton.Size = new Size(315, 35);
            userManagementButton.TabIndex = 6;
            userManagementButton.Text = "User Management";
            userManagementButton.UseVisualStyleBackColor = false;
            userManagementButton.Click += userManagementButton_Click;
            // 
            // incidentManagementButton
            // 
            incidentManagementButton.BackColor = Color.White;
            incidentManagementButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            incidentManagementButton.Location = new Point(319, 85);
            incidentManagementButton.Margin = new Padding(2, 3, 2, 3);
            incidentManagementButton.Name = "incidentManagementButton";
            incidentManagementButton.Size = new Size(315, 35);
            incidentManagementButton.TabIndex = 5;
            incidentManagementButton.Text = "Incident Management";
            incidentManagementButton.UseVisualStyleBackColor = false;
            incidentManagementButton.Click += incidentManagementButton_Click;
            // 
            // DashBoardButton
            // 
            DashBoardButton.BackColor = Color.White;
            DashBoardButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            DashBoardButton.Location = new Point(-1, 85);
            DashBoardButton.Margin = new Padding(2, 3, 2, 3);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(315, 35);
            DashBoardButton.TabIndex = 4;
            DashBoardButton.Text = "Dashboard";
            DashBoardButton.UseVisualStyleBackColor = false;
            DashBoardButton.Click += DashBoardButton_Click;
            // 
            // licensedToLabel
            // 
            licensedToLabel.AutoSize = true;
            licensedToLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            licensedToLabel.Location = new Point(702, 45);
            licensedToLabel.Margin = new Padding(2, 0, 2, 0);
            licensedToLabel.Name = "licensedToLabel";
            licensedToLabel.Size = new Size(367, 32);
            licensedToLabel.TabIndex = 3;
            licensedToLabel.Text = "Licensed to: The Garden Group";
            // 
            // noDeskLabel
            // 
            noDeskLabel.AutoSize = true;
            noDeskLabel.BackColor = Color.Transparent;
            noDeskLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            noDeskLabel.Location = new Point(907, 0);
            noDeskLabel.Margin = new Padding(2, 0, 2, 0);
            noDeskLabel.Name = "noDeskLabel";
            noDeskLabel.Size = new Size(145, 46);
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
            addIncidentPanel.Location = new Point(9, 135);
            addIncidentPanel.Margin = new Padding(2, 3, 2, 3);
            addIncidentPanel.Name = "addIncidentPanel";
            addIncidentPanel.Size = new Size(1054, 713);
            addIncidentPanel.TabIndex = 2;
            // 
            // deadlineFollowUpInput
            // 
            deadlineFollowUpInput.FormattingEnabled = true;
            deadlineFollowUpInput.Location = new Point(241, 317);
            deadlineFollowUpInput.Margin = new Padding(2, 3, 2, 3);
            deadlineFollowUpInput.Name = "deadlineFollowUpInput";
            deadlineFollowUpInput.Size = new Size(309, 28);
            deadlineFollowUpInput.TabIndex = 22;
            // 
            // priorityInput
            // 
            priorityInput.FormattingEnabled = true;
            priorityInput.Location = new Point(241, 261);
            priorityInput.Margin = new Padding(2, 3, 2, 3);
            priorityInput.Name = "priorityInput";
            priorityInput.Size = new Size(309, 28);
            priorityInput.TabIndex = 21;
            // 
            // userReportedInput
            // 
            userReportedInput.FormattingEnabled = true;
            userReportedInput.Location = new Point(241, 207);
            userReportedInput.Margin = new Padding(2, 3, 2, 3);
            userReportedInput.Name = "userReportedInput";
            userReportedInput.Size = new Size(309, 28);
            userReportedInput.TabIndex = 20;
            userReportedInput.Text = " Select user";
            // 
            // incidentTypeInput
            // 
            incidentTypeInput.FormattingEnabled = true;
            incidentTypeInput.Location = new Point(241, 148);
            incidentTypeInput.Margin = new Padding(2, 3, 2, 3);
            incidentTypeInput.Name = "incidentTypeInput";
            incidentTypeInput.Size = new Size(309, 28);
            incidentTypeInput.TabIndex = 19;
            incidentTypeInput.Text = " Select type";
            // 
            // subjectInput
            // 
            subjectInput.Location = new Point(241, 95);
            subjectInput.Margin = new Padding(2, 3, 2, 3);
            subjectInput.Name = "subjectInput";
            subjectInput.Size = new Size(309, 27);
            subjectInput.TabIndex = 18;
            // 
            // submitTicketButton
            // 
            submitTicketButton.BackColor = Color.DeepSkyBlue;
            submitTicketButton.FlatAppearance.BorderColor = Color.Black;
            submitTicketButton.FlatAppearance.MouseDownBackColor = Color.White;
            submitTicketButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            submitTicketButton.ForeColor = Color.White;
            submitTicketButton.Location = new Point(400, 581);
            submitTicketButton.Margin = new Padding(2, 3, 2, 3);
            submitTicketButton.Name = "submitTicketButton";
            submitTicketButton.Size = new Size(149, 45);
            submitTicketButton.TabIndex = 17;
            submitTicketButton.Text = "SUBMIT TICKET";
            submitTicketButton.UseVisualStyleBackColor = false;
            submitTicketButton.Click += submitTicketButton_Click_1;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(241, 581);
            cancelButton.Margin = new Padding(2, 3, 2, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(125, 45);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(241, 384);
            descriptionInput.Margin = new Padding(2, 3, 2, 3);
            descriptionInput.MinimumSize = new Size(4, 127);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(309, 161);
            descriptionInput.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(45, 384);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // deadlineFollowUpLabel
            // 
            deadlineFollowUpLabel.AutoSize = true;
            deadlineFollowUpLabel.Location = new Point(42, 317);
            deadlineFollowUpLabel.Margin = new Padding(2, 0, 2, 0);
            deadlineFollowUpLabel.Name = "deadlineFollowUpLabel";
            deadlineFollowUpLabel.Size = new Size(141, 20);
            deadlineFollowUpLabel.TabIndex = 13;
            deadlineFollowUpLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(43, 261);
            priorityLabel.Margin = new Padding(2, 0, 2, 0);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(59, 20);
            priorityLabel.TabIndex = 12;
            priorityLabel.Text = "Priority:";
            // 
            // userReportedLabel
            // 
            userReportedLabel.AutoSize = true;
            userReportedLabel.Location = new Point(43, 207);
            userReportedLabel.Margin = new Padding(2, 0, 2, 0);
            userReportedLabel.Name = "userReportedLabel";
            userReportedLabel.Size = new Size(125, 20);
            userReportedLabel.TabIndex = 11;
            userReportedLabel.Text = "Reported by user:";
            // 
            // incidentTypeLabel
            // 
            incidentTypeLabel.AutoSize = true;
            incidentTypeLabel.Location = new Point(43, 148);
            incidentTypeLabel.Margin = new Padding(2, 0, 2, 0);
            incidentTypeLabel.Name = "incidentTypeLabel";
            incidentTypeLabel.Size = new Size(118, 20);
            incidentTypeLabel.TabIndex = 10;
            incidentTypeLabel.Text = "Type of incident:";
            // 
            // subjectIncidentLabel
            // 
            subjectIncidentLabel.AutoSize = true;
            subjectIncidentLabel.Location = new Point(43, 95);
            subjectIncidentLabel.Margin = new Padding(2, 0, 2, 0);
            subjectIncidentLabel.Name = "subjectIncidentLabel";
            subjectIncidentLabel.Size = new Size(133, 20);
            subjectIncidentLabel.TabIndex = 9;
            subjectIncidentLabel.Text = "Subject of incident";
            // 
            // newIncidentLabel
            // 
            newIncidentLabel.AutoSize = true;
            newIncidentLabel.BackColor = Color.Transparent;
            newIncidentLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            newIncidentLabel.Location = new Point(10, 8);
            newIncidentLabel.Margin = new Padding(2, 0, 2, 0);
            newIncidentLabel.Name = "newIncidentLabel";
            newIncidentLabel.Size = new Size(434, 46);
            newIncidentLabel.TabIndex = 7;
            newIncidentLabel.Text = "Create new incident ticket";
            // 
            // ticketOverviewPanel
            // 
            ticketOverviewPanel.BackColor = Color.White;
<<<<<<< HEAD

            ticketOverviewPanel.Controls.Add(deleteIncidentButton);

            ticketOverviewPanel.Controls.Add(updateIncidentButton);
=======
            ticketOverviewPanel.Controls.Add(checkBoxPriorityFilter);
>>>>>>> Louise
            ticketOverviewPanel.Controls.Add(listViewTicketOverview);
            ticketOverviewPanel.Controls.Add(filterTextBoxInput);
            ticketOverviewPanel.Controls.Add(createIncidentButton);
            ticketOverviewPanel.Controls.Add(overviewTicketLabel);
            ticketOverviewPanel.Location = new Point(9, 135);
            ticketOverviewPanel.Margin = new Padding(2, 3, 2, 3);
            ticketOverviewPanel.Name = "ticketOverviewPanel";
            ticketOverviewPanel.Size = new Size(1054, 713);
            ticketOverviewPanel.TabIndex = 24;
            // 
<<<<<<< HEAD
            // updateIncidentButton
=======
            // checkBoxPriorityFilter
            // 
            checkBoxPriorityFilter.AutoSize = true;
            checkBoxPriorityFilter.Location = new Point(551, 182);
            checkBoxPriorityFilter.Name = "checkBoxPriorityFilter";
            checkBoxPriorityFilter.Size = new Size(251, 36);
            checkBoxPriorityFilter.TabIndex = 21;
            checkBoxPriorityFilter.Text = "Priority (high - low)";
            checkBoxPriorityFilter.UseVisualStyleBackColor = true;
            checkBoxPriorityFilter.CheckedChanged += checkBoxPriorityFilter_CheckedChanged;
            // 
            // listViewTicketOverview
>>>>>>> Louise
            // 
            updateIncidentButton.BackColor = Color.DarkGreen;
            updateIncidentButton.FlatAppearance.BorderColor = Color.Black;
            updateIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            updateIncidentButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            updateIncidentButton.ForeColor = Color.White;

            updateIncidentButton.Location = new Point(695, 91);
            updateIncidentButton.Margin = new Padding(2, 3, 2, 3);
            updateIncidentButton.Name = "updateIncidentButton";
            updateIncidentButton.Size = new Size(157, 45);

            updateIncidentButton.Location = new Point(615, 68);
            updateIncidentButton.Margin = new Padding(2);
            updateIncidentButton.Name = "updateIncidentButton";
            updateIncidentButton.Size = new Size(137, 34);

            updateIncidentButton.TabIndex = 21;
            updateIncidentButton.Text = "UPDATE INCIDENT";
            updateIncidentButton.UseVisualStyleBackColor = false;
            updateIncidentButton.Click += updateIncidentButton_Click;
            listViewTicketOverview.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });

            listViewTicketOverview.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });

            listViewTicketOverview.FullRowSelect = true;
            listViewTicketOverview.GridLines = true;
            listViewTicketOverview.Location = new Point(42, 147);
            listViewTicketOverview.Margin = new Padding(2, 3, 2, 3);
            listViewTicketOverview.Name = "listViewTicketOverview";
            listViewTicketOverview.Size = new Size(972, 541);
            listViewTicketOverview.TabIndex = 20;
            listViewTicketOverview.UseCompatibleStateImageBehavior = false;
            listViewTicketOverview.View = View.Details;
<<<<<<< HEAD
            listViewTicketOverview.SelectedIndexChanged += listViewTicketOverview_SelectedIndexChanged;
            columnHeader1.Text = "Email";
            columnHeader2.Text = "Username";

            columnHeader3.Text = "Created";

            columnHeader5.Text = "ID";

            columnHeader1.Text = "Email";

            columnHeader2.Text = "Username";

            columnHeader3.Text = "Created";

            columnHeader4.Text = "Priority";

=======
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // EmailAddress
            // 
            EmailAddress.Text = "Email address";
            EmailAddress.Width = 250;
            // 
            // Username
            // 
            Username.Text = "Username";
            Username.Width = 150;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 150;
            // 
            // priority
            // 
            priority.Text = "Priority";
            priority.Width = 70;
            // 
            // filterTextBoxInput
            // 
>>>>>>> Louise
            filterTextBoxInput.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            filterTextBoxInput.ForeColor = Color.Silver;
            filterTextBoxInput.Location = new Point(42, 91);
            filterTextBoxInput.Margin = new Padding(2, 3, 2, 3);
            filterTextBoxInput.Multiline = true;
            filterTextBoxInput.Name = "filterTextBoxInput";
            filterTextBoxInput.Size = new Size(289, 47);
            filterTextBoxInput.TabIndex = 19;
            filterTextBoxInput.Text = " Filter by email or username";
            filterTextBoxInput.TextChanged += filterTextBoxInput_TextChanged;
            // 
            // createIncidentButton
            // 
            createIncidentButton.BackColor = Color.DeepSkyBlue;
            createIncidentButton.FlatAppearance.BorderColor = Color.Black;
            createIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            createIncidentButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createIncidentButton.ForeColor = Color.White;
            createIncidentButton.Location = new Point(864, 91);
            createIncidentButton.Margin = new Padding(2, 3, 2, 3);
            createIncidentButton.Name = "createIncidentButton";
            createIncidentButton.Size = new Size(149, 45);
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
            overviewTicketLabel.Location = new Point(10, 8);
            overviewTicketLabel.Margin = new Padding(2, 0, 2, 0);
            overviewTicketLabel.Name = "overviewTicketLabel";
            overviewTicketLabel.Size = new Size(290, 46);
            overviewTicketLabel.TabIndex = 8;
            overviewTicketLabel.Text = "Overview Tickets";
            // 
            // userManagementPanel
            // 
            userManagementPanel.BackColor = Color.White;
            userManagementPanel.Controls.Add(addUserButton);
            userManagementPanel.Controls.Add(userSearchBox);
            userManagementPanel.Controls.Add(userOverviewLV);
            userManagementPanel.Location = new Point(9, 135);
            userManagementPanel.Margin = new Padding(2, 3, 2, 3);
            userManagementPanel.Name = "userManagementPanel";
            userManagementPanel.Size = new Size(1054, 713);
            userManagementPanel.TabIndex = 23;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(776, 29);
            addUserButton.Margin = new Padding(2, 3, 2, 3);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(120, 27);
            addUserButton.TabIndex = 2;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // userSearchBox
            // 
            userSearchBox.Location = new Point(142, 33);
            userSearchBox.Margin = new Padding(2, 3, 2, 3);
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(209, 27);
            userSearchBox.TabIndex = 1;
            userSearchBox.TextChanged += userSearchBox_TextChanged;
            userSearchBox.Enter += userSearchBox_Enter;
            userSearchBox.KeyDown += userSearchBox_KeyDown;
            userSearchBox.Leave += userSearchBox_Leave;
            // 
            // userOverviewLV
            // 
            userOverviewLV.Columns.AddRange(new ColumnHeader[] { number, email, firstName, lastName, numberOfTickets });
            userOverviewLV.FullRowSelect = true;
            userOverviewLV.Location = new Point(142, 95);
            userOverviewLV.Margin = new Padding(2, 3, 2, 3);
            userOverviewLV.Name = "userOverviewLV";
            userOverviewLV.Size = new Size(755, 593);
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
            addUserPanel.Location = new Point(7, 133);
            addUserPanel.Margin = new Padding(2, 3, 2, 3);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(1054, 713);
            addUserPanel.TabIndex = 25;
            // 
            // serviceDeskLabel
            // 
            serviceDeskLabel.AutoSize = true;
            serviceDeskLabel.Location = new Point(43, 507);
            serviceDeskLabel.Margin = new Padding(2, 0, 2, 0);
            serviceDeskLabel.Name = "serviceDeskLabel";
            serviceDeskLabel.Size = new Size(162, 20);
            serviceDeskLabel.TabIndex = 31;
            serviceDeskLabel.Text = "Service Desk Employee";
            // 
            // isServiceDeskCheckBox
            // 
            isServiceDeskCheckBox.AutoSize = true;
            isServiceDeskCheckBox.Location = new Point(243, 513);
            isServiceDeskCheckBox.Margin = new Padding(2, 3, 2, 3);
            isServiceDeskCheckBox.Name = "isServiceDeskCheckBox";
            isServiceDeskCheckBox.Size = new Size(18, 17);
            isServiceDeskCheckBox.TabIndex = 30;
            isServiceDeskCheckBox.UseVisualStyleBackColor = true;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(43, 453);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(66, 20);
            locationLabel.TabIndex = 29;
            locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(240, 451);
            locationTextBox.Margin = new Padding(2, 3, 2, 3);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(309, 27);
            locationTextBox.TabIndex = 28;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(240, 387);
            phoneNumberTextBox.Margin = new Padding(2, 3, 2, 3);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(309, 27);
            phoneNumberTextBox.TabIndex = 27;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(240, 321);
            emailTextBox.Margin = new Padding(2, 3, 2, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(309, 27);
            emailTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(240, 267);
            passwordTextBox.Margin = new Padding(2, 3, 2, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(309, 27);
            passwordTextBox.TabIndex = 25;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(240, 207);
            usernameTextBox.Margin = new Padding(2, 3, 2, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(309, 27);
            usernameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(241, 152);
            lastNameTextBox.Margin = new Padding(2, 3, 2, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(309, 27);
            lastNameTextBox.TabIndex = 23;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(241, 95);
            firstNameTextBox.Margin = new Padding(2, 3, 2, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(309, 27);
            firstNameTextBox.TabIndex = 18;
            // 
            // createUserCreateButton
            // 
            createUserCreateButton.BackColor = Color.DeepSkyBlue;
            createUserCreateButton.FlatAppearance.BorderColor = Color.Black;
            createUserCreateButton.FlatAppearance.MouseDownBackColor = Color.White;
            createUserCreateButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCreateButton.ForeColor = Color.White;
            createUserCreateButton.Location = new Point(400, 581);
            createUserCreateButton.Margin = new Padding(2, 3, 2, 3);
            createUserCreateButton.Name = "createUserCreateButton";
            createUserCreateButton.Size = new Size(149, 45);
            createUserCreateButton.TabIndex = 17;
            createUserCreateButton.Text = "CREATE USER";
            createUserCreateButton.UseVisualStyleBackColor = false;
            createUserCreateButton.Click += createUserCreateButton_Click;
            // 
            // createUserCancelButton
            // 
            createUserCancelButton.BackColor = Color.White;
            createUserCancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createUserCancelButton.Location = new Point(241, 581);
            createUserCancelButton.Margin = new Padding(2, 3, 2, 3);
            createUserCancelButton.Name = "createUserCancelButton";
            createUserCancelButton.Size = new Size(125, 45);
            createUserCancelButton.TabIndex = 16;
            createUserCancelButton.Text = "CANCEL";
            createUserCancelButton.UseVisualStyleBackColor = false;
            createUserCancelButton.Click += createUserCancelButton_Click;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(45, 384);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(46, 319);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(43, 261);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(43, 207);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username";
            // 
            // lastNamelabel
            // 
            lastNamelabel.AutoSize = true;
            lastNamelabel.Location = new Point(43, 148);
            lastNamelabel.Margin = new Padding(2, 0, 2, 0);
            lastNamelabel.Name = "lastNamelabel";
            lastNamelabel.Size = new Size(79, 20);
            lastNamelabel.TabIndex = 10;
            lastNamelabel.Text = "Last Name";
            // 
            // addUserNameLabel
            // 
            addUserNameLabel.AutoSize = true;
            addUserNameLabel.Location = new Point(43, 95);
            addUserNameLabel.Margin = new Padding(2, 0, 2, 0);
            addUserNameLabel.Name = "addUserNameLabel";
            addUserNameLabel.Size = new Size(80, 20);
            addUserNameLabel.TabIndex = 9;
            addUserNameLabel.Text = "First Name";
            // 
            // addUserLabel
            // 
            addUserLabel.AutoSize = true;
            addUserLabel.BackColor = Color.Transparent;
            addUserLabel.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            addUserLabel.Location = new Point(10, 8);
            addUserLabel.Margin = new Padding(2, 0, 2, 0);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(238, 46);
            addUserLabel.TabIndex = 7;
            addUserLabel.Text = "Add new user";
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(ShowListButton);
            panelDashboard.Controls.Add(CurrentIncidentsLabel);
            panelDashboard.Controls.Add(ClosedTicketsChart);
            panelDashboard.Controls.Add(OpenTicketsChart);
            panelDashboard.Location = new Point(5, 132);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1054, 713);
            panelDashboard.TabIndex = 26;
            // 
            // CurrentIncidentsLabel
            // 
            CurrentIncidentsLabel.AutoSize = true;
            CurrentIncidentsLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentIncidentsLabel.Location = new Point(83, 36);
            CurrentIncidentsLabel.Name = "CurrentIncidentsLabel";
            CurrentIncidentsLabel.Size = new Size(296, 46);
            CurrentIncidentsLabel.TabIndex = 3;
            CurrentIncidentsLabel.Text = "Current incidents";
            // 
            // ClosedTicketsChart
            // 
            chartArea3.Name = "ChartArea1";
            ClosedTicketsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            ClosedTicketsChart.Legends.Add(legend3);
            ClosedTicketsChart.Location = new Point(593, 210);
            ClosedTicketsChart.Name = "ClosedTicketsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            ClosedTicketsChart.Series.Add(series3);
            ClosedTicketsChart.Size = new Size(424, 452);
            ClosedTicketsChart.TabIndex = 1;
            ClosedTicketsChart.Text = "chart2";
            // 
            // OpenTicketsChart
            // 
            chartArea4.Name = "ChartArea1";
            OpenTicketsChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            OpenTicketsChart.Legends.Add(legend4);
            OpenTicketsChart.Location = new Point(74, 210);
            OpenTicketsChart.Name = "OpenTicketsChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            OpenTicketsChart.Series.Add(series4);
            OpenTicketsChart.Size = new Size(424, 452);
            OpenTicketsChart.TabIndex = 0;
            OpenTicketsChart.Text = "chart1";
            // 
            // ShowListButton
            // 
            ShowListButton.BackColor = Color.DeepSkyBlue;
            ShowListButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowListButton.ForeColor = Color.White;
            ShowListButton.Location = new Point(821, 26);
            ShowListButton.Name = "ShowListButton";
            ShowListButton.Size = new Size(152, 74);
            ShowListButton.TabIndex = 4;
            ShowListButton.Text = "Show List";
            ShowListButton.UseVisualStyleBackColor = false;
            ShowListButton.Click += ShowListButton_Click;
            // modifyIncidentPanel
            // 
            modifyIncidentPanel.BackColor = Color.White;
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
            modifyIncidentPanel.Margin = new Padding(2);
            modifyIncidentPanel.Name = "modifyIncidentPanel";
            modifyIncidentPanel.Size = new Size(922, 535);
            modifyIncidentPanel.TabIndex = 23;
            // 
            // labelTicket
            // 
            labelTicket.AutoSize = true;
            labelTicket.Location = new Point(713, 198);
            labelTicket.Name = "labelTicket";
            labelTicket.Size = new Size(0, 15);
            labelTicket.TabIndex = 23;
            // 
            // deadlineInputModify
            // 
            deadlineInputModify.FormattingEnabled = true;
            deadlineInputModify.Location = new Point(211, 238);
            deadlineInputModify.Margin = new Padding(2);
            deadlineInputModify.Name = "deadlineInputModify";
            deadlineInputModify.Size = new Size(271, 23);
            deadlineInputModify.TabIndex = 22;
            // 
            // priorityInputModify
            // 
            priorityInputModify.FormattingEnabled = true;
            priorityInputModify.Location = new Point(211, 196);
            priorityInputModify.Margin = new Padding(2);
            priorityInputModify.Name = "priorityInputModify";
            priorityInputModify.Size = new Size(271, 23);
            priorityInputModify.TabIndex = 21;
            // 
            // reportedbyInputModify
            // 
            reportedbyInputModify.FormattingEnabled = true;
            reportedbyInputModify.Location = new Point(211, 155);
            reportedbyInputModify.Margin = new Padding(2);
            reportedbyInputModify.Name = "reportedbyInputModify";
            reportedbyInputModify.Size = new Size(271, 23);
            reportedbyInputModify.TabIndex = 20;
            reportedbyInputModify.Text = " Select user";
            // 
            // typeinputModify
            // 
            typeinputModify.FormattingEnabled = true;
            typeinputModify.Location = new Point(211, 111);
            typeinputModify.Margin = new Padding(2);
            typeinputModify.Name = "typeinputModify";
            typeinputModify.Size = new Size(271, 23);
            typeinputModify.TabIndex = 19;
            typeinputModify.Text = " Select type";
            // 
            // subjectInputModify
            // 
            subjectInputModify.Location = new Point(211, 71);
            subjectInputModify.Margin = new Padding(2);
            subjectInputModify.Name = "subjectInputModify";
            subjectInputModify.Size = new Size(271, 23);
            subjectInputModify.TabIndex = 18;
            // 
            // modifyTicketButton
            // 
            modifyTicketButton.BackColor = Color.DeepSkyBlue;
            modifyTicketButton.FlatAppearance.BorderColor = Color.Black;
            modifyTicketButton.FlatAppearance.MouseDownBackColor = Color.White;
            modifyTicketButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            modifyTicketButton.ForeColor = Color.White;
            modifyTicketButton.Location = new Point(350, 436);
            modifyTicketButton.Margin = new Padding(2);
            modifyTicketButton.Name = "modifyTicketButton";
            modifyTicketButton.Size = new Size(130, 34);
            modifyTicketButton.TabIndex = 17;
            modifyTicketButton.Text = "MODIFY TICKET";
            modifyTicketButton.UseVisualStyleBackColor = false;
            modifyTicketButton.Click += modifyTicketButton_Click;
            // 
            // cancelModifyButton
            // 
            cancelModifyButton.BackColor = Color.White;
            cancelModifyButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cancelModifyButton.Location = new Point(211, 436);
            cancelModifyButton.Margin = new Padding(2);
            cancelModifyButton.Name = "cancelModifyButton";
            cancelModifyButton.Size = new Size(109, 34);
            cancelModifyButton.TabIndex = 16;
            cancelModifyButton.Text = "CANCEL";
            cancelModifyButton.UseVisualStyleBackColor = false;
            cancelModifyButton.Click += cancelModifyButton_Click;
            // 
            // descriptionModifyInput
            // 
            descriptionModifyInput.Location = new Point(211, 288);
            descriptionModifyInput.Margin = new Padding(2);
            descriptionModifyInput.MinimumSize = new Size(4, 96);
            descriptionModifyInput.Multiline = true;
            descriptionModifyInput.Name = "descriptionModifyInput";
            descriptionModifyInput.Size = new Size(271, 122);
            descriptionModifyInput.TabIndex = 15;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(39, 288);
            labelDescription.Margin = new Padding(2, 0, 2, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 14;
            labelDescription.Text = "Description:";
            // 
            // labelDeadline
            // 
            labelDeadline.AutoSize = true;
            labelDeadline.Location = new Point(37, 238);
            labelDeadline.Margin = new Padding(2, 0, 2, 0);
            labelDeadline.Name = "labelDeadline";
            labelDeadline.Size = new Size(111, 15);
            labelDeadline.TabIndex = 13;
            labelDeadline.Text = "Deadline/follow up:";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Location = new Point(38, 196);
            labelPriority.Margin = new Padding(2, 0, 2, 0);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(48, 15);
            labelPriority.TabIndex = 12;
            labelPriority.Text = "Priority:";
            // 
            // labelReportedBy
            // 
            labelReportedBy.AutoSize = true;
            labelReportedBy.Location = new Point(38, 155);
            labelReportedBy.Margin = new Padding(2, 0, 2, 0);
            labelReportedBy.Name = "labelReportedBy";
            labelReportedBy.Size = new Size(99, 15);
            labelReportedBy.TabIndex = 11;
            labelReportedBy.Text = "Reported by user:";
            // 
            // labelTypeOfIncident
            // 
            labelTypeOfIncident.AutoSize = true;
            labelTypeOfIncident.Location = new Point(38, 111);
            labelTypeOfIncident.Margin = new Padding(2, 0, 2, 0);
            labelTypeOfIncident.Name = "labelTypeOfIncident";
            labelTypeOfIncident.Size = new Size(94, 15);
            labelTypeOfIncident.TabIndex = 10;
            labelTypeOfIncident.Text = "Type of incident:";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(38, 71);
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
            labelModify.Location = new Point(9, 6);
            labelModify.Margin = new Padding(2, 0, 2, 0);
            labelModify.Name = "labelModify";
            labelModify.Size = new Size(302, 37);
            labelModify.TabIndex = 7;
            labelModify.Text = "Modify incident ticket";
            // 
            // deleteIncidentButton
            // 
            deleteIncidentButton.BackColor = Color.Crimson;
            deleteIncidentButton.FlatAppearance.BorderColor = Color.Black;
            deleteIncidentButton.FlatAppearance.MouseDownBackColor = Color.White;
            deleteIncidentButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            deleteIncidentButton.ForeColor = Color.White;
            deleteIncidentButton.Location = new Point(474, 68);
            deleteIncidentButton.Margin = new Padding(2);
            deleteIncidentButton.Name = "deleteIncidentButton";
            deleteIncidentButton.Size = new Size(137, 34);
            deleteIncidentButton.TabIndex = 22;
            deleteIncidentButton.Text = "REMOVE INCIDENT";
            deleteIncidentButton.UseVisualStyleBackColor = false;
            deleteIncidentButton.Click += deleteIncidentButton_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1070, 855);
            Controls.Add(panelDashboard);
            Controls.Add(ticketOverviewPanel);
            Controls.Add(userManagementPanel);

            ClientSize = new Size(936, 641);
            Controls.Add(ticketOverviewPanel);
            Controls.Add(modifyIncidentPanel);

            Controls.Add(addIncidentPanel);
            Controls.Add(userManagementPanel);
            Controls.Add(DashboardPanel);
            Controls.Add(addUserPanel);
            Margin = new Padding(5);
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
<<<<<<< HEAD
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
=======
        private ColumnHeader id;
        private ColumnHeader EmailAddress;
        private ColumnHeader Username;
        private ColumnHeader date;
        private ColumnHeader priority;
        private CheckBox checkBoxPriorityFilter;
>>>>>>> Louise
    }
}

