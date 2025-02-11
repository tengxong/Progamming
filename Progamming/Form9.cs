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
    public partial class frmCustomer : Form
    {
        string strConnect = @"Data Source=TENG\SQLEXPRESS;Initial Catalog=minDB_4com1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataReader dar = null;
        public frmCustomer()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }
        private void getData()
        {
            string sql = "select * from tbCustomers";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvShowData.DataSource = dt;
            dgvShowData.Columns[0].HeaderText = "ລະຫັດລູກຄ້າ";
            dgvShowData.Columns[1].HeaderText = "ຊື່ລູກຄ້າ";
            dgvShowData.Columns[2].HeaderText = "ທີ່ຢູ່";
            dgvShowData.Columns[3].HeaderText = "ເບີໂທ";
        }

        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbCustomers (cust_id, cust_name, cust_Address, telephone) VALUES ('"
                + txtCusID.Text + "', N'"
                + txtCusname.Text + "', N'"
                + txtCusAddress.Text + "', '"
                + txtCusnumber.Text + "')";

            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();

        }
        private void dgvShowData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShowData.CurrentRow.Index;
            txtCusID.Text = dgvShowData.Rows[cindex].Cells[0].Value.ToString();
            txtCusname.Text = dgvShowData.Rows[cindex].Cells[1].Value.ToString();
            txtCusAddress.Text = dgvShowData.Rows[cindex].Cells[2].Value.ToString();
            txtCusnumber.Text = dgvShowData.Rows[cindex].Cells[3].Value.ToString();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string sql = "update tbCustomers set cust_name=N'" +
               txtCusname.Text + "',cust_Address = '" +
               txtCusAddress.Text + "',telephone= '" +
               txtCusnumber.Text + "' where cust_id='" + txtCusID.Text + "'";
            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່", "Queastion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete tbCustomers where cust_id='" + txtCusID.Text + "'";
                cmd = new SqlCommand(@sql, conn);
                cmd.ExecuteNonQuery();
                getData();
            }
        }
    }
}
