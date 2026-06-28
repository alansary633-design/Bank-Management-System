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
    public partial class frmMainMenue : frmDesigne
    {
        public frmMainMenue()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenue_Load(object sender, EventArgs e)
        {

        }

        private void pcbManageClients_Click(object sender, EventArgs e)
        {
            frmManageClients frmClients = new frmManageClients();
            frmClients.ShowDialog();
        }

        private void pcbManageUsers_Click(object sender, EventArgs e)
        {
            if (!frmDesigne.CheakAccessRights(clsUsers.enPermissions.pManageUsers))
                return;

            frmManageUsers frmUsers = new frmManageUsers();
            frmUsers.ShowDialog();
        }

        private void pcbTransactions_Click(object sender, EventArgs e)
        {
            if (!frmDesigne.CheakAccessRights(clsUsers.enPermissions.pTranactions))
                return;

            frmTransactions frmTransactions = new frmTransactions();
            frmTransactions.ShowDialog();
        }

        private void pcbCurrencies_Click(object sender, EventArgs e)
        {
            
                frmCurrencies frmCurrencies = new frmCurrencies();
                frmCurrencies.ShowDialog();

            
        }

        private void pcbManageClients_MouseEnter(object sender, EventArgs e)
        {
            pcbManageClients.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbManageClients_MouseLeave(object sender, EventArgs e)
        {
            pcbManageClients.BorderStyle = BorderStyle.None;
        }

        private void pcbManageUsers_MouseEnter(object sender, EventArgs e)
        {
            pcbManageUsers.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbManageUsers_MouseLeave(object sender, EventArgs e)
        {
            pcbManageUsers.BorderStyle = BorderStyle.None;
        }

        private void pcbTransactions_MouseEnter(object sender, EventArgs e)
        {
            pcbTransactions.BorderStyle = BorderStyle.Fixed3D; 
        }

        private void pcbTransactions_MouseLeave(object sender, EventArgs e)
        {
            pcbTransactions.BorderStyle = BorderStyle.None;
        }

        private void pcbCurrencies_MouseEnter(object sender, EventArgs e)
        {
            pcbCurrencies.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pcbCurrencies_MouseLeave(object sender, EventArgs e)
        {
            pcbCurrencies.BorderStyle = BorderStyle.None;
        }

    }
}
