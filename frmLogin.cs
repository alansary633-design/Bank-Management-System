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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool _Login()
        {
            
            if (clsUsers.isUserExist(txbUserName.Text, txtPassword.Text))
            {
                clsUsers.CurrentUser = clsUsers.FindUser(txbUserName.Text);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void pcbShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (_Login())
            {
                frmMainMenue frmMainMenue = new frmMainMenue();
                frmMainMenue.ShowDialog();

            }
            else
            {
                MessageBox.Show("UserName or Password wrong!", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                txbUserName.Text = "";
                txtPassword.Text = "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtPassword.Text = "1234";
            //txbUserName.Text = "User1";
        }

        
    }
}
