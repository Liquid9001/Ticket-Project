using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using MongoProject.Model;
using MongoDB.Bson.Serialization.Serializers;
using MongoProject.Logic;
using MongoProject.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoApp
{

    public partial class DashBoard : Form
    {
        Employee loggedInEmployee;
        private Databases databases;
        private EmployeeLogic employeeLogic;
        List<Employee> employees;
        List<Ticket> tickets;
        Login login;
        public DashBoard(Employee loggedInEmployee, Login login)
        {
            this.loggedInEmployee = loggedInEmployee;
            InitializeComponent();
            databases = new Databases();
            employeeLogic = new EmployeeLogic();
            employees = databases.GetEmployees();
            this.login = login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HidePanels();
            DashboardPanel.Show();
            panelDashboard.Show();
            LoadDashboard();
        }

        private void HidePanels()
        {
            modifyIncidentPanel.Hide();
            addIncidentPanel.Hide();
            addUserPanel.Hide();
            ticketOverviewPanel.Hide();
            userManagementPanel.Hide();
            panelDashboard.Hide();
        }

        //create incident button is clicked
        private void createIncidentButton_Click(object sender, EventArgs e)
        {
            List<string> TicketDeadline = new List<string>();
            TicketDeadline.Add("7 days");
            TicketDeadline.Add("14 days");
            TicketDeadline.Add("28 days");
            TicketDeadline.Add("6 months");

            ticketOverviewPanel.Hide();

            //initiate combobox 'type of incident'
            incidentTypeInput.DataSource = Enum.GetValues(typeof(TicketType));
            incidentTypeInput.Text = "Select type";

            //initiate combobox 'priority'
            priorityInput.DataSource = Enum.GetValues(typeof(TicketPriority));
            priorityInput.Text = TicketPriority.Medium.ToString();

            //initiate combobox 'Deadline/Follow up'
            deadlineFollowUpInput.DataSource = TicketDeadline;
            deadlineFollowUpInput.Text = TicketDeadline[0];

            //initiate combobox 'reported user'
            List<Employee> employees = databases.GetEmployees();
            userReportedInput.DisplayMember = "FirstName";
            if (loggedInEmployee.isServiceDesk == true)
            {
                userReportedInput.Show();
                userReportedLabel.Show();
                userReportedInput.DataSource = employees;
                userReportedInput.Text = "Select user";
            }
            else
            {
                userReportedInput.Hide();
                userReportedLabel.Hide();
                userReportedInput.Text = loggedInEmployee.FirstName;
            }
            addIncidentPanel.Show();
        }


        private DateTime GetDeadline(string index)
        {

            DateTime deadlineDate = DateTime.Now;
            switch (index)
            {
                case "7 days":
                    deadlineDate = DateTime.Now.AddDays(7);
                    break;
                case "14 days":
                    deadlineDate = DateTime.Now.AddDays(14);
                    break;
                case "28 days":
                    deadlineDate = DateTime.Now.AddDays(28);
                    break;
                case "6 months":
                    deadlineDate = DateTime.Now.AddMonths(6);
                    break;
            }
            return deadlineDate;
        }



        private void createUserCreateButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            bool isServiceDesk = isServiceDeskCheckBox.Checked;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string emailAddress = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string location = locationTextBox.Text;

            employeeLogic.AddEmployee(username, password, isServiceDesk, firstName, lastName, emailAddress, phoneNumber, location);

            MessageBox.Show("User created");
            HidePanels();
            ShowUserManagementPanel();
            PopulateEmployeeListView();


        }

        private void ShowUserManagementPanel()
        {
            if (loggedInEmployee.isServiceDesk == true)
            {
                addUserButton.Show();
            }
            else
            {
                addUserButton.Hide();
            }
            userManagementPanel.Show();
        }

        private void createUserCancelButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            ShowUserManagementPanel();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            addUserPanel.Show();
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            userSearchBox.Text = "Zoeken";
            ShowUserManagementPanel();
            PopulateEmployeeListView();
        }

        private void PopulateEmployeeListView()
        {
            employees = databases.GetEmployees();
            userOverviewLV.Items.Clear();
            for (int i = 0; i < employees.Count; i++)
            {
                FillListView(i);
            }
        }

        private void incidentManagementButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            ticketOverviewPanel.Show();
            listviewTickets();
        }

        private void userSearchBox_Enter(object sender, EventArgs e)
        {
            if (userSearchBox.Text == "Zoeken")
            {
                userSearchBox.Text = "";
            }
        }

        private void userSearchBox_Leave(object sender, EventArgs e)
        {
            if (userSearchBox.Text == "")
            {
                userSearchBox.Text = "Zoeken";
            }
        }

        private void userSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string search = userSearchBox.Text.ToUpper();

                userOverviewLV.Items.Clear();
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].EmailAddress.ToUpper().Contains(search) || employees[i].FirstName.ToUpper().Contains(search) || employees[i].LastName.ToUpper().Contains(search))
                    {
                        FillListView(i);
                    }
                }
            }
        }

        private void FillListView(int i)
        {
            ListViewItem item = new ListViewItem((i + 1).ToString());
            item.SubItems.Add(employees[i].EmailAddress);
            item.SubItems.Add(employees[i].FirstName);
            item.SubItems.Add(employees[i].LastName);
            item.SubItems.Add(databases.GetTicketCount(employees[i]).ToString());
            userOverviewLV.Items.Add(item);
        }

        private void submitTicketButton_Click_1(object sender, EventArgs e)
        {
            Employee employee;
            if (loggedInEmployee.isServiceDesk == true)
            {
                employee = (Employee)userReportedInput.SelectedItem;
            }
            else
            {
                employee = loggedInEmployee;
            }

            Ticket ticket = new Ticket(subjectInput.Text, (TicketType)incidentTypeInput.SelectedItem, descriptionInput.Text, TicketStatus.Open, employee.Id, DateTime.Now, GetDeadline(deadlineFollowUpInput.SelectedText), (TicketPriority)priorityInput.SelectedItem);
            databases.AddTicket(ticket);
            addIncidentPanel.Hide();


            DialogResult dialogResult = MessageBox.Show("Your ticket has been added!", "Ticket is added", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                ticketOverviewPanel.Show();
            }

            ticketOverviewPanel.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Success success = new Success(login);
                success.Show();
                this.Close();
            }
        }

        //listview ticketoverview
        private void listviewTickets()
        {
            if (!loggedInEmployee.isServiceDesk)
            {
                modifyTicketButton.Hide();
                deleteIncidentButton.Hide();
            }
            int i = 0;
            tickets = databases.GetTickets();
            listViewTicketOverview.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                Employee employee = databases.GetEmployeeById(ticket.EmployeeID);
                FillListViewTickets(i, employee, ticket);
                i++;
            }


        }

        private void FillListViewTickets(int i, Employee employee, Ticket ticket)
        {
            ListViewItem item = new ListViewItem((i + 1).ToString());
            item.SubItems.Add(employee.EmailAddress);
            item.SubItems.Add(employee.username);
            item.SubItems.Add(ticket.CreatedAt.ToString("dd/MM/yyyy HH:mm"));
            item.SubItems.Add(ticket.Priority.ToString());

            listViewTicketOverview.Items.Add(item);
        }

        private void updateIncidentButton_Click(object sender, EventArgs e)
        {

            if (listViewTicketOverview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTicketOverview.SelectedItems[0];
                int id = int.Parse(selectedItem.SubItems[0].Text);
                Ticket ticket = tickets[id - 1];
                OpenModifyTicket(ticket);
            }
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {

            HidePanels();
            panelDashboard.Show();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            OpenTicketsChart.Series["Series1"].Points.Clear();
            OpenTicketsChart.Titles.Clear();
            ClosedTicketsChart.Series["Series2"].Points.Clear();
            ClosedTicketsChart.Titles.Clear();
            if (loggedInEmployee.isServiceDesk == true)
            {
                tickets = databases.GetListOfTickets();

            }
            if (loggedInEmployee.isServiceDesk != true)
            {
                tickets = databases.GetTicketsByEmployeeId(loggedInEmployee);
            }


            int openTickets = 0;
            int urgentTickets = 0;


            foreach (Ticket t in tickets)
            {
                if (t.Status == TicketStatus.Open)
                {
                    openTickets++;
                }
                if (t.Status == TicketStatus.Open & (t.Deadline < DateTime.Today))
                {
                    urgentTickets++;
                }
            }

            OpenTicketsChart.Series["Series1"].Points.AddXY(openTickets, openTickets);
            OpenTicketsChart.Series["Series1"].Points.AddXY(tickets.Count - openTickets, tickets.Count - openTickets);
            OpenTicketsChart.Series[0].Points[0].Color = Color.Orange;
            OpenTicketsChart.Series[0].Points[1].Color = Color.LightGray;
            OpenTicketsChart.Series["Series1"].IsValueShownAsLabel = false;
            OpenTicketsChart.Titles.Add($"\n\n\n Unresolved incidents\r\nAll tickets currently open \n\n {openTickets} /  {100}");

            OpenTicketsChart.ChartAreas[0].Position.Y = 100;
            OpenTicketsChart.ChartAreas[0].Position.X = 10;
            OpenTicketsChart.ChartAreas[0].Position.Height = 60;
            OpenTicketsChart.ChartAreas[0].Position.Width = 80;
            OpenTicketsChart.ChartAreas[0].BackColor = Color.Transparent;

            OpenTicketsChart.Series["Series1"]["PieChart"] = "270";


            ClosedTicketsChart.Series["Series2"].Points.AddXY(urgentTickets, urgentTickets);
            ClosedTicketsChart.Series["Series2"].Points.AddXY(tickets.Count - urgentTickets, tickets.Count - urgentTickets);
            ClosedTicketsChart.Series[0].Points[0].Color = Color.Red;
            ClosedTicketsChart.Series[0].Points[1].Color = Color.LightGray;
            ClosedTicketsChart.Series["Series2"].IsValueShownAsLabel = false;
            ClosedTicketsChart.Titles.Add("\n\n\n Incidents past deadline\r\nThese tickets need your Immediate attention \n\n" + urgentTickets);

            ClosedTicketsChart.ChartAreas[0].Position.Y = 100;
            ClosedTicketsChart.ChartAreas[0].Position.X = 10;
            ClosedTicketsChart.ChartAreas[0].Position.Height = 60;
            ClosedTicketsChart.ChartAreas[0].Position.Width = 80;
            ClosedTicketsChart.ChartAreas[0].BackColor = Color.Transparent;

            ClosedTicketsChart.Series["Series2"]["PieChart"] = "180";
        }

        private void ShowListButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            ticketOverviewPanel.Show();
            listviewTickets();
        }
        private void deleteIncidentButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to PERMANENTLY DELETE this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                ListViewItem selectedItem = listViewTicketOverview.SelectedItems[0];
                int id = int.Parse(selectedItem.SubItems[0].Text);
                Ticket ticket = tickets[id - 1];
                databases.DeleteTicket(ticket);
                MessageBox.Show("Ticket deleted!");
                listviewTickets();
            }
            else
            {
                MessageBox.Show("Ticket not deleted!");
            }
        }
        private void retireIncidentButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to retire this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                ListViewItem selectedItem = listViewTicketOverview.SelectedItems[0];
                int id = int.Parse(selectedItem.SubItems[0].Text);
                Ticket ticket = tickets[id - 1];
                databases.RetireTicket(ticket);
                MessageBox.Show("Ticket deleted!");
                listviewTickets();
            }
            else
            {
                MessageBox.Show("Ticket not deleted!");
            }
        }

        private void OpenModifyTicket(Ticket ticket)
        {
            HidePanels();
            Employee employee = databases.GetEmployeeById(ticket.EmployeeID);

            labelTicket.Tag = ticket;

            reportedbyInputModify.Text = ticket.EmployeeID.ToString();


            List<string> TicketDeadline = new List<string>();
            TicketDeadline.Add("7 days");
            TicketDeadline.Add("14 days");
            TicketDeadline.Add("28 days");
            TicketDeadline.Add("6 months");

            //initiate combobox 'type of incident'
            typeinputModify.DataSource = Enum.GetValues(typeof(TicketType));
            typeinputModify.SelectedItem = ticket.TypeOfIncident;

            //initiate combobox 'priority'
            priorityInputModify.DataSource = Enum.GetValues(typeof(TicketPriority));
            priorityInputModify.SelectedItem = ticket.Priority;

            //initiate combobox 'Deadline/Follow up'
            deadlineInputModify.DataSource = TicketDeadline;
            deadlineInputModify.SelectedItem = ticket.Deadline;

            //initiate combobox 'reported user'
            List<Employee> employees = databases.GetEmployees();
            reportedbyInputModify.DataSource = employees;
            reportedbyInputModify.SelectedItem = employee;
            reportedbyInputModify.DisplayMember = "FirstName";


            subjectInputModify.Text = ticket.Title;
            descriptionModifyInput.Text = ticket.Description;

            modifyIncidentPanel.Show();
        }



        private void modifyTicketButton_Click(object sender, EventArgs e)
        {
            Ticket oldTicket = (Ticket)labelTicket.Tag;
            Ticket ticket = new Ticket(oldTicket.Id, subjectInputModify.Text, (TicketType)typeinputModify.SelectedItem, descriptionModifyInput.Text, TicketStatus.Open, oldTicket.EmployeeID, oldTicket.CreatedAt, GetDeadline(deadlineInputModify.SelectedText), (TicketPriority)priorityInputModify.SelectedItem);
            databases.UpdateTicket(ticket);
            modifyIncidentPanel.Hide();
            ticketOverviewPanel.Show();
        }

        private void cancelModifyButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            listviewTickets();
            ticketOverviewPanel.Show();
        }


        private void filterTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = filterTextBoxInput.Text;
            tickets = databases.GetTickets();
            listViewTicketOverview.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                Employee employee = databases.GetEmployeeById(ticket.EmployeeID);
                if ((employee.EmailAddress.Contains(filter)) || employee.username.Contains(filter))
                {
                    FillListViewTickets(i, employee, ticket);
                }

                i++;
            }

        }

        private void checkBoxPriorityFilter_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            listViewTicketOverview.Items.Clear();
            tickets = databases.GetTickets();
            if (checkBoxPriorityFilter.Checked)
            {
                List<Ticket> sortedTickets = new List<Ticket>();
                sortedTickets = tickets.OrderByDescending(x => (int)x.Priority).ToList();
                foreach (Ticket ticket in sortedTickets)
                {
                    Employee employee = databases.GetEmployeeById(ticket.EmployeeID);
                    FillListViewTickets(i, employee, ticket);
                    i++;
                }
            }
            else
            {
                listviewTickets();
            }

        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            addIncidentPanel.Hide();
            ticketOverviewPanel.Show();
        }
    }
}
