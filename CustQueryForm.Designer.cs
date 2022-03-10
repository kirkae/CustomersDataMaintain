namespace CustomersDataMaintain
{
    partial class CustQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustQueryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshCust = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtboxCust = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnCustQuery = new System.Windows.Forms.ToolStripButton();
            this.customerDgv = new System.Windows.Forms.DataGridView();
            this.client_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcb_bizDataSet = new CustomersDataMaintain.pcb_bizDataSet();
            this.customerTableAdapter = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new CustomersDataMaintain.pcb_bizDataSetTableAdapters.TableAdapterManager();
            this.tsbtnCustClear = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_bizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnRefreshCust);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnRefreshCust
            // 
            this.btnRefreshCust.Location = new System.Drawing.Point(296, 9);
            this.btnRefreshCust.Name = "btnRefreshCust";
            this.btnRefreshCust.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCust.TabIndex = 1;
            this.btnRefreshCust.TabStop = false;
            this.btnRefreshCust.Text = "刷新";
            this.btnRefreshCust.UseVisualStyleBackColor = true;
            this.btnRefreshCust.Click += new System.EventHandler(this.btnRefreshCust_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCustClear,
            this.toolStripLabel1,
            this.tstxtboxCust,
            this.tsbtnCustQuery});
            this.toolStrip1.Location = new System.Drawing.Point(22, 8);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(240, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "客户";
            // 
            // tstxtboxCust
            // 
            this.tstxtboxCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtboxCust.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtboxCust.Name = "tstxtboxCust";
            this.tstxtboxCust.Size = new System.Drawing.Size(100, 25);
            this.tstxtboxCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtboxCust_KeyDown);
            // 
            // tsbtnCustQuery
            // 
            this.tsbtnCustQuery.AutoToolTip = false;
            this.tsbtnCustQuery.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnCustQuery.Checked = true;
            this.tsbtnCustQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnCustQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCustQuery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnCustQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCustQuery.Image")));
            this.tsbtnCustQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCustQuery.Name = "tsbtnCustQuery";
            this.tsbtnCustQuery.Size = new System.Drawing.Size(36, 22);
            this.tsbtnCustQuery.Text = "搜索";
            this.tsbtnCustQuery.Click += new System.EventHandler(this.tsbtnCustQuery_Click);
            // 
            // customerDgv
            // 
            this.customerDgv.AllowUserToAddRows = false;
            this.customerDgv.AllowUserToDeleteRows = false;
            this.customerDgv.AutoGenerateColumns = false;
            this.customerDgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.customerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client_no,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.customerDgv.DataSource = this.customerBindingSource;
            this.customerDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDgv.Location = new System.Drawing.Point(0, 40);
            this.customerDgv.MultiSelect = false;
            this.customerDgv.Name = "customerDgv";
            this.customerDgv.ReadOnly = true;
            this.customerDgv.RowTemplate.Height = 23;
            this.customerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDgv.Size = new System.Drawing.Size(588, 346);
            this.customerDgv.TabIndex = 2;
            this.customerDgv.TabStop = false;
            this.customerDgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDgv_CellMouseDoubleClick);
            // 
            // client_no
            // 
            this.client_no.DataPropertyName = "client_no";
            this.client_no.HeaderText = "client_no";
            this.client_no.Name = "client_no";
            this.client_no.ReadOnly = true;
            this.client_no.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "doccode_no";
            this.dataGridViewTextBoxColumn2.HeaderText = "客户代码";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cust_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "客户名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.pcb_bizDataSet;
            // 
            // pcb_bizDataSet
            // 
            this.pcb_bizDataSet.DataSetName = "pcb_bizDataSet";
            this.pcb_bizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CY_CheckOverdueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CustomersDataMaintain.pcb_bizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tsbtnCustClear
            // 
            this.tsbtnCustClear.AutoToolTip = false;
            this.tsbtnCustClear.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnCustClear.Checked = true;
            this.tsbtnCustClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnCustClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCustClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCustClear.Image")));
            this.tsbtnCustClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCustClear.Name = "tsbtnCustClear";
            this.tsbtnCustClear.Size = new System.Drawing.Size(36, 22);
            this.tsbtnCustClear.Text = "清除";
            this.tsbtnCustClear.Click += new System.EventHandler(this.tsbtnCustClear_Click);
            // 
            // CustQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(588, 386);
            this.Controls.Add(this.customerDgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustQueryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客户查询";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustQueryForm_Load);
            this.Shown += new System.EventHandler(this.CustQueryForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_bizDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private pcb_bizDataSet pcb_bizDataSet;
        private pcb_bizDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private pcb_bizDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView customerDgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtboxCust;
        private System.Windows.Forms.ToolStripButton tsbtnCustQuery;
        private System.Windows.Forms.Button btnRefreshCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton tsbtnCustClear;
    }
}