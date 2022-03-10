using System;
using System.Data;
using System.Windows.Forms;

namespace CustomersDataMaintain
{
    public partial class MainForm : Form
    {
        private static string _idA;
        private static string clientNoA;

        public MainForm()
        {
            InitializeComponent();
            tscbLastMonth.Text = tscbLastMonth.Items[0].ToString();
            tscbNextMonth.Text = tscbNextMonth.Items[1].ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pcb_bizDataSet.vw_CY_CheckOverdue”中。您可以根据需要移动或删除它。
            this.vw_CY_CheckOverdueTableAdapter.Fill(this.pcb_bizDataSet.vw_CY_CheckOverdue);
            tabPageM2.Parent = null;
        }

        private void MainFormShow()
        {
            tstxtCustNo.Text = CustQueryForm.txtCustNo;
            tstxtCustName.Text = CustQueryForm.txtCustName;
            clientNoA = CustQueryForm.clientNoA;
        }

        private void TextClear()
        {
            tstxtCustNo.Clear();
            tstxtCustName.Clear();
            tstxtSaleMan.Clear();
            tstxtSaleRepresent.Clear();
            tstxtCurreny.Clear();
            tstxtPaymentTerm.Clear();
            tstxtPaymentDays.Clear();
            tstxtLastDay.Clear();
            tstxtNextDay.Clear();
            tstxtCheckday.Clear();
            txtMemo.Clear();
            tstxtDeliverydays.Clear();
            tscbLastMonth.Text = tscbLastMonth.Items[0].ToString();
            tscbNextMonth.Text = tscbNextMonth.Items[1].ToString();
        }

        private void PageNewType()
        {
            if (menuItemEdit.Selected)
            {
                tabPageM2.Text = "修改";
                btnInsertTab2.Visible = false;
                btnEditTab2.Visible = true;
            }
            else
            {
                tabPageM2.Text = "新增";
                btnInsertTab2.Visible = true;
                btnEditTab2.Visible = false;
                TextClear();
            }
        }
        private void tabPageNew()
        {
            tabMain.SelectedTab = tabPageM2;
            tabPageM2.Parent = tabMain;
            PageNewType();
        }

        private void RefreshMain()
        {
            tstxtMainSearch.Clear();
            vwCYCheckOverdueBindingSource.DataSource = pcb_bizDataSet.vw_CY_CheckOverdue;
            tstxtMainSearch.Focus();
        }

        private void SearchMain(string txtSearhMainSearch)
        {
            vwCYCheckOverdueBindingSource.DataSource = vw_CY_CheckOverdueTableAdapter.Get_vw_CY_CheckOverdue_search(txtSearhMainSearch);
        }

        private void tSbtnSearchMain_Click(object sender, EventArgs e)
        {
            SearchMain(tstxtMainSearch.Text);
        }

        private void btnrRefreshMain_Click(object sender, EventArgs e)
        {
            RefreshMain();
        }

        private void tsbtnCustomSearch_Click(object sender, EventArgs e)
        {
            CustQueryForm custQueryForm = new CustQueryForm();
            custQueryForm.ShowDialog();
            custQueryForm.Owner = this;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tabPageNew();
        }

        private void ctxtmenus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataTable cY_CheckOverdueTable = new DataTable();
            string id = dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[12].Value.ToString();
            string clientNoa = dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[0].Value.ToString();
            cY_CheckOverdueTable = cY_CheckOverdueTableAdapter1.CY_CheckOverdue_get(clientNoa, id);
            _idA = id;
            clientNoA = clientNoa;

