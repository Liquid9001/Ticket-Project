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
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            RememberMeCheck();
        }
        private void Login_load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                emailTextBox.Text = Properties.Settings.Default.Username;
                passwordTextBox.Text = Properties.Settings.Default.Password;

            }
        }
        private void RememberMeCheck()
        {
            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = emailTextBox.Text;
                Properties.Settings.Default.Password = passwordTextBox.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("saved user");
                MessageBox.Show(Properties.Settings.Default.Username, Properties.Settings.Default.Password);
            }
            if (!rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }
    }
}
