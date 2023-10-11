using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using MongoProject.Model;
using System.Drawing.Drawing2D;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Databases databases;
        public Form1()
        {
            InitializeComponent();
            RoundButton roundButton1 = new RoundButton();
            roundButton1.Text = "Round Button";
            roundButton1.Size = new Size(120, 40);
            roundButton1.Location = new Point(50, 50);
            roundButton1.BackColor = Color.Blue;
            this.Controls.Add(roundButton1);

            databases = new Databases();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Databases db = new Databases();
            db.AddEmployee();*/

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





    }
}