            string clientNo = dgvMain.Rows[dgvMain.CurrentRow.Index].Cells[1].Value.ToString();
            string custName = cY_CheckOverdueTable.Rows[0].ItemArray[4].ToString();
            string saleman = cY_CheckOverdueTable.Rows[0].ItemArray[2].ToString();
            string saleRepresent = cY_CheckOverdueTable.Rows[0].ItemArray[3].ToString();
            string curreny = cY_CheckOverdueTable.Rows[0].ItemArray[5].ToString();
            string paymentTerm = cY_CheckOverdueTable.Rows[0].ItemArray[6].ToString();
            string paymentDays = cY_CheckOverdueTable.Rows[0].ItemArray[7].ToString();
            string lastmonth = cY_CheckOverdueTable.Rows[0].ItemArray[8].ToString();
            string lastday = cY_CheckOverdueTable.Rows[0].ItemArray[9].ToString();
            string nextmonth = cY_CheckOverdueTable.Rows[0].ItemArray[10].ToString();
            string nextday = cY_CheckOverdueTable.Rows[0].ItemArray[11].ToString();
            string checkday = cY_CheckOverdueTable.Rows[0].ItemArray[12].ToString();
            string memo = cY_CheckOverdueTable.Rows[0].ItemArray[13].ToString();
            string deliverydays = cY_CheckOverdueTable.Rows[0].ItemArray[14].ToString();


            if (menuItemNew.Selected)
            {
                tabPageNew();
            }
            else if (menuItemEdit.Selected)
            {
                tabPageNew();
                tstxtCustNo.Text = clientNo;
                tstxtCustName.Text = custName;
                tstxtSaleMan.Text = saleman;
                tstxtSaleRepresent.Text = saleRepresent;
                tstxtCurreny.Text = curreny;
                tstxtPaymentTerm.Text = paymentTerm;
                tstxtPaymentDays.Text = paymentDays;
                tscbLastMonth.Text = lastmonth;
                tstxtLastDay.Text = lastday;
                tscbNextMonth.Text = nextmonth;
                tstxtNextDay.Text = nextday;
                tstxtCheckday.Text = checkday;
                txtMemo.Text = memo;
                tstxtDeliverydays.Text = deliverydays;
            }
            else if (menuItemDelete.Selected)
            {
                if (MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    cY_CheckOverdueTableAdapter1.CY_CheckOverdue_Delete(id);
                    RefreshMain();
                }
                else
                {
                    return;
                }
            }
            else if (menuItemRefresh.Selected)
            {
                RefreshMain();
            }
            else
            {
                return;
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            tstxtMainSearch.Focus();
            MainFormShow();
        }

        private void btnInsertTab2_Click(object sender, EventArgs e)
        {
            if (vw_CY_CheckOverdueTableAdapter.vw_CY_CheckOverdue_have(clientNoA).ToString() != "0" || clientNoA == null)
            {
                MessageBox.Show("该用户已存在或没有输入客户,请重新输入", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (MessageBox.Show("确定新增吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    queriesTableAdapter1.CY_CheckOverdue_edit("1", "", clientNoA, tstxtSaleMan.Text, tstxtSaleRepresent.Text, tstxtCurreny.Text, tstxtPaymentTerm.Text, tstxtPaymentDays.Text, tscbLastMonth.Text
                    , tstxtLastDay.Text, tscbNextMonth.Text, tstxtNextDay.Text, tstxtCheckday.Text, txtMemo.Text, tstxtDeliverydays.Text);
                    tabPageM2.Parent = null;
                    RefreshMain();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEditTab2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定修改吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                queriesTableAdapter1.CY_CheckOverdue_edit("2", _idA, clientNoA, tstxtSaleMan.Text, tstxtSaleRepresent.Text, tstxtCurreny.Text, tstxtPaymentTerm.Text, tstxtPaymentDays.Text, tscbLastMonth.Text
                , tstxtLastDay.Text, tscbNextMonth.Text, tstxtNextDay.Text, tstxtCheckday.Text, txtMemo.Text, tstxtDeliverydays.Text);
                tabPageM2.Parent = null;
                RefreshMain();
            }
            else
            {
                return;
            }
        }

        private void tstxtMainSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchMain(tstxtMainSearch.Text);
            }
        }
    }
}
