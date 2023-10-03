using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Databases databases;
        public Form1()
        {
            InitializeComponent();
            databases = new Databases();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
