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
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank1._1
{
    public partial class frmCurrencies : frmDesigne
    {
        DataTable dataTable;

        public frmCurrencies()
        {
            InitializeComponent();

            dataGridView1.DataSource = clsCurrencies.GetAllCurrencies();

            dataTable = clsCurrencies.GetAllCurrenciesNames();

            txtFrom.TextChanged += txtFrom_TextChanged_1;

            txtTo.TextChanged += txtTo_TextChanged;

            



        }

        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            
            _ShowCurrenciesList();
        }

        private void _RefreshCurrenciesList()
        {
            dataGridView1.DataSource = clsCurrencies.GetAllCurrencies();
            dataTable = clsCurrencies.GetAllCurrenciesNames();

        }

        private void _ShowCalculator()
        {
            _HideUpdateRate();
            _HideCurrenciesList();
            _ClearUpdate();

            lblAmount.Visible = true;
            lblFrom.Visible = true;
            lblTo.Visible = true;

            txtAmount.Visible = true;
            txtFrom.Visible = true;
            txtTo.Visible = true;

            lblComment1.Visible = true;
            lblComment2.Visible = true;
            lblComment3.Visible = true;
            lblResult.Visible = true;

            pcbResultLine.Visible = true;

            pcbArows.Visible = true;
        }

        private void _HideCalaculator()
        {
            lblAmount.Visible = false;
            lblFrom.Visible = false;
            lblTo.Visible = false;

            txtAmount.Visible = false;
            txtFrom.Visible = false;
            txtTo.Visible = false;

            lblComment1.Visible = false;
            lblComment2.Visible = false;
            lblComment3.Visible = false;
            lblResult.Visible = false;

            pcbResultLine.Visible = false;

            pcbArows.Visible = false;
        }

        private void _ShowCurrenciesList()
        {
            _HideUpdateRate();
            _HideCalaculator();
            _RefreshCurrenciesList();
            _ClearCalculator();
            _ClearUpdate();


            dataGridView1.Visible = true;

            lblFindCode.Visible = true;
            lblFindCountry.Visible = true;
            lblFindName.Visible = true;

            txtSearchCode.Visible = true;
            txtSearchCountry.Visible = true;
            txtSearchName.Visible = true;

            pcbSearchCodeLine.Visible = true;
            pcbSearchCountrLine.Visible = true;
            pcbSearchNameLine.Visible = true;


            pcbFindCode.Visible = true;
            pcbFindName.Visible = true;
            pcbFindCountry.Visible = true;


            lblRate.Visible = true;
            lblRate1.Visible = true;
            lblCode.Visible = true;
            lblICode1.Visible = true;
            lblCountry.Visible = true;
            lblCountry1.Visible = true;
            lblName.Visible = true;
            lblName1.Visible = true;

            pcbRateLine.Visible = true;
            pcbCodeLine.Visible = true;
            pcbCountryLine.Visible = true;
            pcbNameLine.Visible = true;
        }

        private void _HideCurrenciesList()
        {

            dataGridView1.Visible = false;

            lblFindCode.Visible = false;
            lblFindCountry.Visible = false;
            lblFindName.Visible = false;

            txtSearchCode.Visible = false;
            txtSearchCountry.Visible = false;
            txtSearchName.Visible = false;

            pcbFindCode.Visible = false;
            pcbFindName.Visible = false;
            pcbFindCountry.Visible = false;

            pcbSearchCodeLine.Visible = false;
            pcbSearchCountrLine.Visible = false;
            pcbSearchNameLine.Visible = false;

            lblRate.Visible = false;
            lblRate1.Visible = false;
            lblCode.Visible = false;
            lblICode1.Visible = false;
            lblCountry.Visible = false;
            lblCountry1.Visible = false;
            lblName.Visible = false;
            lblName1.Visible = false;

            pcbRateLine.Visible = false;
            pcbCodeLine.Visible = false;
            pcbCountryLine.Visible = false;
            pcbNameLine.Visible = false;

        }

        private void _ShowUpdateRate()
        {
            _HideCalaculator();
            _HideCurrenciesList();
            _ClearCalculator();



            lblCurrency.Visible = true;
            txtCurrency.Visible = true;
            //listBoxFrom.Visible = true;

            lblOkdRate.Visible = true;
            txtOldRate.Visible = true;
            pcbOldRateLine.Visible = true;

            lblNewRate.Visible = true;
            txtNewRate.Visible = true;

            lblRate.Visible = true;
            lblRate1.Visible = true;
            lblCode.Visible = true;
            lblICode1.Visible = true;
            lblCountry.Visible = true;
            lblCountry1.Visible = true;
            lblName.Visible = true;
            lblName1.Visible = true;

            pcbRateLine.Visible = true;
            pcbCodeLine.Visible = true;
            pcbCountryLine.Visible = true;
            pcbNameLine.Visible = true;

            lblSave.Visible = true;
            pcbSave.Visible = true;
            lblClear.Visible = true;
            pcbClear.Visible = true;
        }

        private void _HideUpdateRate()
        {


            lblCurrency.Visible = false;
            txtCurrency.Visible = false;
            //listBoxFrom.Visible = false;

            lblOkdRate.Visible = false;
            txtOldRate.Visible = false;
            pcbOldRateLine.Visible = false;

            lblNewRate.Visible = false;
            txtNewRate.Visible = false;
            

            lblRate.Visible = false;
            lblRate1.Visible = false;
            lblCode.Visible = false;
            lblICode1.Visible = false;
            lblCountry.Visible = false;
            lblCountry1.Visible = false;
            lblName.Visible = false;
            lblName1.Visible = false;

            pcbRateLine.Visible = false;
            pcbCodeLine.Visible = false;
            pcbCountryLine.Visible = false;
            pcbNameLine.Visible = false;


            lblSave.Visible = false;
            pcbSave.Visible = false;
            lblClear.Visible = false;
            pcbClear.Visible = false;
        }

        private void FilterDataGridView()
        {
            DataView dataView = clsCurrencies.GetAllCurrencies().DefaultView;

            string filterExpression = "";

            if (!string.IsNullOrEmpty(txtSearchCode.Text))
            {
                filterExpression += $"Code LIKE '%{txtSearchCode.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtSearchCountry.Text))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"CountryName LIKE '%{txtSearchCountry.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtSearchName.Text))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"CurrencyName LIKE '%{txtSearchName.Text}%'";
            }

            dataView.RowFilter = filterExpression;
            dataGridView1.DataSource = dataView;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                lblRate1.Text = selectedRow.Cells["Rate"].Value.ToString();

                lblICode1.Text = selectedRow.Cells["Code"].Value.ToString();

                lblCountry1.Text = selectedRow.Cells["CountryName"].Value.ToString();

                lblName1.Text = selectedRow.Cells["CurrencyName"].Value.ToString();
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

                    lblRate1.Text = selectedRow.Cells["Rate"].Value.ToString();

                    lblICode1.Text = selectedRow.Cells["Code"].Value.ToString();

                    lblCountry1.Text = selectedRow.Cells["CountryName"].Value.ToString();

                    lblName1.Text = selectedRow.Cells["CurrencyName"].Value.ToString();
                }
                else
                {
                    // No rows in the DataGridView
                    label1.Text = "No rows found";
                }
            }
        }

        private void txtFrom_TextChanged_1(object sender, EventArgs e)
        {
            
            //listBoxTo.Visible = false;

            string searchText = txtFrom.Text.ToLower();
            List<string> matchingRows = new List<string>();

            listBoxFrom.BringToFront();
            
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(searchText))
                    {
                        matchingRows.Add(item.ToString());
                        
                        break;
                    }
                }
            }


            listBoxFrom.Items.Clear();
            listBoxFrom.Items.AddRange(matchingRows.ToArray());
            listBoxFrom.Visible = matchingRows.Any();

                _ShowCalautorResult();
            


        }
        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            listBoxFrom.Visible = false;   
           
            string searchText = txtTo.Text.ToLower();
            List<string> matchingRows = new List<string>();

            listBoxTo.BringToFront();


            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(searchText))
                    {
                        matchingRows.Add(item.ToString());
                        break;
                    }
                }
            }

            listBoxTo.Items.Clear();
            listBoxTo.Items.AddRange(matchingRows.ToArray());
            listBoxTo.Visible = matchingRows.Any();

            _ShowCalautorResult();
        }

        private void listBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (listBoxFrom.SelectedIndex != -1)
            {
                txtFrom.Text = listBoxFrom.SelectedItem.ToString();
               // txtFrom = Controls.OfType<System.Windows.Forms.TextBox>().First();
                listBoxFrom.Visible = false;
                listBoxTo.Visible = false;
            }
        }

        private void listBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxTo.SelectedIndex != -1)
            {
                txtTo.Text = listBoxTo.SelectedItem.ToString();
                listBoxTo.Visible = false;
                listBoxFrom.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBoxFrom.Visible = false;
            listBoxTo.Visible = false;
            listBoxCurrency.Visible = false;

            _ShowCurrenciesList();
            listBoxFrom.Visible = false;
            listBoxTo.Visible = false;
            listBoxCurrency.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            listBoxFrom.Visible = false;
            listBoxTo.Visible = false;
            listBoxCurrency.Visible = false;

            _ShowCalculator();
        }

        private void _ShowCalautorResult()
        {
            if (txtFrom.Text.Length < 2)
                return;

            if (!int.TryParse(txtAmount.Text, out _))
                return;

            float Amount = (float)Convert.ToDecimal(txtAmount.Text);
            float AmountInUSD = 0;
            float Result = 0;

            if (Amount <= 0 || string.IsNullOrEmpty(txtFrom.Text)
                || string.IsNullOrEmpty(txtTo.Text))
            {
                return;
            }

            string Code1 = txtFrom.Text.Substring(0, Math.Min(4, txtFrom.Text.Length-1));
            clsCurrencies Currency1 = clsCurrencies.FindCurrencyByCode(Code1);

            Code1 = txtTo.Text.Substring(0, Math.Min(4, txtTo.Text.Length-1));
            clsCurrencies Currency2 = clsCurrencies.FindCurrencyByCode(Code1);
            
            if (Currency1 != null && Currency2 != null)
            {
                AmountInUSD = Amount / (float)Currency1.Rate;
                Result = AmountInUSD * (float)Currency2.Rate;

                lblResult.Text = Result.ToString();

                lblComment1.Text = Amount.ToString() + " " + Currency1.CurrencyCode + " =";

                lblComment3.Text = Currency2.CurrencyCode;

                lblComment2.Text = "1 USD = " + Currency1.Rate + Currency1.CurrencyCode;
            }


        }

       private void pcbArows_Click(object sender, EventArgs e)
        {
            string temp = txtTo.Text;
            txtTo.Text = txtFrom.Text;
            txtFrom.Text = temp;

            listBoxFrom.Visible = false;
            listBoxTo.Visible = false;
        }

        private void txtAmount_TextChanged_1(object sender, EventArgs e)
        {
                _ShowCalautorResult();
        }

        private void txtFrom_Enter(object sender, EventArgs e)
        {
            listBoxTo.Visible = false;
        }

        private void txtTo_Enter(object sender, EventArgs e)
        {
            listBoxFrom.Visible = false;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!frmDesigne.CheakAccessRights(clsUsers.enPermissions.pCurrencyUpdate))
                return;

            _ShowUpdateRate();
        }

        private void _ShowCurrencyInfo()
        {
            if (txtCurrency.Text.Length < 2)
                return;
            string Code1 = txtCurrency.Text.Substring(0, Math.Min(4, txtCurrency.Text.Length));
            clsCurrencies Currency1 = clsCurrencies.FindCurrencyByCode(Code1);

            if (Currency1 == null)
                return;

            lblRate1.Text = Currency1.Rate.ToString();
            txtOldRate.Text = Currency1.Rate.ToString();

            lblICode1.Text = Currency1.CurrencyCode.ToString();

            lblCountry1.Text = Currency1.CountryName.ToString();

            lblName1.Text = Currency1.CurrencyName.ToString();
        }

        private void listBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxCurrency.SelectedIndex != -1)
            {
                txtCurrency.Text = listBoxCurrency.SelectedItem.ToString();


            }
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtCurrency.Text.ToLower();
            List<string> matchingRows = new List<string>();

            listBoxCurrency.BringToFront();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(searchText))
                    {
                        matchingRows.Add(item.ToString());

                        break;
                    }
                }
            }


            listBoxCurrency.Items.Clear();
            listBoxCurrency.Items.AddRange(matchingRows.ToArray());
            listBoxCurrency.Visible = matchingRows.Any();

            _ShowCurrencyInfo();

        }

        private void listBoxCurrency_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxCurrency.Visible = false;
        }

        private void pcbSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update Rate?","Sure?"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            
            if (txtCurrency.Text.Length < 2)
            {
                MessageBox.Show("pleas inter a valid Currency", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Code1 = txtCurrency.Text.Substring(0, Math.Min(4, txtCurrency.Text.Length));
            clsCurrencies Currency1 = clsCurrencies.FindCurrencyByCode(Code1);
            if (Currency1 == null)
            {
                MessageBox.Show("pleas inter a valid Currency", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtNewRate.Text.Length <= 0 )
            {
                MessageBox.Show("pleas inter a valid New Rate", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Currency1.UpdateCurrencyRate(Convert.ToDouble(txtNewRate.Text)))
            {
                MessageBox.Show("Rate updated succeffully", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblRate1.Text = txtNewRate.Text;
                _ClearUpdate();
                listBoxCurrency.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("Sorry Update Failed", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewRate.Text = "";
                return;
            }
               
           
        }
        
        private void _ClearUpdate()
        {
            txtCurrency.Text = "";
            txtOldRate.Text = "";
            txtNewRate.Text = "";
        }

        private void _ClearCalculator()
        {
            listBoxFrom.Visible = false;
            listBoxTo.Visible = false;

            txtFrom.Text = "";
            txtTo.Text = "";
            txtAmount.Text = "";

            lblComment1.Text = "";
            lblComment2.Text = "";
            lblComment3.Text = "";
            lblResult.Text = "";
        }

        private void pcbClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Clear informations?", "Sure?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            _ClearUpdate();
        }
    }
}
