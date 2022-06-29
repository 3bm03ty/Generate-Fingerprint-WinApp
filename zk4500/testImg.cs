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
using System.IO;

namespace zk4500
{
    public partial class testImg : Form
    {
        public testImg()
        {
            InitializeComponent();
        }

        private void testImg_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=YOUSSEF\\SQLEXPRESS;Initial Catalog=FingerPrint;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);


            connection.Open();
            string sqlQuery = "Insert into BioData(ID,Name,Images)Values('"+textBox1.Text+"','"+textBox2.Text+"',@images)";
            cmd = new SqlCommand(sqlQuery,connection);
            cmd.Parameters.Add(new SqlParameter("@images",images));
            int N = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(N.ToString() + "Data Saved Successfully.");
        }
    }
}
