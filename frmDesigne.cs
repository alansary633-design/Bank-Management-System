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
    public partial class frmDesigne : Form
    {
        public frmDesigne()
        {
            InitializeComponent();
        }

        protected void frmDesigne_Load(object sender, EventArgs e)
        {
            //lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();

            // Create a Timer control with an interval of one second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second

            // Add an event handler for the Timer's Tick event
            timer.Tick += Timer_Tick;

            // Start the Timer
            timer.Start();

        }

        protected static bool CheakAccessRights(clsUsers.enPermissions Permission)
        {
            if (!clsUsers.CurrentUser.CheckAccessPermission(Permission))
            {
                MessageBox.Show("Access denied ,Contact your Admin","Denied"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            // Update the text of the Label to the current time

            lblTime.Text = DateTime.Now.ToString();
        }

        private void pcbOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbOut_MouseEnter(object sender, EventArgs e)
        {
            pcbOut.BorderStyle = BorderStyle.Fixed3D;

        }

        private void pcbOut_MouseLeave(object sender, EventArgs e)
        {
            pcbOut.BorderStyle = BorderStyle.None;

        }
    }
}
