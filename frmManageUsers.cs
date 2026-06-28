using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BusinessBank1;
using clsBusinessBank1;

namespace Bank1._1
{
    public partial class frmManageUsers : frmDesigne
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        clsUsers CurrentUser = new clsUsers();

        private void _RefreshUsersList()
        {
            dataGridView1.DataSource = clsUsers.GetAllUsers();
        }

        private void _ShowAddNewUser()
        {


            lblID.Visible = true;

            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblUserName.Visible = true;
            lblPassword.Visible = true;
            lblPhone.Visible = true;
            lblEmail.Visible = true;
            lblAddress.Visible = true;
            lblDateOfBitrh.Visible = true;
            lblImagePath.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtUserName.Visible = true;
            txtPassword.Visible = true;
            txtPhone.Visible = true;
            txtEmail.Visible = true;
            txtAddress.Visible = true;
            dateTimePicker1.Visible = true;
            txtImagePath.Visible = true;


            pcbSave.Visible = true;
            pcbClear.Visible = true;
            lblSave.Visible = true;
            lblClear.Visible = true;


            pcbLineUserName.Visible = true;
            pcbLinePassword.Visible = true;
            pcbLinePhone.Visible = true;

            grbPermissions.Visible = true;
        
        }

        private void _HideAddNewUser()
        {
            lblID.Visible = false;

            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblUserName.Visible = false;
            lblPassword.Visible = false;
            lblPhone.Visible = false;
            lblEmail.Visible = false;
            lblAddress.Visible = false;
            lblDateOfBitrh.Visible = false;
            lblImagePath.Visible = false;

            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtUserName.Visible = false;
            txtPhone.Visible = false;
            txtPassword.Visible = false;
            txtEmail.Visible = false;
            txtAddress.Visible = false;
            dateTimePicker1.Visible = false;
            txtImagePath.Visible = false;

            lblSave.Visible = false;
            lblClear.Visible = false;

            pcbSave.Visible = false;
            pcbClear.Visible = false;

            pcbLineUserName.Visible = false;
            pcbLinePassword.Visible = false;
            pcbLinePhone.Visible = false;

            grbPermissions.Visible = false;
        }


        private void _ShowUsersList()
        {
            pcbTiltle.ImageLocation = "C:\\Users\\welcome\\Desktop\\koko\\User\\List.png";

            pcbFind.Visible = true;
            pcbFindLine.Visible = true;
            txtSearch.Visible = true;
            dataGridView1.Visible = true;
            _RefreshUsersList();
        }

        private void _HideUsersList()
        {
            pcbFind.Visible = false;
            pcbFindLine.Visible = false;
            txtSearch.Visible = false;
            dataGridView1.Visible = false;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            frmDesigne.CheakAccessRights(clsUsers.enPermissions.pManageUsers);
            _ShowUsersList();
            _HideAddNewUser();
        }

        private int _ReadPermmissions()
        {
            int Permissions = 0;
            if (ckbFullAcces.Checked == true)
            {
                Permissions = -1;
                return Permissions; 
            }
            if (ckbAddClients.Checked == true)
                Permissions += 1;
            if (ckbDeleteCleints.Checked == true)
                Permissions += 2;
            if (ckbUpdateClients.Checked == true)
                Permissions += 4;
            if (ckbTransactions.Checked == true)
                Permissions += 8;
            if (ckbManageUsers.Checked == true)
                Permissions += 16;
            if (ckbUpdateCurrencies.Checked == true)
                Permissions += 32;

            return Permissions;


        }

        private void _FellUpdatePermmissions(int  Permissions)
                                                                    
        {
            if ((int)Permissions == -1)
            {
                ckbFullAcces.Checked = true;
                return;
            }

            if ((Permissions & CurrentUser.Permissions) == 1 )
                ckbAddClients.Checked = true;

            if ((Permissions & CurrentUser.Permissions) == 2)
                ckbDeleteCleints.Checked = true;

            if ((Permissions & CurrentUser.Permissions) == 4)
                ckbUpdateClients.Checked = true;
            
            if ((Permissions & CurrentUser.Permissions) == 8)
                ckbTransactions.Checked = true;
            
            if ((Permissions & CurrentUser.Permissions) == 16)
                ckbManageUsers.Checked = true;
            
            if ((Permissions & CurrentUser.Permissions) == 32)
                ckbUpdateCurrencies.Checked = true;

        }

