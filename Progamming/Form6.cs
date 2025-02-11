using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progamming
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void ຈດການສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ອອກຈາກລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ຂມນຜສະໜອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent=this;
        }

        private void ຂມນປະToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductType frm = new frmProductType();
            frm.Show();
            frm.WindowState=FormWindowState.Maximized;
            frm.MdiParent=this;
        }

        private void ຂມນສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _4COM_IT_App.frmProducts frm = new _4COM_IT_App.frmProducts();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ຂມນລກຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ລາຍງານສນຄາໃນຮານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptProductViewer frm = new frmrptProductViewer();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }
    }
}
