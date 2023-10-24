using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using MongoProject.Model;
using MongoDB.Bson.Serialization.Serializers;

namespace DemoApp
{
    public partial class DashBoard : Form
    {
        private Databases databases;
        public DashBoard()
        {
            InitializeComponent();
            databases = new Databases();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DashboardPanel.Show();
            addIncidentPanel.Hide();
            addUserPanel.Hide();
            ticketOverviewPanel.Hide();
            userManagementPanel.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            priorityInput.Text = TicketPriority.Normal.ToString();

            //initiate combobox 'Deadline/Follow up'
            deadlineFollowUpInput.DataSource = TicketDeadline;
            deadlineFollowUpInput.Text = TicketDeadline[0];

            //initiate combobox 'reported user'
            List<Employee> employees = databases.GetEmployees();
            userReportedInput.DataSource = employees;
            userReportedInput.DisplayMember = "FirstName";
            if (loggedInEmployee.isServiceDesk == true)
            {
                userReportedInput.Text = "Select user";
            }
            else
            {
                userReportedInput.Text = loggedInEmployee.FirstName;
            }
            addIncidentPanel.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            addIncidentPanel.Hide();
            ticketOverviewPanel.Show();
        }

        private void submitTicketButton_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)userReportedInput.SelectedItem;
            Ticket ticket = new Ticket(subjectInput.Text, (TicketType)incidentTypeInput.SelectedItem, descriptionInput.Text, TicketStatus.Open, employee.Id, DateTime.Now, GetDeadline(deadlineFollowUpInput.SelectedText), (TicketPriority)priorityInput.SelectedItem);
            addIncidentPanel.Hide();
            //popup
            ticketOverviewPanel.Show();

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

        private void subjectInput_TextChanged(object sender, EventArgs e)
        {
            string subject = subjectInput.Text;
        }

        private void createUserCreateButton_Click(object sender, EventArgs e)
        {

            string username = firstNameTextBox.Text;
            string password = passwordTextBox.Text;
            bool isServiceDesk = isServiceDeskCheckBox.Checked;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string emailAddress = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string location = locationTextBox.Text;

            Employee employee = new Employee(username, password, isServiceDesk, firstName, lastName, emailAddress, phoneNumber, location);

            databases.AddEmployee(employee);
        }

        private void createUserCancelButton_Click(object sender, EventArgs e)
        {
            addUserPanel.Hide();
            userManagementPanel.Show();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            userManagementPanel.Hide();
            addUserPanel.Show();
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            userManagementPanel.Show();
            List<Employee> employees = databases.GetEmployees();
            for (int i = 0; i < employees.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1.ToString());
                item.SubItems.Add(employees[i].FirstName);
                item.SubItems.Add(employees[i].LastName);
                item.SubItems.Add("30");
                userOverviewLV.Items.Add(item);
            }
        }
    }
}
