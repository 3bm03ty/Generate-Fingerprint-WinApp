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
    public partial class Login : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        int flag = -1;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string cs = "Data Source=3BMO3TY\\SQLEXPRESS;Initial Catalog=FingerPrint;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from [FingerPrint].[dbo].[Admin] where [FingerPrint].[dbo].[Admin].AdminName=@username and [FingerPrint].[dbo].[Admin].Password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    Main fm = new Main();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /* if(textBox1.Text=="Youssef" &&  textBox2.Text=="123" )
             {
                 this.Hide();
                 Main MainForm = new Main();
                 MainForm.Show();
             }
             else
             {
                 MessageBox.Show("E-mail or Password are incorrect please try again", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             */
        }
    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
            {
                panel2.Hide();

            }
            else
            {
                panel2.Show();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
            {
                panel2.Hide();

            }
            else
            {
                panel2.Show();

            }
        }

        private void VoteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search SearchForm = new Search();
            SearchForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