        private void pcbSave_Click(object sender, EventArgs e)
        {
            if (AddNewIsEmpty())
            {
                MessageBox.Show("Pleas inter all informations", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return;
            }

            if (MessageBox.Show("Are you sure you want to save User informations ?", "Are you sue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CurrentUser.FirstName = txtFirstName.Text;
                CurrentUser.LastName = txtLastName.Text;
                CurrentUser.Passowrd = txtPassword.Text;
                CurrentUser.UserName = txtUserName.Text;
                CurrentUser.Phone = txtPhone.Text;
                CurrentUser.Email = txtEmail.Text;
                CurrentUser.Address = txtAddress.Text;
                CurrentUser.DateOfBirth = dateTimePicker1.Value;
                CurrentUser.ImagePath = txtImagePath.Text;
                CurrentUser.Permissions = _ReadPermmissions();
                
                if (CurrentUser.SaveUser())
                {
                    MessageBox.Show("User Saved Successfully", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ShowUsersList();
                    _HideAddNewUser();
                }
                else
                {
                    MessageBox.Show("Error", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void pcbList_Click(object sender, EventArgs e)
        {
            _ShowUsersList();
            _HideAddNewUser();
        }

        private void pcbAdd_Click(object sender, EventArgs e)
        {
            CurrentUser.ModeUser = clsUsers.enMode.AddNew;
            lblID.Text = "User ID : ??";
            pcbClear_Click(sender, e);
            pcbTiltle.ImageLocation = "C:\\Users\\welcome\\Desktop\\koko\\User\\Add.png";

            _ShowAddNewUser();
            _HideUsersList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();
            string columnName = "UserName";
            DataView dataView = clsUsers.GetAllUsers().DefaultView;
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, searchValue);
            dataGridView1.DataSource = dataView;
        }

        private bool AddNewIsEmpty()
        {
            return (
                (ckbFullAcces.Checked ==false) &&
                (ckbAddClients.Checked == false &&
                ckbUpdateClients.Checked == false &&
                ckbDeleteCleints.Checked == false &&
                ckbManageUsers.Checked == false && 
                ckbTransactions.Checked == false &&
                ckbUpdateCurrencies.Checked == false) ||
                txtFirstName.Text == "" ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtUserName.Text == "" ||
                txtPassword.Text == "" ||
                txtPhone.Text == "" ||
                txtEmail.Text == "" ||
                txtAddress.Text == "" ||
                dateTimePicker1.Value >= DateTime.Parse("01/01/2023")
                );
        }

        private void pcbClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = ""; ;
            dateTimePicker1.Value = DateTime.Parse("01/01/00");
            txtImagePath.Text = "";
            ckbFullAcces.Checked = false;
            ckbAddClients.Checked = false;
            ckbDeleteCleints.Checked = false;
            ckbUpdateClients.Checked = false;
            ckbTransactions.Checked = false;
            ckbManageUsers.Checked = false;
            ckbUpdateCurrencies.Checked = false;

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            pcbClear_Click(sender, e);
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            pcbSave_Click(sender, e);
        }

        private void pcbUpdate_Click(object sender, EventArgs e)
        {
            pcbTiltle.ImageLocation = "C:\\Users\\welcome\\Desktop\\koko\\User\\UpdateManage.png";
            CurrentUser = clsUsers.FindUser
                ((int)dataGridView1.CurrentRow.Cells[0].Value);

            CurrentUser.ModeUser = clsUsers.enMode.Update;

            lblID.Text = "User ID :" + dataGridView1.CurrentRow.Cells[0].Value;

            txtFirstName.Text = CurrentUser.FirstName;
            txtLastName.Text = CurrentUser.LastName;
            txtPassword.Text = CurrentUser.Passowrd;
            txtUserName.Text = CurrentUser.UserName;
            txtPhone.Text = CurrentUser.Phone;
            txtEmail.Text = CurrentUser.Email;
            txtAddress.Text = CurrentUser.Address;
            dateTimePicker1.Value = CurrentUser.DateOfBirth;
            txtImagePath.Text = CurrentUser.ImagePath;
            _FellUpdatePermmissions(CurrentUser.Permissions);

            _ShowAddNewUser();
            _HideUsersList();
        }

        private void pcbDelete_Click(object sender, EventArgs e)
        {
            CurrentUser = clsUsers.FindUser((int)dataGridView1.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure you want to delete User with ID(" + CurrentUser.UserID
                + ") ? ", "Sure?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser(CurrentUser.UserID))
                {
                    MessageBox.Show("User deleted Successefully", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("Error", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pcbList_MouseEnter(object sender, EventArgs e)
        {
            pcbList.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbList_MouseLeave(object sender, EventArgs e)
        {
            pcbList.BorderStyle = BorderStyle.None;
        }

        private void pcbAdd_MouseEnter(object sender, EventArgs e)
        {
            pcbAdd.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbAdd_MouseLeave(object sender, EventArgs e)
        {
            pcbAdd.BorderStyle = BorderStyle.None;
        }

        private void pcbUpdate_MouseEnter(object sender, EventArgs e)
        {
            pcbUpdate.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbUpdate_MouseLeave(object sender, EventArgs e)
        {
            pcbUpdate.BorderStyle = BorderStyle.None;
        }

        private void pcbDelete_MouseEnter(object sender, EventArgs e)
        {
            pcbDelete.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pcbDelete.BorderStyle = BorderStyle.None;
        }

        private void pcbFind_Click(object sender, EventArgs e)
        {
            
        }
    }
}
