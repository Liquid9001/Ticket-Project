using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace MongoProject.UI
{
    public partial class Success : Form
    {
        Login login;
        public Success(Login login)
        {
            InitializeComponent();
            this.login = login;

        }

        Timer timer;
        int count = 2;
        private void Success_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(Timer_Tick);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                timer.Stop();
                this.Close();
                login.Show();
            }

        }



    }
}
