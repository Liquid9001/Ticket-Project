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
            ticketOverviewPanel.Hide();

            //initiate combobox 'type of incident'
            incidentTypeInput.DataSource = Enum.GetValues(typeof(TicketType));
            incidentTypeInput.Text = "Select type";

            //iniciate combobox 'select user'
            //userReportedInput.DataSource = 


            addIncidentPanel.Show();
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

            }
        }
    }
}
