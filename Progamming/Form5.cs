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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string strConnect = @"Data Source=TENG\SQLEXPRESS;Initial Catalog=minDB_4com1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataReader dar = null;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pwd = TxtPwd.Text;
            string sql = "select * from tbusers where userName = '" + username + "' and password_code= '" + pwd + "'";
            conn = new SqlConnection(strConnect);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            if (dt.Rows.Count != 0) 
            {
                MessageBox.Show("ຍິນດີຕ້ອນຮັບທ່ານເຂົ້າສູ່ລະບົບ!");
                frmMainMenu frm = new frmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                this.Hide();
            } else{
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ລະບົບ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ!");
            }
        }

        //private void frmLogin_Load(object sender, EventArgs e)
        //{

        //    //this.reportViewer1.RefreshReport();
        //}
    }
}
