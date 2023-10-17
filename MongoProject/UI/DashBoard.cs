using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using MongoProject.Model;

namespace DemoApp
{
    public partial class DashBoard : Form
    {
        private Databases database;
        public DashBoard()
        {
            InitializeComponent();
            database = new Databases();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DashboardPanel.Hide();
            addIncidentPanel.Hide();
            userManagementPanel.Show();

            List<Employee> employees = database.GetEmployees();

            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.PhoneNumber);
                listViewUsers.Items.Add(item);
            }

        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userManagementPanel_Paint(object sender, PaintEventArgs e)
        {
            List<Employee> employees = database.GetEmployees();
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.PhoneNumber);
                listViewUsers.Items.Add(item);
            }

        }
    }
}
