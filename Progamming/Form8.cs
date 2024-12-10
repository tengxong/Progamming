using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Progamming
{
    public partial class frmProductType : Form
    {
        string strConnect = @"Data Source=TENG\SQLEXPRESS;Initial Catalog=minDB_4com1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlDataReader dar = null;
        public frmProductType()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }

        private void getData()
        {
            string sql = "select * from tbProductType";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvShowData.DataSource = dt;
            dgvShowData.Columns[0].HeaderText = "ລະຫັດປະເພດ";
            dgvShowData.Columns[1].HeaderText = "ຊື່ປະເພດ";
        }

        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbProductType values('"+
                txtPtTypeID.Text+"',N'"+txtPtTypeName.Text+"')";
            cmd= new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void dgvShowData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShowData.CurrentRow.Index;
            txtPtTypeID.Text = dgvShowData.Rows[cindex].Cells[0].Value.ToString();
            txtPtTypeName.Text = dgvShowData.Rows[cindex].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update tbProductType set ptType_name=N'" +
                txtPtTypeName.Text+ "' where ptType_ID='" + txtPtTypeID.Text + "'";
            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່","Queastion", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
            string sql = "delete tbProductType where ptType_ID='" + txtPtTypeID.Text + "'";
            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
                getData();
            }
        }
    }
}
