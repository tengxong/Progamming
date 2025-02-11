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
    public partial class frmSupplier : Form
    {
        string strConnect = @"Data Source=TENG\SQLEXPRESS;Initial Catalog=minDB_4com1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataReader dar = null;
        public frmSupplier()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }
        private void getData()
        {
            string sql = "SELECT * FROM tbSuppliers";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvShow.DataSource = dt;

            // ตั้งชื่อหัวตารางให้แสดงเป็นภาษาไทย
            dgvShow.Columns[0].HeaderText = "ລະຫັດຜູ້ສະໜອງ";
            dgvShow.Columns[1].HeaderText = "ຊື່ຜູ້ສະໜອງ";
            dgvShow.Columns[2].HeaderText = "ຊື່ຜູ້ຕິດຕໍ່";
            dgvShow.Columns[3].HeaderText = "ທີ່ຢູ່";
            dgvShow.Columns[4].HeaderText = "ເບີໂທ";
            dgvShow.Columns[5].HeaderText = "ອີເມລ";

        }
        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbSuppliers values('" +
                txtSupID.Text + "',N'" + txtSupName.Text + "','" + txtContrName.Text + "','" + txtTel.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShow.CurrentRow.Index;
            txtSupID.Text = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtSupName.Text = dgvShow.Rows[cindex].Cells[1].Value.ToString();
            txtContrName.Text = dgvShow.Rows[cindex].Cells[2].Value.ToString();
            txtTel.Text = dgvShow.Rows[cindex].Cells[3].Value.ToString();
            txtAddress.Text = dgvShow.Rows[cindex].Cells[4].Value.ToString();
            txtEmail.Text = dgvShow.Rows[cindex].Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbSuppliers SET supplier_name = N'" + txtSupName.Text +
                        "', contract_name = N'" + txtContrName.Text +
                        "', address = N'" + txtAddress.Text +
                        "', telephone = '" + txtTel.Text +
                        "', email = '" + txtEmail.Text +
                        "' WHERE supplier_id = '" + txtSupID.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ບໍ່?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tbSuppliers WHERE supplier_id = '" + txtSupID.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                getData();
            }

        }
    }
}
