namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.searchRdb = new System.Windows.Forms.RadioButton();
            this.insertRdb = new System.Windows.Forms.RadioButton();
            this.modifyRdb = new System.Windows.Forms.RadioButton();
            this.delRdb = new System.Windows.Forms.RadioButton();
            this.toolGB = new System.Windows.Forms.GroupBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDateCmb = new System.Windows.Forms.ComboBox();
            this.記簿BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._321DataSet = new WindowsFormsApp1._321DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.modifypanel = new System.Windows.Forms.Panel();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.modifyDescription = new System.Windows.Forms.TextBox();
            this.modifyExpense = new System.Windows.Forms.TextBox();
            this.modifyIncome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.modifyIdCmb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.modifyDateSearchBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.modifyCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.記簿TableAdapter = new WindowsFormsApp1._321DataSetTableAdapters.記簿TableAdapter();
            this._321DataSet1 = new WindowsFormsApp1._321DataSet1();
            this.記簿BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.記簿TableAdapter1 = new WindowsFormsApp1._321DataSet1TableAdapters.記簿TableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.insertDate = new System.Windows.Forms.DateTimePicker();
            this.insertIncome = new System.Windows.Forms.TextBox();
            this.insertExpense = new System.Windows.Forms.TextBox();
            this.insertDescription = new System.Windows.Forms.TextBox();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteDescription = new System.Windows.Forms.TextBox();
            this.deleteExpense = new System.Windows.Forms.TextBox();
            this.deleteIncome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.deleteIdCmb = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.deleteDateSearchBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteCmb = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.toolGB.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.記簿BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._321DataSet)).BeginInit();
            this.modifypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._321DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.記簿BindingSource1)).BeginInit();
            this.insertPanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchRdb
            // 
            this.searchRdb.AutoSize = true;
            this.searchRdb.Checked = true;
            this.searchRdb.Location = new System.Drawing.Point(22, 58);
            this.searchRdb.Name = "searchRdb";
            this.searchRdb.Size = new System.Drawing.Size(58, 19);
            this.searchRdb.TabIndex = 0;
            this.searchRdb.TabStop = true;
            this.searchRdb.Text = "查詢";
            this.searchRdb.UseVisualStyleBackColor = true;
            this.searchRdb.CheckedChanged += new System.EventHandler(this.searchRdb_CheckedChanged);
            // 
            // insertRdb
            // 
            this.insertRdb.AutoSize = true;
            this.insertRdb.Location = new System.Drawing.Point(108, 58);
            this.insertRdb.Name = "insertRdb";
            this.insertRdb.Size = new System.Drawing.Size(58, 19);
            this.insertRdb.TabIndex = 1;
            this.insertRdb.TabStop = true;
            this.insertRdb.Text = "新增";
            this.insertRdb.UseVisualStyleBackColor = true;
            this.insertRdb.CheckedChanged += new System.EventHandler(this.insertRdb_CheckedChanged);
            // 
            // modifyRdb
            // 
            this.modifyRdb.AutoSize = true;
            this.modifyRdb.Location = new System.Drawing.Point(196, 58);
            this.modifyRdb.Name = "modifyRdb";
            this.modifyRdb.Size = new System.Drawing.Size(58, 19);
            this.modifyRdb.TabIndex = 2;
            this.modifyRdb.TabStop = true;
            this.modifyRdb.Text = "修改";
            this.modifyRdb.UseVisualStyleBackColor = true;
            this.modifyRdb.CheckedChanged += new System.EventHandler(this.modifyRdb_CheckedChanged);
            // 
            // delRdb
            // 
            this.delRdb.AutoSize = true;
            this.delRdb.Location = new System.Drawing.Point(274, 58);
            this.delRdb.Name = "delRdb";
            this.delRdb.Size = new System.Drawing.Size(58, 19);
            this.delRdb.TabIndex = 3;
            this.delRdb.TabStop = true;
            this.delRdb.Text = "刪除";
            this.delRdb.UseVisualStyleBackColor = true;
            this.delRdb.CheckedChanged += new System.EventHandler(this.delRdb_CheckedChanged);
            // 
            // toolGB
            // 
            this.toolGB.Controls.Add(this.searchRdb);
            this.toolGB.Controls.Add(this.delRdb);
            this.toolGB.Controls.Add(this.insertRdb);
            this.toolGB.Controls.Add(this.modifyRdb);
            this.toolGB.Location = new System.Drawing.Point(24, 24);
            this.toolGB.Name = "toolGB";
            this.toolGB.Size = new System.Drawing.Size(398, 121);
            this.toolGB.TabIndex = 4;
            this.toolGB.TabStop = false;
            this.toolGB.Text = "功能選擇";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBtn);
            this.searchPanel.Controls.Add(this.searchDataGridView);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.searchDateCmb);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Location = new System.Drawing.Point(24, 161);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(457, 400);
            this.searchPanel.TabIndex = 6;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(285, 58);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "確定";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowDrop = true;
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(0, 88);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 27;
            this.searchDataGridView.Size = new System.Drawing.Size(457, 271);
            this.searchDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "選擇日期";
            // 
            // searchDateCmb
            // 
            this.searchDateCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.記簿BindingSource, "日期", true));
            this.searchDateCmb.FormattingEnabled = true;
            this.searchDateCmb.Location = new System.Drawing.Point(92, 59);
            this.searchDateCmb.Name = "searchDateCmb";
            this.searchDateCmb.Size = new System.Drawing.Size(177, 23);
            this.searchDateCmb.TabIndex = 1;
            // 
            // 記簿BindingSource
            // 
            this.記簿BindingSource.DataMember = "記簿";
            this.記簿BindingSource.DataSource = this._321DataSet;
            // 
            // _321DataSet
            // 
            this._321DataSet.DataSetName = "_321DataSet";
            this._321DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "查詢";
            // 
            // modifypanel
            // 
            this.modifypanel.Controls.Add(this.modifyBtn);
            this.modifypanel.Controls.Add(this.modifyDescription);
            this.modifypanel.Controls.Add(this.modifyExpense);
            this.modifypanel.Controls.Add(this.modifyIncome);
            this.modifypanel.Controls.Add(this.label13);
            this.modifypanel.Controls.Add(this.label12);
            this.modifypanel.Controls.Add(this.label11);
            this.modifypanel.Controls.Add(this.modifyIdCmb);
            this.modifypanel.Controls.Add(this.label10);
            this.modifypanel.Controls.Add(this.modifyDateSearchBtn);
            this.modifypanel.Controls.Add(this.label8);
            this.modifypanel.Controls.Add(this.modifyCmb);
            this.modifypanel.Controls.Add(this.label9);
            this.modifypanel.Location = new System.Drawing.Point(510, 161);
            this.modifypanel.Name = "modifypanel";
            this.modifypanel.Size = new System.Drawing.Size(457, 400);
            this.modifypanel.TabIndex = 7;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(107, 306);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 31);
            this.modifyBtn.TabIndex = 13;
            this.modifyBtn.Text = "確定";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // modifyDescription
            // 
            this.modifyDescription.Location = new System.Drawing.Point(107, 212);
            this.modifyDescription.Multiline = true;
            this.modifyDescription.Name = "modifyDescription";
            this.modifyDescription.Size = new System.Drawing.Size(177, 69);
            this.modifyDescription.TabIndex = 12;
            // 
            // modifyExpense
            // 
            this.modifyExpense.Location = new System.Drawing.Point(108, 169);
            this.modifyExpense.Name = "modifyExpense";
            this.modifyExpense.Size = new System.Drawing.Size(100, 25);
            this.modifyExpense.TabIndex = 11;
            // 
            // modifyIncome
            // 
            this.modifyIncome.Location = new System.Drawing.Point(108, 129);
            this.modifyIncome.Name = "modifyIncome";
            this.modifyIncome.Size = new System.Drawing.Size(100, 25);
            this.modifyIncome.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "備註";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "支出";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "收入";
            // 
            // modifyIdCmb
            // 
            this.modifyIdCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.記簿BindingSource, "日期", true));
            this.modifyIdCmb.FormattingEnabled = true;
            this.modifyIdCmb.Location = new System.Drawing.Point(107, 92);
            this.modifyIdCmb.Name = "modifyIdCmb";
            this.modifyIdCmb.Size = new System.Drawing.Size(177, 23);
            this.modifyIdCmb.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "選擇流水號";
            // 
            // modifyDateSearchBtn
            // 
            this.modifyDateSearchBtn.Location = new System.Drawing.Point(301, 92);
            this.modifyDateSearchBtn.Name = "modifyDateSearchBtn";
            this.modifyDateSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyDateSearchBtn.TabIndex = 4;
            this.modifyDateSearchBtn.Text = "查詢";
            this.modifyDateSearchBtn.UseVisualStyleBackColor = true;
            this.modifyDateSearchBtn.Click += new System.EventHandler(this.modifyDateSearchBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "選擇日期";
            // 
            // modifyCmb
            // 
            this.modifyCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.記簿BindingSource, "日期", true));
            this.modifyCmb.FormattingEnabled = true;
            this.modifyCmb.Location = new System.Drawing.Point(108, 58);
            this.modifyCmb.Name = "modifyCmb";
            this.modifyCmb.Size = new System.Drawing.Size(177, 23);
            this.modifyCmb.TabIndex = 1;
            this.modifyCmb.TextChanged += new System.EventHandler(this.modifyCmb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "修改";
            // 
            // 記簿TableAdapter
            // 
            this.記簿TableAdapter.ClearBeforeFill = true;
            // 
            // _321DataSet1
            // 
            this._321DataSet1.DataSetName = "_321DataSet1";
            this._321DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 記簿BindingSource1
            // 
            this.記簿BindingSource1.DataMember = "記簿";
            this.記簿BindingSource1.DataSource = this._321DataSet1;
            // 
            // 記簿TableAdapter1
            // 
            this.記簿TableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "新增";
            // 
            // insertDate
            // 
            this.insertDate.CustomFormat = "yyyy/MM/dd";
            this.insertDate.Location = new System.Drawing.Point(108, 88);
            this.insertDate.Name = "insertDate";
            this.insertDate.Size = new System.Drawing.Size(200, 25);
            this.insertDate.TabIndex = 1;
            this.insertDate.Value = new System.DateTime(2020, 5, 21, 0, 0, 0, 0);
            // 
            // insertIncome
            // 
            this.insertIncome.Location = new System.Drawing.Point(108, 129);
            this.insertIncome.Name = "insertIncome";
            this.insertIncome.Size = new System.Drawing.Size(100, 25);
            this.insertIncome.TabIndex = 2;
            this.insertIncome.Text = "0";
            this.insertIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insertExpense
            // 
            this.insertExpense.Location = new System.Drawing.Point(108, 169);
            this.insertExpense.Name = "insertExpense";
            this.insertExpense.Size = new System.Drawing.Size(100, 25);
            this.insertExpense.TabIndex = 3;
            this.insertExpense.Text = "0";
            this.insertExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insertDescription
            // 
            this.insertDescription.Location = new System.Drawing.Point(108, 212);
            this.insertDescription.Multiline = true;
            this.insertDescription.Name = "insertDescription";
            this.insertDescription.Size = new System.Drawing.Size(200, 52);
            this.insertDescription.TabIndex = 4;
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.insertBtn);
            this.insertPanel.Controls.Add(this.label7);
            this.insertPanel.Controls.Add(this.label6);
            this.insertPanel.Controls.Add(this.label5);
            this.insertPanel.Controls.Add(this.label3);
            this.insertPanel.Controls.Add(this.insertDescription);
            this.insertPanel.Controls.Add(this.insertExpense);
            this.insertPanel.Controls.Add(this.insertIncome);
            this.insertPanel.Controls.Add(this.insertDate);
            this.insertPanel.Controls.Add(this.label4);
            this.insertPanel.Location = new System.Drawing.Point(24, 161);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(457, 400);
            this.insertPanel.TabIndex = 7;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(108, 291);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "確定";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "備註";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "支出";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "收入";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "日期";
            // 
            // deletePanel
            // 
            this.deletePanel.Controls.Add(this.deleteBtn);
            this.deletePanel.Controls.Add(this.deleteDescription);
            this.deletePanel.Controls.Add(this.deleteExpense);
            this.deletePanel.Controls.Add(this.deleteIncome);
            this.deletePanel.Controls.Add(this.label14);
            this.deletePanel.Controls.Add(this.label15);
            this.deletePanel.Controls.Add(this.label16);
            this.deletePanel.Controls.Add(this.deleteIdCmb);
            this.deletePanel.Controls.Add(this.label17);
            this.deletePanel.Controls.Add(this.deleteDateSearchBtn);
            this.deletePanel.Controls.Add(this.label18);
            this.deletePanel.Controls.Add(this.deleteCmb);
            this.deletePanel.Controls.Add(this.label19);
            this.deletePanel.Location = new System.Drawing.Point(510, 161);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(457, 400);
            this.deletePanel.TabIndex = 14;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(107, 306);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 31);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "刪除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteDescription
            // 
            this.deleteDescription.Enabled = false;
            this.deleteDescription.Location = new System.Drawing.Point(107, 212);
            this.deleteDescription.Multiline = true;
            this.deleteDescription.Name = "deleteDescription";
            this.deleteDescription.Size = new System.Drawing.Size(177, 69);
            this.deleteDescription.TabIndex = 12;
            // 
            // deleteExpense
            // 
            this.deleteExpense.Enabled = false;
            this.deleteExpense.Location = new System.Drawing.Point(108, 169);
            this.deleteExpense.Name = "deleteExpense";
            this.deleteExpense.Size = new System.Drawing.Size(100, 25);
            this.deleteExpense.TabIndex = 11;
            // 
            // deleteIncome
            // 
            this.deleteIncome.Enabled = false;
            this.deleteIncome.Location = new System.Drawing.Point(108, 129);
            this.deleteIncome.Name = "deleteIncome";
            this.deleteIncome.Size = new System.Drawing.Size(100, 25);
            this.deleteIncome.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "備註";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "支出";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "收入";
            // 
            // deleteIdCmb
            // 
            this.deleteIdCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.記簿BindingSource, "日期", true));
            this.deleteIdCmb.FormattingEnabled = true;
            this.deleteIdCmb.Location = new System.Drawing.Point(107, 92);
            this.deleteIdCmb.Name = "deleteIdCmb";
            this.deleteIdCmb.Size = new System.Drawing.Size(177, 23);
            this.deleteIdCmb.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "選擇流水號";
            // 
            // deleteDateSearchBtn
            // 
            this.deleteDateSearchBtn.Location = new System.Drawing.Point(301, 92);
            this.deleteDateSearchBtn.Name = "deleteDateSearchBtn";
            this.deleteDateSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteDateSearchBtn.TabIndex = 4;
            this.deleteDateSearchBtn.Text = "查詢";
            this.deleteDateSearchBtn.UseVisualStyleBackColor = true;
            this.deleteDateSearchBtn.Click += new System.EventHandler(this.deleteDateSearchBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "選擇日期";
            // 
            // deleteCmb
            // 
            this.deleteCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.記簿BindingSource, "日期", true));
            this.deleteCmb.FormattingEnabled = true;
            this.deleteCmb.Location = new System.Drawing.Point(108, 58);
            this.deleteCmb.Name = "deleteCmb";
            this.deleteCmb.Size = new System.Drawing.Size(177, 23);
            this.deleteCmb.TabIndex = 1;
            this.deleteCmb.TextChanged += new System.EventHandler(this.deleteCmb_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(12, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "刪除";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 633);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.toolGB);
            this.Controls.Add(this.insertPanel);
            this.Controls.Add(this.modifypanel);
            this.Controls.Add(this.deletePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "記帳本";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolGB.ResumeLayout(false);
            this.toolGB.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.記簿BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._321DataSet)).EndInit();
            this.modifypanel.ResumeLayout(false);
            this.modifypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._321DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.記簿BindingSource1)).EndInit();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton searchRdb;
        private System.Windows.Forms.RadioButton insertRdb;
        private System.Windows.Forms.RadioButton modifyRdb;
        private System.Windows.Forms.RadioButton delRdb;
        private System.Windows.Forms.GroupBox toolGB;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchDateCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 記簿BindingSource;
        private WindowsFormsApp1._321DataSet _321DataSet;
        private WindowsFormsApp1._321DataSetTableAdapters.記簿TableAdapter 記簿TableAdapter;
        private _321DataSet1 _321DataSet1;
        private System.Windows.Forms.BindingSource 記簿BindingSource1;
        private _321DataSet1TableAdapters.記簿TableAdapter 記簿TableAdapter1;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.TextBox insertDescription;
        private System.Windows.Forms.TextBox insertExpense;
        private System.Windows.Forms.TextBox insertIncome;
        private System.Windows.Forms.DateTimePicker insertDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Panel modifypanel;
        private System.Windows.Forms.Button modifyDateSearchBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox modifyCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox modifyIdCmb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.TextBox modifyDescription;
        private System.Windows.Forms.TextBox modifyExpense;
        private System.Windows.Forms.TextBox modifyIncome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox deleteDescription;
        private System.Windows.Forms.TextBox deleteExpense;
        private System.Windows.Forms.TextBox deleteIncome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox deleteIdCmb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button deleteDateSearchBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox deleteCmb;
        private System.Windows.Forms.Label label19;
    }
}

