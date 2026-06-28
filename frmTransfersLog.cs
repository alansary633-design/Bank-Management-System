using BusinessBank1;
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
    public partial class frmTransfersLog : Form
    {
        public frmTransfersLog()
        {
            InitializeComponent();
        }

        private void frmTransfersLog_Load(object sender, EventArgs e)
        {
            _RefreshTransfersList();
        }

        private void _RefreshTransfersList()
        {
            dataGridView1.DataSource = clsClients.GetTransfersList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();
            string columnName = "Source_name";
            DataView dataView = clsClients.GetTransfersList().DefaultView;
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, searchValue);
            dataGridView1.DataSource = dataView;
        }
    }
}
