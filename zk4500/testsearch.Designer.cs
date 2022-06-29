
namespace zk4500
{
    partial class testsearch
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label full_NameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label situationLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birth_DateLabel;
            System.Windows.Forms.Label fingerprintLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testsearch));
            this.fingerPrintDataSet = new zk4500.FingerPrintDataSet();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new zk4500.FingerPrintDataSetTableAdapters.VotersTableAdapter();
            this.tableAdapterManager = new zk4500.FingerPrintDataSetTableAdapters.TableAdapterManager();
            this.votersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.votersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.voters1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voters1TableAdapter = new zk4500.FingerPrintDataSetTableAdapters.Voters1TableAdapter();
            this.voters1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.full_NameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.situationTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.birth_DateTextBox = new System.Windows.Forms.TextBox();
            this.fingerprintTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            full_NameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            situationLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birth_DateLabel = new System.Windows.Forms.Label();
            fingerprintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingNavigator)).BeginInit();
            this.votersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voters1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voters1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(71, 89);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(71, 117);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(74, 17);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "first name:";
            // 
            // full_NameLabel
            // 
            full_NameLabel.AutoSize = true;
            full_NameLabel.Location = new System.Drawing.Point(71, 145);
            full_NameLabel.Name = "full_NameLabel";
            full_NameLabel.Size = new System.Drawing.Size(75, 17);
            full_NameLabel.TabIndex = 6;
            full_NameLabel.Text = "Full Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(71, 173);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(71, 201);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(57, 17);
            regionLabel.TabIndex = 10;
            regionLabel.Text = "Region:";
            // 
            // situationLabel
            // 
            situationLabel.AutoSize = true;
            situationLabel.Location = new System.Drawing.Point(71, 229);
            situationLabel.Name = "situationLabel";
            situationLabel.Size = new System.Drawing.Size(67, 17);
            situationLabel.TabIndex = 12;
            situationLabel.Text = "Situation:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(71, 257);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 14;
            genderLabel.Text = "Gender:";
            // 
            // birth_DateLabel
            // 
            birth_DateLabel.AutoSize = true;
            birth_DateLabel.Location = new System.Drawing.Point(71, 285);
            birth_DateLabel.Name = "birth_DateLabel";
            birth_DateLabel.Size = new System.Drawing.Size(75, 17);
            birth_DateLabel.TabIndex = 16;
            birth_DateLabel.Text = "Birth Date:";
            // 
            // fingerprintLabel
            // 
            fingerprintLabel.AutoSize = true;
            fingerprintLabel.Location = new System.Drawing.Point(71, 313);
            fingerprintLabel.Name = "fingerprintLabel";
            fingerprintLabel.Size = new System.Drawing.Size(80, 17);
            fingerprintLabel.TabIndex = 18;
            fingerprintLabel.Text = "Fingerprint:";
            // 
            // fingerPrintDataSet
            // 
            this.fingerPrintDataSet.DataSetName = "FingerPrintDataSet";
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
            this.votersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.votersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.votersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.votersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.votersBindingNavigatorSaveItem});
            this.votersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.votersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.votersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.votersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.votersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.votersBindingNavigator.Name = "votersBindingNavigator";
            this.votersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.votersBindingNavigator.Size = new System.Drawing.Size(887, 31);
            this.votersBindingNavigator.TabIndex = 0;
            this.votersBindingNavigator.Text = "bindingNavigator1";
            this.votersBindingNavigator.RefreshItems += new System.EventHandler(this.votersBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // votersBindingNavigatorSaveItem
            // 
            this.votersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.votersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("votersBindingNavigatorSaveItem.Image")));
            this.votersBindingNavigatorSaveItem.Name = "votersBindingNavigatorSaveItem";
            this.votersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.votersBindingNavigatorSaveItem.Text = "Save Data";
            this.votersBindingNavigatorSaveItem.Click += new System.EventHandler(this.votersBindingNavigatorSaveItem_Click);
            // 
            // voters1BindingSource
            // 
            this.voters1BindingSource.DataMember = "Voters1";
            this.voters1BindingSource.DataSource = this.fingerPrintDataSet;
            // 
            // voters1TableAdapter
            // 
            this.voters1TableAdapter.ClearBeforeFill = true;
            // 
            // voters1DataGridView
            // 
            this.voters1DataGridView.AutoGenerateColumns = false;
            this.voters1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voters1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.voters1DataGridView.DataSource = this.voters1BindingSource;
            this.voters1DataGridView.Location = new System.Drawing.Point(468, 82);
            this.voters1DataGridView.Name = "voters1DataGridView";
            this.voters1DataGridView.RowHeadersWidth = 51;
            this.voters1DataGridView.RowTemplate.Height = 24;
            this.voters1DataGridView.Size = new System.Drawing.Size(300, 220);
            this.voters1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Full_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Full_Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn5.HeaderText = "Region";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Situation";
            this.dataGridViewTextBoxColumn6.HeaderText = "Situation";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Birth_Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Birth_Date";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fingerprint";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fingerprint";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(157, 86);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(157, 114);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // full_NameTextBox
            // 
            this.full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "Full_Name", true));
            this.full_NameTextBox.Location = new System.Drawing.Point(157, 142);
            this.full_NameTextBox.Name = "full_NameTextBox";
            this.full_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.full_NameTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(157, 170);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 9;
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(157, 198);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(100, 22);
            this.regionTextBox.TabIndex = 11;
            // 
            // situationTextBox
            // 
            this.situationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "Situation", true));
            this.situationTextBox.Location = new System.Drawing.Point(157, 226);
            this.situationTextBox.Name = "situationTextBox";
            this.situationTextBox.Size = new System.Drawing.Size(100, 22);
            this.situationTextBox.TabIndex = 13;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(157, 254);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 22);
            this.genderTextBox.TabIndex = 15;
            // 
            // birth_DateTextBox
            // 
            this.birth_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "Birth_Date", true));
            this.birth_DateTextBox.Location = new System.Drawing.Point(157, 282);
            this.birth_DateTextBox.Name = "birth_DateTextBox";
            this.birth_DateTextBox.Size = new System.Drawing.Size(100, 22);
            this.birth_DateTextBox.TabIndex = 17;
            // 
            // fingerprintTextBox
            // 
            this.fingerprintTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voters1BindingSource, "Fingerprint", true));
            this.fingerprintTextBox.Location = new System.Drawing.Point(157, 310);
            this.fingerprintTextBox.Name = "fingerprintTextBox";
            this.fingerprintTextBox.Size = new System.Drawing.Size(100, 22);
            this.fingerprintTextBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(full_NameLabel);
            this.Controls.Add(this.full_NameTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(situationLabel);
            this.Controls.Add(this.situationTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(birth_DateLabel);
            this.Controls.Add(this.birth_DateTextBox);
            this.Controls.Add(fingerprintLabel);
            this.Controls.Add(this.fingerprintTextBox);
            this.Controls.Add(this.voters1DataGridView);
            this.Controls.Add(this.votersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "testsearch";
            this.Text = "testsearch";
            this.Load += new System.EventHandler(this.testsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingNavigator)).EndInit();
            this.votersBindingNavigator.ResumeLayout(false);
            this.votersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voters1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voters1DataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton votersBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource voters1BindingSource;
        private FingerPrintDataSetTableAdapters.Voters1TableAdapter voters1TableAdapter;
        private System.Windows.Forms.DataGridView voters1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox full_NameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox situationTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox birth_DateTextBox;
        private System.Windows.Forms.TextBox fingerprintTextBox;
        private System.Windows.Forms.Button button1;
    }
}