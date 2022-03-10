using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersDataMaintain
{
    public partial class CustQueryForm : Form
    {
        public CustQueryForm()
        {
            InitializeComponent();
        }

        protected internal static string txtCustNo;
        protected internal static string txtCustName;
        protected internal static string clientNoA;

        private void CustQueryForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pcb_bizDataSet.customer”中。您可以根据需要移动或删除它。
            this.customerTableAdapter.Fill(this.pcb_bizDataSet.customer);
        }

        private void RefreshCust()
        {
            tstxtboxCust.Clear();
            customerBindingSource.DataSource = pcb_bizDataSet.customer;
            tstxtboxCust.Focus();
        }

        private void CustQuery(string txtCustQuery)
        {
            customerBindingSource.DataSource = customerTableAdapter.Get_custQuery(txtCustQuery);
        }

        private void tsbtnCustQuery_Click(object sender, EventArgs e)
        {
            CustQuery(tstxtboxCust.Text);
        }

        private void btnRefreshCust_Click(object sender, EventArgs e)
        {
            RefreshCust();
        }

        private void tstxtboxCust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CustQuery(tstxtboxCust.Text);
            }
        }

        private void CustQueryForm_Shown(object sender, EventArgs e)
        {
            tstxtboxCust.Focus();
        }

        private void customerDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //customerDgv.DataSource = pcb_bizDataSet.customer;

            clientNoA = customerDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustNo = customerDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustName = customerDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Activate();
        }

        private void tsbtnCustClear_Click(object sender, EventArgs e)
        {
            clientNoA = string.Empty;
            txtCustNo = string.Empty;
            txtCustName = string.Empty;
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Activate();
        }
    }
}
