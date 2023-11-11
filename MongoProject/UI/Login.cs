using DemoApp;
using Microsoft.VisualBasic.Logging;
using MongoProject.Logic;
using MongoProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoProject.UI
{
    public partial class Login : Form
    {
        private Employee _employee;
        private EmployeeLogic logic;
        public Login()
        {
            _employee = new Employee();
            logic = new EmployeeLogic();
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                RememberMeCheck();
                _employee.username = usernameTextBox.Text.ToString();
                _employee.password = passwordTextBox.Text.ToString();
                _employee = logic.ValidateUser(_employee);
                if (_employee == null)
                {
                    MessageBox.Show("username or password are invalid", "Error", MessageBoxButtons.OK);
                }
                // dit is voor de waiter 
                else if (_employee.username != null || _employee.password != null)
                {
                    DashBoard dashboard = new DashBoard(_employee, this);
                    dashboard.Show();
                    this.Hide();
                    ClearTextBox();
                }
            }
            catch
            {
                MessageBox.Show("username or password are invalid ");
            }
        }
        private void Login_load(object sender, EventArgs e)
        {
            //Properties.Settings.Default;
            if (Properties.Settings.Default.Username != string.Empty)
            {
                usernameTextBox.Text = Properties.Settings.Default.Username;
                passwordTextBox.Text = Properties.Settings.Default.Password;
            }
        }
        private void RememberMeCheck()
        {
            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = usernameTextBox.Text;
                Properties.Settings.Default.Password = passwordTextBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }
        private void ClearTextBox() 
        {
            if (!rememberMeCheckBox.Checked) 
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            

        }
    }
}
