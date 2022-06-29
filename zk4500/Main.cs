using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zk4500
{
    public partial class Main : Form
    {
        int flag1 = -1;

        public Main()
        {
            InitializeComponent();
        }

        private void EvotingLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VoteBtn_Click(object sender, EventArgs e)
        {
            
           flag1 *= -1;
            if (flag1 == 1)
            {
                MainPanel.Hide();
                EditPanel.Hide();


            }
            else
            {
                MainPanel.Show();
                EditPanel.Show();

            }

            //show number of voters and number non voters and number of pending voters
            label5.Text = dataGridView1.Rows.Count.ToString();
            label6.Text = dataGridView2.Rows.Count.ToString();

           // string query_voted = "Select Count(*) from Voters where V_state = '1'";
            //string query_pending = "Select Count(*) from Voters where V_state = '0'";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingerPrintDataSet.Candidates1' table. You can move, or remove it, as needed.
            this.candidates1TableAdapter.Fill(this.fingerPrintDataSet.Candidates1);
            // TODO: This line of code loads data into the 'fingerPrintDataSet.Voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter.Fill(this.fingerPrintDataSet.Voters);

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            flag1 *= -1;
            if (flag1 == 1)
            {
                MainPanel.Hide();

            }
            else
            {
                MainPanel.Show();

            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            flag1 *= -1;
            if (flag1 == 1)
            {
                MainPanel.Hide();
                EditPanel.Hide();
                DashboardPanel.Hide();

            }
            else
            {
                MainPanel.Show();
                EditPanel.Show();
                DashboardPanel.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void ResultsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results ResultsForm = new Results();
            ResultsForm.Show();

        }


        private void DashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender,EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Candiates cand = new Candiates();
            cand.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateElection elec = new CreateElection();
            elec.Show();
        }
    }
}
