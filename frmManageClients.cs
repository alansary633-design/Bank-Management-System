using BusinessBank1;
using clsBusinessBank1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank1._1
{
    public partial class frmManageClients : frmDesigne
    {
        public frmManageClients()
        {
            InitializeComponent();


        }
        public clsClients CurrentClient = new clsClients();

        private void frmManageClients_Load(object sender, EventArgs e)
        {

            


            _RefreshClientsList();
            _ShowClientsList();
            _HideAddNewClient();

        }

        private void _ShowAddNewClient()
        {


            lblID.Visible = true;

            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblAccountNumber.Visible = true;
            lblPinCode.Visible = true;
            lblPhone.Visible = true;
            lblEmail.Visible = true;
            lblAddress.Visible = true;
            lblBalance.Visible = true;
            lblDateOfBitrh.Visible = true;
            lblImagePath.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtAccountNumber.Visible = true;
            txtPinCode.Visible = true;
            txtPhone.Visible = true;
            txtEmail.Visible = true;
            txtAddress.Visible = true;
            numericUpDown1.Visible = true;
            dateTimePicker1.Visible = true;
            txtImagePath.Visible = true;

            lblSave.Visible = true;
            lblClear.Visible = true;

            pcbSave.Visible = true;
            pcbClear.Visible = true;

            pcbLineAccountNumber.Visible = true;
            pcbLinePinCode.Visible = true;
            pcbLinePhone.Visible = true;
        }

        private void _HideAddNewClient()
        {
            lblID.Visible = false;

            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblAccountNumber.Visible = false;
            lblPinCode.Visible = false;
            lblPhone.Visible = false;
            lblEmail.Visible = false;
            lblAddress.Visible = false;
            lblBalance.Visible = false;
            lblDateOfBitrh.Visible = false;
            lblImagePath.Visible = false;

            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtAccountNumber.Visible = false;
            txtPhone.Visible = false;
            txtPinCode.Visible = false;
            txtEmail.Visible = false;
            txtAddress.Visible = false;
            numericUpDown1.Visible = false;
            dateTimePicker1.Visible = false;
            txtImagePath.Visible = false;

            lblSave.Visible = false;
            lblClear.Visible = false;

            pcbSave.Visible = false;
            pcbClear.Visible = false;

            pcbLineAccountNumber.Visible = false;
            pcbLinePinCode.Visible = false;
            pcbLinePhone.Visible = false;
        }

        private void _HideClientsList()
        {
            dataGridView1.Visible = false;
        }

        private void _ShowClientsList()
        {
            pcbTitle.ImageLocation = "C:\\Users\\welcome\\Desktop\\koko\\bank\\usersList.png";
            dataGridView1.Visible = true;
            _RefreshClientsList();
        }

        private void _RefreshClientsList()
        {
            dataGridView1.DataSource = clsClients.GetAllClients();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _ShowClientsList();
            _HideAddNewClient();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (!frmDesigne.CheakAccessRights(clsUsers.enPermissions.pAddNewClient))
                return;
            CurrentClient.ModeClient = clsClients.enMode.AddNew;
            lblID.Text = "Client ID : ??";
            pcbClear_Click(sender, e);
            pcbTitle.ImageLocation = "C:\\Users\\welcome\\Desktop\\koko\\bank\\add-user.png";
            _HideClientsList();
            _ShowAddNewClient();
        }

        private void pcbClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAccountNumber.Text = "";
            txtPinCode.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = ""; ;
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Parse("01/01/00");
            txtImagePath.Text = "";

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            pcbClear_Click(sender, e);
        }

        private void pcbSave_Click(object sender, EventArgs e)
        {
            if (AddNewIsEmpty())
            {
                MessageBox.Show("Pleas inter all informations", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return;
            }

            if (MessageBox.Show("Are you sure you want to save Client informations ?", "Are you sue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CurrentClient.FirstName = txtFirstName.Text;
                CurrentClient.LastName = txtLastName.Text;
                CurrentClient.PinCode = txtPinCode.Text;
                CurrentClient.AccountNumber = txtAccountNumber.Text;
                CurrentClient.Phone = txtPhone.Text;
                CurrentClient.Email = txtEmail.Text;
                CurrentClient.Address = txtAddress.Text;
                CurrentClient.Blalance = numericUpDown1.Value;
                CurrentClient.DateOfBirth = dateTimePicker1.Value;
                CurrentClient.ImagePath = txtImagePath.Text;

                if (CurrentClient.SaveClient())
                {
                    MessageBox.Show("Client Saved Successfully", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ShowClientsList();
                    _HideAddNewClient();
                }
                else
                {
                    MessageBox.Show("Error", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }


        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            pcbSave_Click(sender, e);
        }

        private bool AddNewIsEmpty()
        {
            return (
                txtFirstName.Text == "" ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtAccountNumber.Text == "" ||
                txtPinCode.Text == "" ||
                txtPhone.Text == "" ||
                txtEmail.Text == "" ||
                txtAddress.Text == "" ||
                numericUpDown1.Value == 0 ||
                dateTimePicker1.Value >= DateTime.Parse("01/01/2023")
                );
        }

        private void pcbUpdateClient_Click(object sender, EventArgs e)
        {
            if (!frmDesigne.CheakAccessRights(clsUsers.enPermissions.pUpdateClients))
                return;

            CurrentClient.ModeClient = clsClients.enMode.Update;
            pcbTitle.ImageLocation = "C:\\Users\\welcome\\Desktop\\koko\\bank\\update.png";
            CurrentClient = clsClients.FindClient
                ((int)dataGridView1.CurrentRow.Cells[0].Value);

            lblID.Text = "Client ID :" + dataGridView1.CurrentRow.Cells[0].Value;

            txtFirstName.Text = CurrentClient.FirstName;
            txtLastName.Text = CurrentClient.LastName;
            txtPinCode.Text = CurrentClient.PinCode;
            txtAccountNumber.Text = CurrentClient.AccountNumber;
            txtPhone.Text = CurrentClient.Phone;
            txtEmail.Text = CurrentClient.Email;
            txtAddress.Text = CurrentClient.Address;
            numericUpDown1.Value = CurrentClient.Blalance;
            dateTimePicker1.Value = CurrentClient.DateOfBirth;
            txtImagePath.Text = CurrentClient.ImagePath;


            _ShowAddNewClient();
            _HideClientsList();
        }

        private void pcbDeleteClient_Click(object sender, EventArgs e)
        {
            if (!frmDesigne.CheakAccessRights(clsUsers.enPermissions.pDeleteClient))
                return;


            CurrentClient = clsClients.FindClient((int)dataGridView1.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure you want to delete Client with ID(" + CurrentClient.ClientID
                + ") ? ", "Sure?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (clsClients.DeleteClient(CurrentClient.ClientID))
                {
                    MessageBox.Show("Client deleted Successefully", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClientsList();
                }
                else
                {
                    MessageBox.Show("Error", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();
            string columnName = "FirstName"; 
            DataView dataView = clsClients.GetAllClients().DefaultView; 
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, searchValue);
            dataGridView1.DataSource = dataView;
        }

        private void pcbSave_MouseEnter(object sender, EventArgs e)
        {
            pcbSave.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbSave_MouseLeave(object sender, EventArgs e)
        {
            pcbSave.BorderStyle = BorderStyle.None;
        }

        private void pcbClear_MouseEnter(object sender, EventArgs e)
        {
            pcbClear.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbClear_MouseLeave(object sender, EventArgs e)
        {
            pcbClear.BorderStyle = BorderStyle.None;
        }

        private void pcbClientsList_MouseEnter(object sender, EventArgs e)
        {
            pcbClientsList.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbClientsList_MouseLeave(object sender, EventArgs e)
        {
            pcbClientsList.BorderStyle = BorderStyle.None;
        }

        private void pcbAddClient_MouseHover(object sender, EventArgs e)
        {
            pcbAddClient.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbAddClient_MouseLeave(object sender, EventArgs e)
        {
            pcbAddClient.BorderStyle = BorderStyle.None;
        }

        private void pcbUpdateClient_MouseHover(object sender, EventArgs e)
        {
            pcbUpdateClient.BorderStyle = BorderStyle.Fixed3D;  
        }

        private void pcbUpdateClient_MouseLeave(object sender, EventArgs e)
        {
            pcbUpdateClient.BorderStyle = BorderStyle.None;
        }

        private void pcbDeleteClient_MouseHover(object sender, EventArgs e)
        {
            pcbDeleteClient.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbDeleteClient_MouseLeave(object sender, EventArgs e)
        {
            pcbDeleteClient.BorderStyle = BorderStyle.None;
        }
    }
}
