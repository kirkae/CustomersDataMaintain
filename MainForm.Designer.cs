namespace CustomersDataMaintain
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ctxtmenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tabPageM1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip13 = new System.Windows.Forms.ToolStrip();
            this.tstxtMainSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tSbtnSearchMain = new System.Windows.Forms.ToolStripButton();
            this.btnrRefreshMain = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.client_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCYCheckOverdueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcb_bizDataSet = new CustomersDataMaintain.pcb_bizDataSet();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageM2 = new System.Windows.Forms.TabPage();
            this.btnInsertTab2 = new System.Windows.Forms.Button();
            this.btnEditTab2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMemo = new System.Windows.Forms.RichTextBox();
            this.toolStrip12 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel14 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtDeliverydays = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel15 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip11 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtCheckday = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip10 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.tscbNextMonth = new System.Windows.Forms.ToolStripComboBox();
            this.tstxtNextDay = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip9 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tscbLastMonth = new System.Windows.Forms.ToolStripComboBox();
            this.tstxtLastDay = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtPaymentDays = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtPaymentTerm = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtCurreny = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSaleRepresent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSaleMan = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel16 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtCustName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtCustNo = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnCustomSearch = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.TableAdapterManager();
            this.vw_CY_CheckOverdueTableAdapter = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.vw_CY_CheckOverdueTableAdapter();
            this.queriesTableAdapter1 = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.QueriesTableAdapter();
            this.cY_CheckOverdueTableAdapter1 = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.CY_CheckOverdueTableAdapter();
            this.ctxtmenus.SuspendLayout();
            this.tabPageM1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCYCheckOverdueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_bizDataSet)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageM2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip12.SuspendLayout();
            this.toolStrip11.SuspendLayout();
            this.toolStrip10.SuspendLayout();
            this.toolStrip9.SuspendLayout();
            this.toolStrip8.SuspendLayout();
            this.toolStrip7.SuspendLayout();
            this.toolStrip6.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxtmenus
            // 
            this.ctxtmenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemEdit,
            this.menuItemDelete,
            this.menuItemRefresh});
            this.ctxtmenus.Name = "contextMenuStrip1";
            this.ctxtmenus.ShowImageMargin = false;
            this.ctxtmenus.Size = new System.Drawing.Size(76, 92);
            this.ctxtmenus.Text = "刷新";
            this.ctxtmenus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxtmenus_ItemClicked);
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(75, 22);
            this.menuItemNew.Text = "新增";
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(75, 22);
            this.menuItemEdit.Text = "修改";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(75, 22);
            this.menuItemDelete.Text = "删除";
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Name = "menuItemRefresh";
            this.menuItemRefresh.Size = new System.Drawing.Size(75, 22);
            this.menuItemRefresh.Text = "刷新";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(339, 150);
            // 
            // tabPageM1
            // 
            this.tabPageM1.Controls.Add(this.panel1);
            this.tabPageM1.Controls.Add(this.dgvMain);
            this.tabPageM1.Location = new System.Drawing.Point(4, 22);
            this.tabPageM1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageM1.Name = "tabPageM1";
            this.tabPageM1.Size = new System.Drawing.Size(939, 480);
            this.tabPageM1.TabIndex = 0;
            this.tabPageM1.Text = "主页";
            this.tabPageM1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip13);
            this.panel1.Controls.Add(this.btnrRefreshMain);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 49);
            this.panel1.TabIndex = 6;
            // 
            // toolStrip13
            // 
            this.toolStrip13.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip13.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip13.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtMainSearch,
            this.tSbtnSearchMain});
            this.toolStrip13.Location = new System.Drawing.Point(52, 12);
            this.toolStrip13.Name = "toolStrip13";
            this.toolStrip13.Size = new System.Drawing.Size(141, 25);
            this.toolStrip13.TabIndex = 0;
            this.toolStrip13.TabStop = true;
            this.toolStrip13.Text = "toolStrip13";
            // 
            // tstxtMainSearch
            // 
            this.tstxtMainSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtMainSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtMainSearch.Name = "tstxtMainSearch";
            this.tstxtMainSearch.Size = new System.Drawing.Size(100, 25);
            this.tstxtMainSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtMainSearch_KeyUp);
            // 
            // tSbtnSearchMain
            // 
            this.tSbtnSearchMain.AutoToolTip = false;
            this.tSbtnSearchMain.Checked = true;
            this.tSbtnSearchMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSbtnSearchMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSbtnSearchMain.Image = ((System.Drawing.Image)(resources.GetObject("tSbtnSearchMain.Image")));
            this.tSbtnSearchMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtnSearchMain.Name = "tSbtnSearchMain";
            this.tSbtnSearchMain.Size = new System.Drawing.Size(36, 22);
            this.tSbtnSearchMain.Text = "搜索";
            this.tSbtnSearchMain.Click += new System.EventHandler(this.tSbtnSearchMain_Click);
            // 
            // btnrRefreshMain
            // 
            this.btnrRefreshMain.Location = new System.Drawing.Point(389, 13);
            this.btnrRefreshMain.Name = "btnrRefreshMain";
            this.btnrRefreshMain.Size = new System.Drawing.Size(75, 23);
            this.btnrRefreshMain.TabIndex = 5;
            this.btnrRefreshMain.TabStop = false;
            this.btnrRefreshMain.Text = "刷新";
            this.btnrRefreshMain.UseVisualStyleBackColor = true;
            this.btnrRefreshMain.Click += new System.EventHandler(this.btnrRefreshMain_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(254, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.TabStop = false;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client_no,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this._id});
            this.dgvMain.ContextMenuStrip = this.ctxtmenus;
            this.dgvMain.DataSource = this.vwCYCheckOverdueBindingSource;
            this.dgvMain.Location = new System.Drawing.Point(0, 49);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(939, 431);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.TabStop = false;
            // 
            // client_no
            // 
            this.client_no.DataPropertyName = "client_no";
            this.client_no.HeaderText = "client_no";
            this.client_no.Name = "client_no";
            this.client_no.ReadOnly = true;
            this.client_no.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "doccode_no";
            this.dataGridViewTextBoxColumn1.HeaderText = "客户代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "salesman";
            this.dataGridViewTextBoxColumn2.HeaderText = "业务";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sale_represent";
            this.dataGridViewTextBoxColumn3.HeaderText = "销售代表";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cust_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "客户名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "currency";
            this.dataGridViewTextBoxColumn5.HeaderText = "币种";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "payment_terms";
            this.dataGridViewTextBoxColumn6.HeaderText = "付款条件";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 78;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "net_payment_days";
            this.dataGridViewTextBoxColumn7.HeaderText = "净付款天数";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "checkperiod";
            this.dataGridViewTextBoxColumn8.HeaderText = "对账区间";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "checkday";
            this.dataGridViewTextBoxColumn9.HeaderText = "对账日";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "memo";
            this.dataGridViewTextBoxColumn10.HeaderText = "备注";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 54;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "deliverydays";
            this.dataGridViewTextBoxColumn11.HeaderText = "送货天数";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // _id
            // 
            this._id.DataPropertyName = "_id";
            this._id.HeaderText = "_id";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Visible = false;
            // 
            // vwCYCheckOverdueBindingSource
            // 
            this.vwCYCheckOverdueBindingSource.DataMember = "vw_CY_CheckOverdue";
            this.vwCYCheckOverdueBindingSource.DataSource = this.pcb_bizDataSet;
            // 
            // pcb_bizDataSet
            // 
            this.pcb_bizDataSet.DataSetName = "pcb_bizDataSet";
            this.pcb_bizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageM1);
            this.tabMain.Controls.Add(this.tabPageM2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(947, 506);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabStop = false;
            // 
            // tabPageM2
            // 
            this.tabPageM2.Controls.Add(this.btnInsertTab2);
            this.tabPageM2.Controls.Add(this.btnEditTab2);
            this.tabPageM2.Controls.Add(this.groupBox1);
            this.tabPageM2.Controls.Add(this.toolStrip12);
            this.tabPageM2.Controls.Add(this.toolStrip11);
            this.tabPageM2.Controls.Add(this.toolStrip10);
            this.tabPageM2.Controls.Add(this.toolStrip9);
            this.tabPageM2.Controls.Add(this.toolStrip8);
            this.tabPageM2.Controls.Add(this.toolStrip7);
            this.tabPageM2.Controls.Add(this.toolStrip6);
            this.tabPageM2.Controls.Add(this.toolStrip5);
            this.tabPageM2.Controls.Add(this.toolStrip4);
            this.tabPageM2.Controls.Add(this.toolStrip3);
            this.tabPageM2.Controls.Add(this.toolStrip2);
            this.tabPageM2.Location = new System.Drawing.Point(4, 22);
            this.tabPageM2.Name = "tabPageM2";
            this.tabPageM2.Size = new System.Drawing.Size(939, 480);
            this.tabPageM2.TabIndex = 0;
            this.tabPageM2.Text = "修改";
            this.tabPageM2.UseVisualStyleBackColor = true;
            // 
            // btnInsertTab2
            // 
            this.btnInsertTab2.Location = new System.Drawing.Point(673, 407);
            this.btnInsertTab2.Name = "btnInsertTab2";
            this.btnInsertTab2.Size = new System.Drawing.Size(75, 23);
            this.btnInsertTab2.TabIndex = 13;
            this.btnInsertTab2.TabStop = false;
            this.btnInsertTab2.Text = "新增";
            this.btnInsertTab2.UseVisualStyleBackColor = true;
            this.btnInsertTab2.Click += new System.EventHandler(this.btnInsertTab2_Click);
            // 
            // btnEditTab2
            // 
            this.btnEditTab2.Location = new System.Drawing.Point(673, 407);
            this.btnEditTab2.Name = "btnEditTab2";
            this.btnEditTab2.Size = new System.Drawing.Size(75, 23);
            this.btnEditTab2.TabIndex = 12;
            this.btnEditTab2.TabStop = false;
            this.btnEditTab2.Text = "修改";
            this.btnEditTab2.UseVisualStyleBackColor = true;
            this.btnEditTab2.Click += new System.EventHandler(this.btnEditTab2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMemo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(419, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 140);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemo.Location = new System.Drawing.Point(3, 17);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(497, 120);
            this.txtMemo.TabIndex = 0;
            this.txtMemo.Text = "";
            // 
            // toolStrip12
            // 
            this.toolStrip12.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel14,
            this.tstxtDeliverydays,
            this.toolStripLabel15});
            this.toolStrip12.Location = new System.Drawing.Point(602, 211);
            this.toolStrip12.Name = "toolStrip12";
            this.toolStrip12.Size = new System.Drawing.Size(181, 25);
            this.toolStrip12.TabIndex = 10;
            this.toolStrip12.TabStop = true;
            this.toolStrip12.Text = "toolStrip12";
            // 
            // toolStripLabel14
            // 
            this.toolStripLabel14.Name = "toolStripLabel14";
            this.toolStripLabel14.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel14.Text = "在途天数";
            // 
            // tstxtDeliverydays
            // 
            this.tstxtDeliverydays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtDeliverydays.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtDeliverydays.Name = "tstxtDeliverydays";
            this.tstxtDeliverydays.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel15
            // 
            this.toolStripLabel15.Name = "toolStripLabel15";
            this.toolStripLabel15.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel15.Text = "天";
            // 
            // toolStrip11
            // 
            this.toolStrip11.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel12,
            this.tstxtCheckday,
            this.toolStripLabel13});
            this.toolStrip11.Location = new System.Drawing.Point(602, 160);
            this.toolStrip11.Name = "toolStrip11";
            this.toolStrip11.Size = new System.Drawing.Size(181, 25);
            this.toolStrip11.TabIndex = 9;
            this.toolStrip11.TabStop = true;
            this.toolStrip11.Text = "toolStrip11";
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel12.Text = "对账日期";
            // 
            // tstxtCheckday
            // 
            this.tstxtCheckday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtCheckday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtCheckday.Name = "tstxtCheckday";
            this.tstxtCheckday.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel13.Text = "号";
            // 
            // toolStrip10
            // 
            this.toolStrip10.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel9,
            this.tscbNextMonth,
            this.tstxtNextDay,
            this.toolStripLabel11});
            this.toolStrip10.Location = new System.Drawing.Point(515, 109);
            this.toolStrip10.Name = "toolStrip10";
            this.toolStrip10.Size = new System.Drawing.Size(268, 25);
            this.toolStrip10.TabIndex = 8;
            this.toolStrip10.TabStop = true;
            this.toolStrip10.Text = "toolStrip10";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel9.Text = "至";
            // 
            // tscbNextMonth
            // 
            this.tscbNextMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscbNextMonth.Items.AddRange(new object[] {
            "上月",
            "本月"});
            this.tscbNextMonth.Name = "tscbNextMonth";
            this.tscbNextMonth.Size = new System.Drawing.Size(121, 25);
            // 
            // tstxtNextDay
            // 
            this.tstxtNextDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtNextDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtNextDay.Name = "tstxtNextDay";
            this.tstxtNextDay.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel11.Text = "号";
            // 
            // toolStrip9
            // 
            this.toolStrip9.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.tscbLastMonth,
            this.tstxtLastDay,
            this.toolStripLabel8});
            this.toolStrip9.Location = new System.Drawing.Point(480, 58);
            this.toolStrip9.Name = "toolStrip9";
            this.toolStrip9.Size = new System.Drawing.Size(304, 25);
            this.toolStrip9.TabIndex = 7;
            this.toolStrip9.TabStop = true;
            this.toolStrip9.Text = "toolStrip9";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel7.Text = "对账区间";
            // 
            // tscbLastMonth
            // 
            this.tscbLastMonth.BackColor = System.Drawing.SystemColors.Window;
            this.tscbLastMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscbLastMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tscbLastMonth.Items.AddRange(new object[] {
            "上月",
            "本月"});
            this.tscbLastMonth.Name = "tscbLastMonth";
            this.tscbLastMonth.Size = new System.Drawing.Size(121, 25);
            // 
            // tstxtLastDay
            // 
            this.tstxtLastDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtLastDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtLastDay.Name = "tstxtLastDay";
            this.tstxtLastDay.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel8.Text = "号";
            // 
            // toolStrip8
            // 
            this.toolStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.tstxtPaymentDays});
            this.toolStrip8.Location = new System.Drawing.Point(15, 364);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Size = new System.Drawing.Size(373, 25);
            this.toolStrip8.TabIndex = 6;
            this.toolStrip8.TabStop = true;
            this.toolStrip8.Text = "toolStrip8";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel6.Text = "净付款天数";
            // 
            // tstxtPaymentDays
            // 
            this.tstxtPaymentDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtPaymentDays.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtPaymentDays.Name = "tstxtPaymentDays";
            this.tstxtPaymentDays.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.tstxtPaymentTerm});
            this.toolStrip7.Location = new System.Drawing.Point(27, 313);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(361, 25);
            this.toolStrip7.TabIndex = 5;
            this.toolStrip7.TabStop = true;
            this.toolStrip7.Text = "toolStrip7";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel5.Text = "付款方式";
            // 
            // tstxtPaymentTerm
            // 
            this.tstxtPaymentTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtPaymentTerm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtPaymentTerm.Name = "tstxtPaymentTerm";
            this.tstxtPaymentTerm.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStrip6
            // 
            this.toolStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.tstxtCurreny});
            this.toolStrip6.Location = new System.Drawing.Point(51, 262);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(337, 25);
            this.toolStrip6.TabIndex = 4;
            this.toolStrip6.TabStop = true;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "币种";
            // 
            // tstxtCurreny
            // 
            this.tstxtCurreny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtCurreny.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtCurreny.Name = "tstxtCurreny";
            this.tstxtCurreny.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tstxtSaleRepresent});
            this.toolStrip5.Location = new System.Drawing.Point(15, 211);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(373, 25);
            this.toolStrip5.TabIndex = 3;
            this.toolStrip5.TabStop = true;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel3.Text = "销售管理师";
            // 
            // tstxtSaleRepresent
            // 
            this.tstxtSaleRepresent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtSaleRepresent.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtSaleRepresent.Name = "tstxtSaleRepresent";
            this.tstxtSaleRepresent.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tstxtSaleMan});
            this.toolStrip4.Location = new System.Drawing.Point(39, 160);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(349, 25);
            this.toolStrip4.TabIndex = 2;
            this.toolStrip4.TabStop = true;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "业务员";
            // 
            // tstxtSaleMan
            // 
            this.tstxtSaleMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtSaleMan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtSaleMan.Name = "tstxtSaleMan";
            this.tstxtSaleMan.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox4,
            this.toolStripLabel16,
            this.tstxtCustName});
            this.toolStrip3.Location = new System.Drawing.Point(27, 109);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(361, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "客户名称";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel16
            // 
            this.toolStripLabel16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel16.Name = "toolStripLabel16";
            this.toolStripLabel16.Size = new System.Drawing.Size(0, 22);
            // 
            // tstxtCustName
            // 
            this.tstxtCustName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tstxtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtCustName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtCustName.Name = "tstxtCustName";
            this.tstxtCustName.ReadOnly = true;
            this.tstxtCustName.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.tstxtCustNo,
            this.tsbtnCustomSearch});
            this.toolStrip2.Location = new System.Drawing.Point(52, 58);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(404, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton1.Text = "客户";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(0, 22);
            // 
            // tstxtCustNo
            // 
            this.tstxtCustNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tstxtCustNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtCustNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtCustNo.Name = "tstxtCustNo";
            this.tstxtCustNo.ReadOnly = true;
            this.tstxtCustNo.Size = new System.Drawing.Size(300, 25);
            // 
            // tsbtnCustomSearch
            // 
            this.tsbtnCustomSearch.AutoToolTip = false;
            this.tsbtnCustomSearch.Checked = true;
            this.tsbtnCustomSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnCustomSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCustomSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCustomSearch.Image")));
            this.tsbtnCustomSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCustomSearch.Name = "tsbtnCustomSearch";
            this.tsbtnCustomSearch.Size = new System.Drawing.Size(36, 22);
            this.tsbtnCustomSearch.Text = "搜索";
            this.tsbtnCustomSearch.Click += new System.EventHandler(this.tsbtnCustomSearch_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CY_CheckOverdueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CustomersDataMaintain.pcb_bizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CY_CheckOverdueTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CustomersDataMaintain.pcb_bizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vw_CY_CheckOverdueTableAdapter
            // 
            this.vw_CY_CheckOverdueTableAdapter.ClearBeforeFill = true;
            // 
            // cY_CheckOverdueTableAdapter1
            // 
            this.cY_CheckOverdueTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(947, 506);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "逾期数据维护";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctxtmenus.ResumeLayout(false);
            this.tabPageM1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip13.ResumeLayout(false);
            this.toolStrip13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCYCheckOverdueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_bizDataSet)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageM2.ResumeLayout(false);
            this.tabPageM2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip12.ResumeLayout(false);
            this.toolStrip12.PerformLayout();
            this.toolStrip11.ResumeLayout(false);
            this.toolStrip11.PerformLayout();
            this.toolStrip10.ResumeLayout(false);
            this.toolStrip10.PerformLayout();
            this.toolStrip9.ResumeLayout(false);
            this.toolStrip9.PerformLayout();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private pcb_bizDataSet pcb_bizDataSet;
        private System.Windows.Forms.BindingSource vwCYCheckOverdueBindingSource;
        private pcb_bizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip ctxtmenus;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private pcb_bizDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabPage tabPageM1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageM2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox3;
        private System.Windows.Forms.ToolStrip toolStrip9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox tscbLastMonth;
        private System.Windows.Forms.ToolStripTextBox tstxtLastDay;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripTextBox tstxtPaymentDays;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tstxtPaymentTerm;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tstxtCurreny;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tstxtSaleRepresent;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstxtSaleMan;
        private System.Windows.Forms.ToolStrip toolStrip10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripComboBox tscbNextMonth;
        private System.Windows.Forms.ToolStripTextBox tstxtNextDay;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStrip toolStrip12;
        private System.Windows.Forms.ToolStripLabel toolStripLabel14;
        private System.Windows.Forms.ToolStripTextBox tstxtDeliverydays;
        private System.Windows.Forms.ToolStripLabel toolStripLabel15;
        private System.Windows.Forms.ToolStrip toolStrip11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripTextBox tstxtCheckday;
        private System.Windows.Forms.ToolStripLabel toolStripLabel13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtMemo;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ToolStrip toolStrip13;
        private System.Windows.Forms.ToolStripTextBox tstxtMainSearch;
        private System.Windows.Forms.ToolStripButton tSbtnSearchMain;
        private System.Windows.Forms.ToolStripButton tsbtnCustomSearch;
        public pcb_bizDataSetTableAdapters.vw_CY_CheckOverdueTableAdapter vw_CY_CheckOverdueTableAdapter;
        private System.Windows.Forms.Button btnrRefreshMain;
        private System.Windows.Forms.Button btnInsertTab2;
        private System.Windows.Forms.Button btnEditTab2;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel16;
        private System.Windows.Forms.ToolStripTextBox tstxtCustName;
        private System.Windows.Forms.ToolStripTextBox tstxtCustNo;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefresh;
        private pcb_bizDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private pcb_bizDataSetTableAdapters.CY_CheckOverdueTableAdapter cY_CheckOverdueTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
    }
}

