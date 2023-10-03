using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;

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
            var dbList = databases.Get_All_Databases();

            foreach (var db in dbList)
            {
                listBox1.Items.Add(db.name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
