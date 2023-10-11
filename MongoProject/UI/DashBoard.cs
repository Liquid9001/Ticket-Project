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
            /* var dbList = databases.Get_All_Databases();

             foreach (var db in dbList)
             {
                 //listBox1.Items.Add(db.name);
             }*/
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
    }
}
