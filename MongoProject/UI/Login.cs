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
            logic = new EmployeeLogic();
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK);
                return;
            }

            _employee = new Employee();

            try
            {
                RememberMeCheck();
                _employee.username = username;
                _employee.password = password;
                _employee = logic.ValidateUser(_employee);

                if (_employee == null)
                {
                    MessageBox.Show("Username or password is invalid.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    DashBoard dashboard = new DashBoard(_employee, this);
                    dashboard.Show();
                    this.Hide();
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }


        private void Login_load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                usernameTextBox.Text = Properties.Settings.Default.Username;
                passwordTextBox.Text = Properties.Settings.Default.Password;
                rememberMeCheckBox.Checked = true;
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
