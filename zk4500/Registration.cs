using AxZKFPEngXControl;
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
    public partial class Registration : Form
    {
        private AxZKFPEngX ZkFprint = new AxZKFPEngX();
        private bool Check;

        SqlConnection con = new SqlConnection(@"Data Source=3BMO3TY\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        
        public Registration()
        {
            InitializeComponent();
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void votersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.votersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fingerPrintDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingerPrintDataSet1.Voters' table. You can move, or remove it, as needed.
            //this.votersTableAdapter.Fill(this.fingerPrintDataSet1.Voters);
            Controls.Add(ZkFprint);
            InitialAxZkfp();
            this.statusTextBox.Text = "Married";
            this.genderTextBox.Text = "Male";
            this.birthdayDateTimePicker.Value = birthdayDateTimePicker.Value;
            /////////////////////////////////////////////////////////////////
            ///ZkFprint.CancelEnroll();
            ZkFprint.EnrollCount = 3;
            ZkFprint.BeginEnroll();
            ShowHintInfo("Please give fingerprint sample.");
        }


        private void InitialAxZkfp()
        {
            try
            {

                ZkFprint.OnImageReceived += zkFprint_OnImageReceived;
                ZkFprint.OnFeatureInfo += zkFprint_OnFeatureInfo;
                //zkFprint.OnFingerTouching 
                //zkFprint.OnFingerLeaving
                ZkFprint.OnEnroll += zkFprint_OnEnroll;

                if (ZkFprint.InitEngine() == 0)
                {
                    ZkFprint.FPEngineVersion = "9";
                    ZkFprint.EnrollCount = 3;
                    deviceSerial.Text += " " + ZkFprint.SensorSN + " Count: " + ZkFprint.SensorCount.ToString() + " Index: " + ZkFprint.SensorIndex.ToString();
                    ShowHintInfo("Device successfully connected");
                }

            }
            catch (Exception ex)
            {
                ShowHintInfo("Device init err, error: " + ex.Message);
            }
        }

        private void zkFprint_OnImageReceived(object sender, IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            Graphics g = fpicture.CreateGraphics();
            Bitmap bmp = new Bitmap(fpicture.Width, fpicture.Height);
            g = Graphics.FromImage(bmp);
            int dc = g.GetHdc().ToInt32();
            ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            fpicture.Image = bmp;
        }

        private void zkFprint_OnFeatureInfo(object sender, IZKFPEngXEvents_OnFeatureInfoEvent e)
        {

            String strTemp = string.Empty;
            if (ZkFprint.EnrollIndex != 1)
            {
                if (ZkFprint.IsRegister)
                {
                    if (ZkFprint.EnrollIndex - 1 > 0)
                    {
                        int eindex = ZkFprint.EnrollIndex - 1;
                        strTemp = "Please scan again ..." + eindex;
                    }
                }
            }
            ShowHintInfo(strTemp);
        }
        private void zkFprint_OnEnroll(object sender, IZKFPEngXEvents_OnEnrollEvent e)
        {
            if (e.actionResult)
            {


                string template = ZkFprint.EncodeTemplate1(e.aTemplate);
                templeteTextBox.Text = template;
                ShowHintInfo("Registration successful. You can verify now");
                btnRegister.Enabled = false;
                btnVerify.Enabled = true;
            }
            else
            {
                ShowHintInfo("Error, please register again.");

            }
        }
        private void zkFprint_OnCapture(object sender, IZKFPEngXEvents_OnCaptureEvent e)
        {
            string template = ZkFprint.EncodeTemplate1(e.aTemplate);


            if (ZkFprint.VerFingerFromStr(ref template, templeteTextBox.Text, false, ref Check))
            {
                ShowHintInfo("Verified");
            }
            else
                ShowHintInfo("Not Verified");

        }



        private void ShowHintInfo(String s)
        {
            prompt.Text = s;
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (ZkFprint.IsRegister)
            {
                ZkFprint.CancelEnroll();
            }
            ZkFprint.OnCapture += zkFprint_OnCapture;
            ZkFprint.BeginCapture();
            ShowHintInfo("Please give fingerprint sample.");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            ZkFprint.CancelEnroll();
            ZkFprint.EnrollCount = 3;
            ZkFprint.BeginEnroll();
            ShowHintInfo("Please give fingerprint sample.");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fpicture.Image = null;
        }






        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void templeteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void templete_Click(object sender, EventArgs e)
        {

        }

        private void addVoter_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Insert into Voters1 values('" + fNameTextBox.Text + "','" + parentNameTextBox.Text + "','" + iDTextBox.Text + "','" + cityTextBox.Text + "','" + stateTextBox.Text + "','" + statusTextBox.Text + "','" + genderTextBox.Text + "','" + birthdayDateTimePicker.Text + "','" + templeteTextBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is saved succefully");
            con.Close();


          //  this.votersBindingNavigatorSaveItem.PerformClick();
            Reset_form();
        }

        public void Reset_form()
        {
            fNameTextBox.Text = "";
            parentNameTextBox.Text = "";
            iDTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            fNameTextBox.Text = "";
            fNameTextBox.Text = "";
            fNameTextBox.Text = "";
            radioButton_married.Checked = true;
            radioButton_male.Checked = true;
            templeteTextBox.Text = "";
        }



        private void templeteTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton_married_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_married.Checked)
            {
                this.statusTextBox.Text = "Married";
            }
            else
            {
                this.statusTextBox.Text = "Single";
            }
        }

        private void radioButton_single_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_married.Checked)
            {
                this.statusTextBox.Text = "Married";
            }
            else
            {
                this.statusTextBox.Text = "Single";
            }
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_male.Checked)
            {
                this.genderTextBox.Text = "Male";
            }
            else
            {
                this.genderTextBox.Text = "Female";
            }
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_male.Checked)
            {
                this.genderTextBox.Text = "Male";
            }
            else
            {
                this.genderTextBox.Text = "Female";
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            ZkFprint.CancelEnroll();
            ZkFprint.EnrollCount = 3;
            ZkFprint.BeginEnroll();
            ShowHintInfo("Please give fingerprint sample.");

        }

        private void btnVerify_Click_1(object sender, EventArgs e)
        {
            if (ZkFprint.IsRegister)
            {
                ZkFprint.CancelEnroll();
            }
            ZkFprint.OnCapture += zkFprint_OnCapture;
            ZkFprint.BeginCapture();
            ShowHintInfo("Please give fingerprint sample.");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fpicture_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Reset_form();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
