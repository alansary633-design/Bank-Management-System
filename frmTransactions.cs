using BusinessBank1;
using clsBusinessBank1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank1._1
{
    public partial class frmTransactions : frmDesigne 
    {
        public frmTransactions()
        {
            InitializeComponent();
            
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        clsClients CurrentCleint = new clsClients();

        enum enMode { Deposit =1,Withdraw =2 ,Transfers=3 };
        enMode Mode ;
        private void frmTransactions_Load(object sender, EventArgs e)
        {
            frmDesigne.CheakAccessRights(clsUsers.enPermissions.pTranactions);
            _ShowTotalBalances();
            
        }

        private void _UpdateClientInfo(int rowIndex)
        {
            
            
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                lblID1.Text = selectedRow.Cells[2].Value.ToString();

                lblClientName1.Text = selectedRow.Cells[1].Value.ToString();

                lblBalance1.Text = selectedRow.Cells[3].Value.ToString();

            }
            else
            {
                // No row is currently selected, set a default selection
                if (dataGridView1.Rows.Count > 0)
                {
                    // Select the first row by default
                    dataGridView1.Rows[0].Selected = true;

                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.Rows[0];

                    lblID1.Text = selectedRow.Cells[0].Value.ToString();

                    lblClientName1.Text = selectedRow.Cells[1].Value.ToString();

                    lblBalance1.Text = selectedRow.Cells[3].Value.ToString();

                    dataGridView1.ClearSelection();


                    dataGridView1.Rows[rowIndex].Selected = true;

                }
                else
                {
                    // No rows in the DataGridView
                    label1.Text = "No rows found";
                }

            }
        }


        private void _ShowTotalBalances()
        {
            _RefreshTotalBlances();
            _ClearTransfers();
            _ClearDeposit();
            _HideDeposit();
            _HideTransfers();
            dataGridView1.Visible = true;
            txtSearch.Visible = true;
            pcbFind.Visible = true;
            pcbSearchLine.Visible = true;
        }

        private void _RefreshTotalBlances()
        {
            
            dataGridView1.DataSource = clsClients.GetTotlaBalances();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            

        }

        private void _HideTotalBalances()
        {
            dataGridView1.Visible = false;
            txtSearch.Visible = false;
            pcbFind.Visible = false;
            pcbSearchLine.Visible = false;
        }

        private void _ShwDeposit()
        {
            _HideTransfers();
            _HideTotalBalances();
            numericUpDown1.Focus();
            lblDepositAmont.Text = "Deposit Amount : ";
            lblDepositAmont.Visible = true;
            numericUpDown1.Visible = true;

            pcbSave.Visible = true;
            pcbCancel.Visible = true;

            lblSave.Visible = true ;
            lblCancel.Visible = true ;
        }

        private void _HideDeposit()
        {
            lblDepositAmont.Visible = false;
            numericUpDown1.Visible = false;
            

            pcbSave.Visible = false;
            pcbCancel.Visible = false;

            lblSave.Visible = false;
            lblCancel.Visible = false;
        }

        //private void _ShowClientInformations()
        //{
        //    lblID.Visible = true;
        //    lblID.Visible = true;
        //    lblBalance.Visible = true;

        //    lblID1.Visible = true;
        //    lblID1.Visible = true;
        //    lblBalance1.Visible = true;

        //    pcbClientIDLine.Visible = true;
        //    pcbClientNameLine.Visible = true;
        //    pcbBalanceLine.Visible = true;
        //}

       private void _ShowWithdraw()
        {
            _ShwDeposit();
            _HideTotalBalances();
           
            lblDepositAmont.Text = "Withdraw Amount : ";
        }

        private void _ShowTransfers()
        {
            _HideDeposit();
            _HideTotalBalances();
            
            txtReceiverACCT.Focus();
            lblReceiverACCT.Visible = true;
            lblTransferAmont.Visible = true;

            txtReceiverACCT.Visible = true;
            numericUpDown1.Visible = true;

            pcbReceiverACCTLine.Visible = true;

            pcbSave.Visible = true;
            pcbCancel.Visible = true;

            lblSave.Visible = true;
            lblCancel.Visible = true;
            

        }

        private void _HideTransfers()
        {
            lblReceiverACCT.Visible = false;
            lblTransferAmont.Visible = false;

            txtReceiverACCT.Visible = false;
            numericUpDown1.Visible = false;

            pcbReceiverACCTLine.Visible = false;

            pcbSave.Visible = false;
            pcbCancel.Visible = false;

            lblSave.Visible = false;
            lblCancel.Visible = false;
        }

        private void _ClearDeposit()
        {
            numericUpDown1.Value= 0;
        }

        private void _ClearTransfers()
        {
            txtReceiverACCT.Text = "";
            numericUpDown1.Text = "";
        }

        private bool IsTransfersClear()
        {
            return (string.IsNullOrEmpty(lblReceiverACCT.Text) &&
                string.IsNullOrEmpty(lblTransferAmont.Text));
        }

        private bool IsDepositClear()
        {
            return (numericUpDown1.Value == 0);
        }

        private void lblTransferLog_Click(object sender, EventArgs e)
        {

        }


        private void _Deposit()
        {
            CurrentCleint= clsClients.FindClient
                ((int)dataGridView1.CurrentRow.Cells[0].Value);
            
            

            if (IsDepositClear())
            {
                MessageBox.Show("Pleas inter Amount to Deposit","inter Amount",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            
            CurrentCleint.Blalance += numericUpDown1.Value;
            
            if (MessageBox.Show("Are you sure you want to perform this transaction?",
           "Sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CurrentCleint.SaveClient())
                {
                    MessageBox.Show("Amount Deposited Successfully.", "Deposited"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);


                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    _UpdateClientInfo(rowIndex);
                    _ShowTotalBalances();

                }
                else
                {
                    MessageBox.Show("Operation was cancelled.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _Withdraw()
        {
            CurrentCleint = clsClients.FindClient
                ((int)dataGridView1.CurrentRow.Cells[0].Value);

            //CurrentCleint.ModeClient = clsClients.enMode.Update;

            if (IsDepositClear())
            {
                MessageBox.Show("Pleas inter Amount to Withdraw", "inter Amount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDown1.Value > CurrentCleint.Blalance)
            {
                MessageBox.Show("The amount exceeds balance ,Pleas inter valid a amount"
                    , "invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CurrentCleint.Blalance -= numericUpDown1.Value;

            if (MessageBox.Show("Are you sure you want to perform this transaction?",
           "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CurrentCleint.SaveClient())
                {
                    MessageBox.Show("Amount Withdrawed Successfully.", "Withdrawed"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    _UpdateClientInfo(rowIndex);
                    _ShowTotalBalances();
                }
                else
                {
                    MessageBox.Show("Operation was cancelled.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _Transfers()
        {
            CurrentCleint = clsClients.FindClient
               ((int)dataGridView1.CurrentRow.Cells[0].Value);


            //CurrentCleint.ModeClient = clsClients.enMode.Update;
            clsClients Receiver = clsClients.FindClient(txtReceiverACCT.Text);
            
            if (IsTransfersClear())
            {
                MessageBox.Show("Pleas inter All informations", "inter informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtReceiverACCT.Text == CurrentCleint.AccountNumber 
                || Receiver == null)
            {
                MessageBox.Show("Pleas inter a valid Account Number", "wrong informations",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiverACCT.Text = "";
                return;
            }

            if (numericUpDown1.Value > CurrentCleint.Blalance)
            {
                MessageBox.Show("The amount exceeds balance ,Pleas inter valid a amount"
                    , "invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Value = 0;
                return;
            
            }
            
            CurrentCleint.Blalance -= numericUpDown1.Value;
            Receiver.Blalance += numericUpDown1.Value;

            if (MessageBox.Show("Are you sure you want to perform this transaction?",
           "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CurrentCleint.SaveClient() && Receiver.SaveClient())
                {
                    MessageBox.Show("Transfer done successfully.", "done"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int transferID = -1;
                    CurrentCleint.RegisterTransferLog(ref transferID, numericUpDown1.Value,
                        Receiver.ClientID, clsUsers.CurrentUser.UserID);

                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    _UpdateClientInfo(rowIndex);
                    _ShowTotalBalances();
                }
                else
                {
                    MessageBox.Show("Operation was cancelled.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();
            string columnName = "FullName";
            DataView dataView = clsClients.GetTotlaBalances().DefaultView;
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, searchValue);
            dataGridView1.DataSource = dataView;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                lblID1.Text = selectedRow.Cells[2].Value.ToString();

                lblClientName1.Text = selectedRow.Cells[1].Value.ToString();

                lblBalance1.Text = selectedRow.Cells[3].Value.ToString();

            }
            else
            {
                // No row is currently selected, set a default selection
                if (dataGridView1.Rows.Count > 0)
                {
                    // Select the first row by default
                    dataGridView1.Rows[0].Selected = true;

                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.Rows[0];

                    lblID1.Text = selectedRow.Cells[0].Value.ToString();

                    lblClientName1.Text = selectedRow.Cells[1].Value.ToString();

                    lblBalance1.Text = selectedRow.Cells[3].Value.ToString();
                }
                else
                {
                    // No rows in the DataGridView
                    label1.Text = "No rows found";
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mode = enMode.Deposit;
            
            _ShwDeposit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _ShowTotalBalances();
            
        }

        private void pcbWithdraw_Click(object sender, EventArgs e)
        {
            Mode = enMode.Withdraw;
            
            _ShowWithdraw();
        }

        private void pcbDeposit_Click(object sender, EventArgs e)
        {
            Mode = enMode.Transfers;
            
            _ShowTransfers();
        }

        private void pcbCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you eant to cancel ?", "Sure?", MessageBoxButtons.YesNo
                , MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _ShowTotalBalances();

            }
            else
                return;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            pcbSave_Click(sender,e);
        }

        private void pcbSave_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case enMode.Deposit:
                    {
                        _Deposit();

                        return;
                    }
                case enMode.Withdraw:

                    {
                        _Withdraw();
                        return;
                    }
                case enMode.Transfers:

                    {
                        _Transfers();
                        return;

                    }

            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            pcbCancel_Click(sender, e);
        }

        private void pcbTransferLog_Click(object sender, EventArgs e)
        {
            frmTransfersLog frmTransfersLog = new frmTransfersLog();
            frmTransfersLog.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pcbWithdraw_MouseEnter(object sender, EventArgs e)
        {
            pcbWithdraw.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbWithdraw_MouseLeave(object sender, EventArgs e)
        {
            pcbWithdraw.BorderStyle = BorderStyle.None;
        }

        private void pcbDeposit_MouseEnter(object sender, EventArgs e)
        {
            pcbDeposit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbDeposit_MouseLeave(object sender, EventArgs e)
        {
            pcbDeposit.BorderStyle = BorderStyle.None;
        }

        private void pcbTransferLog_MouseEnter(object sender, EventArgs e)
        {
            pcbTransferLog.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbTransferLog_MouseLeave(object sender, EventArgs e)
        {
            pcbTransferLog.BorderStyle = BorderStyle.None;

        }
    }

}
