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
    public partial class testsearch : Form
    {
        public testsearch()
        {
            InitializeComponent();
        }

        private void votersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.votersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fingerPrintDataSet);

        }

        private void testsearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingerPrintDataSet.Voters1' table. You can move, or remove it, as needed.
            this.voters1TableAdapter.Fill(this.fingerPrintDataSet.Voters1);
            // TODO: This line of code loads data into the 'fingerPrintDataSet.Voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter.Fill(this.fingerPrintDataSet.Voters);

        }

        private void votersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection("Data Source=YOUSSEF\\SQLEXPRESS;Initial Catalog=FingerPrint;Integrated Security=True");
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("Select id,first_name,Full_Name,City,Region,Situation,Gender,Birth_Date,Fingerprint from Voters1 where id=@id", conn1);
            cmd1.Parameters.AddWithValue("id", idTextBox.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if(reader1.Read())
            {
                first_nameTextBox.Text = reader1["first_name"].ToString();
                full_NameTextBox.Text = reader1["Full_Name"].ToString();
                cityTextBox.Text = reader1["City"].ToString();
                regionTextBox.Text = reader1["Region"].ToString();
                situationTextBox.Text = reader1["Situation"].ToString();
                genderTextBox.Text = reader1["Gender"].ToString();
                birth_DateTextBox.Text = reader1["Birth_Date"].ToString();
                fingerprintTextBox.Text = reader1["Fingerprint"].ToString();
                
            }
            else
            {
                MessageBox.Show("not found data");
            }
            conn1.Close();

        }
    }
}
