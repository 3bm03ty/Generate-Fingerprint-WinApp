using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zk4500
{
    public partial class Candiates : Form
    {
        public Candiates()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main MainForm = new Main();
            MainForm.Show();
        }

        private void candidates1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.candidates1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fingerPrintDataSet);

        }

        private void Candiates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fingerPrintDataSet.Candidates1' table. You can move, or remove it, as needed.
            this.candidates1TableAdapter.Fill(this.fingerPrintDataSet.Candidates1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
