
namespace zk4500
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label parentNameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label templeteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.fingerPrintDataSet = new zk4500.FingerPrintDataSet();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new zk4500.FingerPrintDataSetTableAdapters.VotersTableAdapter();
            this.tableAdapterManager = new zk4500.FingerPrintDataSetTableAdapters.TableAdapterManager();
            this.votersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.votersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.parentNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_married = new System.Windows.Forms.RadioButton();
            this.radioButton_single = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addVoter_btn = new System.Windows.Forms.Button();
            this.templeteTextBox = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.deviceSerial = new System.Windows.Forms.Label();
            this.prompt = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.fpicture = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            parentNameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            templeteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingNavigator)).BeginInit();
            this.votersBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(4, 27);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 17);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(5, 19);
            fNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(76, 17);
            fNameLabel.TabIndex = 3;
            fNameLabel.Text = "First Name";
            // 
            // parentNameLabel
            // 
            parentNameLabel.AutoSize = true;
            parentNameLabel.Location = new System.Drawing.Point(359, 19);
            parentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            parentNameLabel.Name = "parentNameLabel";
            parentNameLabel.Size = new System.Drawing.Size(117, 17);
            parentNameLabel.TabIndex = 5;
            parentNameLabel.Text = "Parent Full Name";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(8, 27);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(31, 17);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(367, 26);
            stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(41, 17);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State";
            // 
            // templeteLabel
            // 
            templeteLabel.AutoSize = true;
            templeteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            templeteLabel.Location = new System.Drawing.Point(21, 746);
            templeteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            templeteLabel.Name = "templeteLabel";
            templeteLabel.Size = new System.Drawing.Size(99, 20);
            templeteLabel.TabIndex = 17;
            templeteLabel.Text = "Fingerprint :";
            // 
            // fingerPrintDataSet
            // 
            this.fingerPrintDataSet.DataSetName = "FingerPrintDataSet1";
            this.fingerPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "Voters";
            this.votersBindingSource.DataSource = this.fingerPrintDataSet;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BioDataTableAdapter = null;
            this.tableAdapterManager.Candidates1TableAdapter = null;
            this.tableAdapterManager.CandidatesTableAdapter = null;
            this.tableAdapterManager.FingerprintTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = zk4500.FingerPrintDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Voters1TableAdapter = null;
            this.tableAdapterManager.VotersTableAdapter = this.votersTableAdapter;
            // 
            // votersBindingNavigator
            // 
            this.votersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.votersBindingNavigator.BindingSource = this.votersBindingSource;
            this.votersBindingNavigator.CountItem = null;
            this.votersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.votersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.votersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.votersBindingNavigatorSaveItem});
            this.votersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.votersBindingNavigator.MoveFirstItem = null;
            this.votersBindingNavigator.MoveLastItem = null;
            this.votersBindingNavigator.MoveNextItem = null;
            this.votersBindingNavigator.MovePreviousItem = null;
            this.votersBindingNavigator.Name = "votersBindingNavigator";
            this.votersBindingNavigator.PositionItem = null;
            this.votersBindingNavigator.Size = new System.Drawing.Size(1600, 31);
            this.votersBindingNavigator.TabIndex = 0;
            this.votersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // votersBindingNavigatorSaveItem
            // 
            this.votersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.votersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("votersBindingNavigatorSaveItem.Image")));
            this.votersBindingNavigatorSaveItem.Name = "votersBindingNavigatorSaveItem";
            this.votersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.votersBindingNavigatorSaveItem.Text = "Save Data";
            this.votersBindingNavigatorSaveItem.Click += new System.EventHandler(this.votersBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(8, 47);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(564, 22);
            this.iDTextBox.TabIndex = 2;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "fName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(8, 41);
            this.fNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.fNameTextBox.TabIndex = 4;
            this.fNameTextBox.TextChanged += new System.EventHandler(this.fNameTextBox_TextChanged);
            // 
            // parentNameTextBox
            // 
            this.parentNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.parentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "parentName", true));
            this.parentNameTextBox.Location = new System.Drawing.Point(362, 41);
            this.parentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.parentNameTextBox.Name = "parentNameTextBox";
            this.parentNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.parentNameTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(8, 47);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(265, 22);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // stateTextBox
            // 
            this.stateTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(370, 47);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(265, 22);
            this.stateTextBox.TabIndex = 10;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.birthdayDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.birthdayDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.birthdayDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.birthdayDateTimePicker.CustomFormat = "dd/mm/yyyy";
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.votersBindingSource, "birthday", true));
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(8, 23);
            this.birthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthdayDateTimePicker.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.birthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.birthdayDateTimePicker.TabIndex = 16;
            this.birthdayDateTimePicker.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.Location = new System.Drawing.Point(27, 31);
            this.radioButton_male.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(59, 21);
            this.radioButton_male.TabIndex = 19;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton_male_CheckedChanged);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(189, 31);
            this.radioButton_female.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(75, 21);
            this.radioButton_female.TabIndex = 20;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.CheckedChanged += new System.EventHandler(this.radioButton_female_CheckedChanged);
            // 
            // radioButton_married
            // 
            this.radioButton_married.AutoSize = true;
            this.radioButton_married.Checked = true;
            this.radioButton_married.Location = new System.Drawing.Point(25, 33);
            this.radioButton_married.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_married.Name = "radioButton_married";
            this.radioButton_married.Size = new System.Drawing.Size(77, 21);
            this.radioButton_married.TabIndex = 21;
            this.radioButton_married.TabStop = true;
            this.radioButton_married.Text = "Married";
            this.radioButton_married.UseVisualStyleBackColor = true;
            this.radioButton_married.CheckedChanged += new System.EventHandler(this.radioButton_married_CheckedChanged);
            // 
            // radioButton_single
            // 
            this.radioButton_single.AutoSize = true;
            this.radioButton_single.Location = new System.Drawing.Point(181, 31);
            this.radioButton_single.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_single.Name = "radioButton_single";
            this.radioButton_single.Size = new System.Drawing.Size(68, 21);
            this.radioButton_single.TabIndex = 22;
            this.radioButton_single.TabStop = true;
            this.radioButton_single.Text = "Single";
            this.radioButton_single.UseVisualStyleBackColor = true;
            this.radioButton_single.CheckedChanged += new System.EventHandler(this.radioButton_single_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fNameTextBox);
            this.groupBox1.Controls.Add(this.parentNameTextBox);
            this.groupBox1.Controls.Add(parentNameLabel);
            this.groupBox1.Controls.Add(fNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(691, 84);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iDTextBox);
            this.groupBox2.Controls.Add(iDLabel);
            this.groupBox2.Location = new System.Drawing.Point(23, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(691, 85);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cityTextBox);
            this.groupBox3.Controls.Add(this.stateTextBox);
            this.groupBox3.Controls.Add(stateLabel);
            this.groupBox3.Controls.Add(cityLabel);
            this.groupBox3.Location = new System.Drawing.Point(27, 367);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(691, 91);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_married);
            this.groupBox4.Controls.Add(this.radioButton_single);
            this.groupBox4.Controls.Add(this.statusTextBox);
            this.groupBox4.Location = new System.Drawing.Point(25, 522);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(316, 64);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "status", true));
            this.statusTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusTextBox.Location = new System.Drawing.Point(110, 30);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(52, 22);
            this.statusTextBox.TabIndex = 12;
            this.statusTextBox.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_male);
            this.groupBox5.Controls.Add(this.radioButton_female);
            this.groupBox5.Controls.Add(this.genderTextBox);
            this.groupBox5.Location = new System.Drawing.Point(370, 522);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(346, 64);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // genderTextBox
            // 
            this.genderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "gender", true));
            this.genderTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.genderTextBox.Location = new System.Drawing.Point(108, 30);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(73, 22);
            this.genderTextBox.TabIndex = 14;
            this.genderTextBox.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.birthdayDateTimePicker);
            this.groupBox6.Location = new System.Drawing.Point(23, 658);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(318, 69);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            // 
            // addVoter_btn
            // 
            this.addVoter_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addVoter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVoter_btn.ForeColor = System.Drawing.Color.Black;
            this.addVoter_btn.Location = new System.Drawing.Point(975, 685);
            this.addVoter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addVoter_btn.Name = "addVoter_btn";
            this.addVoter_btn.Size = new System.Drawing.Size(275, 41);
            this.addVoter_btn.TabIndex = 29;
            this.addVoter_btn.Text = "Add";
            this.addVoter_btn.UseVisualStyleBackColor = false;
            this.addVoter_btn.Click += new System.EventHandler(this.addVoter_btn_Click);
            // 
            // templeteTextBox
            // 
            this.templeteTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.templeteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votersBindingSource, "templete", true));
            this.templeteTextBox.Location = new System.Drawing.Point(23, 779);
            this.templeteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.templeteTextBox.Name = "templeteTextBox";
            this.templeteTextBox.Size = new System.Drawing.Size(433, 22);
            this.templeteTextBox.TabIndex = 30;
            this.templeteTextBox.TextChanged += new System.EventHandler(this.templeteTextBox_TextChanged_1);
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(1170, 138);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 47);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // deviceSerial
            // 
            this.deviceSerial.AutoSize = true;
            this.deviceSerial.Location = new System.Drawing.Point(1107, 280);
            this.deviceSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceSerial.Name = "deviceSerial";
            this.deviceSerial.Size = new System.Drawing.Size(99, 17);
            this.deviceSerial.TabIndex = 33;
            this.deviceSerial.Text = "Device Serial: ";
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Location = new System.Drawing.Point(1107, 580);
            this.prompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(65, 17);
            this.prompt.TabIndex = 34;
            this.prompt.Text = "Ready ...";
            // 
            // btnVerify
            // 
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Location = new System.Drawing.Point(1349, 138);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(127, 47);
            this.btnVerify.TabIndex = 31;
            this.btnVerify.Text = "&Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Visible = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.templeteTextBox);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(templeteLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 869);
            this.panel1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Birthdate :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Gender :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "National ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name :";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.Location = new System.Drawing.Point(1494, 40);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(41, 38);
            this.ExitBtn.TabIndex = 38;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // fpicture
            // 
            this.fpicture.BackColor = System.Drawing.SystemColors.Info;
            this.fpicture.Location = new System.Drawing.Point(1110, 315);
            this.fpicture.Margin = new System.Windows.Forms.Padding(4);
            this.fpicture.Name = "fpicture";
            this.fpicture.Size = new System.Drawing.Size(265, 251);
            this.fpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fpicture.TabIndex = 35;
            this.fpicture.TabStop = false;
            this.fpicture.Click += new System.EventHandler(this.fpicture_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(1260, 685);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(275, 41);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "Delete ";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(975, 756);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(275, 41);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(1260, 756);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(275, 41);
            this.clearBtn.TabIndex = 42;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1381, 820);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 56);
            this.button4.TabIndex = 43;
            this.button4.Text = "Back";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.fpicture);
            this.Controls.Add(this.addVoter_btn);
            this.Controls.Add(this.deviceSerial);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.votersBindingNavigator);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingNavigator)).EndInit();
            this.votersBindingNavigator.ResumeLayout(false);
            this.votersBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FingerPrintDataSet fingerPrintDataSet;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private FingerPrintDataSetTableAdapters.VotersTableAdapter votersTableAdapter;
        private FingerPrintDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator votersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton votersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox parentNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_married;
        private System.Windows.Forms.RadioButton radioButton_single;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button addVoter_btn;
        private System.Windows.Forms.TextBox templeteTextBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox fpicture;
        private System.Windows.Forms.Label deviceSerial;
        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button4;
    }
}