using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4COM_IT_App
{
    public partial class frmProducts : Form
    {
        string strConn = @"Data Source=TENG\SQLEXPRESS;Initial Catalog=minDB_4com1;Integrated Security=True;";
        string pid = "";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;

        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand("select * from tbProductType", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            cboType.DataSource = dtPT;
            cboType.DisplayMember = "ptType_name";
            cboType.ValueMember = "ptType_ID";
            showData();


        }
        private void showData()
        {
            sqlCmd = new SqlCommand("select * from tbProducts", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            dgvShowdata.DataSource = dt;
            dgvShowdata.Columns[0].HeaderText = "ລຳດັບ";
            dgvShowdata.Columns[1].HeaderText = "ລະຫັດສິນຄ້າ";
            dgvShowdata.Columns[2].HeaderText = "ຊື່ສິນຄ້າ";
            dgvShowdata.Columns[3].HeaderText = "ຈຳນວນ";
            dgvShowdata.Columns[4].HeaderText = "ລາຄາຕໍ່ໜ່ວຍ";
            dgvShowdata.Columns[5].HeaderText = "ຫົວໜ່ວຍ";
            dgvShowdata.Columns[6].HeaderText = "ເກນສິນຄ້າເຫຼືອ";
            dgvShowdata.Columns[7].HeaderText = "ຮູບພາບ";
            dgvShowdata.Columns[8].HeaderText = "ປະເພດສິນຄ້າ";

        }

        private void dgvShowdata_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShowdata.CurrentRow.Index;
            pid = dgvShowdata.Rows[cindex].Cells[0].Value.ToString();
            txtProNo.Text = dgvShowdata.Rows[cindex].Cells[1].Value.ToString();
            txtProName.Text = dgvShowdata.Rows[cindex].Cells[2].Value.ToString();
            txtQty.Text = dgvShowdata.Rows[cindex].Cells[3].Value.ToString();
            txtPrice.Text = dgvShowdata.Rows[cindex].Cells[4].Value.ToString();
            txtUnit.Text = dgvShowdata.Rows[cindex].Cells[5].Value.ToString();
            txtInstock.Text = dgvShowdata.Rows[cindex].Cells[6].Value.ToString();

            // Handle image (check for DBNull)
            object imgValue = dgvShowdata.Rows[cindex].Cells[7].Value;
            if (imgValue != DBNull.Value)
            {
                byte[] img = (byte[])imgValue;
                MemoryStream ms = new MemoryStream(img);
                picProduct.Image = Image.FromStream(ms);
            }
            else
            {
                picProduct.Image = null;
            }

            // Correct column index for product type
            cboType.SelectedValue = dgvShowdata.Rows[cindex].Cells[8].Value.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ຫຼືບໍ່?", "Question",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlstr = "Delete from tbProducts where proid='" + pid + "'";
                sqlCmd = new SqlCommand(sqlstr, sqlCon);
                sqlCmd.ExecuteNonQuery();
                showData();
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (picProduct.Image == null)
            {
                MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte[] btimg = ImageToByteArray(picProduct.Image);

                 string sqlstr = "INSERT INTO tbproducts (proNo, proName, Quantity, UnitPrice, Unit, Instock, picture, productTypeid) " +
                 "VALUES (@proNo, @proName, @Quantity, @UnitPrice, @Unit, @Instock, @picture, @productTypeid)";
                using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
                {
                    sqlCmd.Parameters.AddWithValue("@proid", pid ?? "defaultProid");
                    sqlCmd.Parameters.AddWithValue("@proNo", txtProNo.Text);
                    sqlCmd.Parameters.AddWithValue("@proName", txtProName.Text);
                    sqlCmd.Parameters.AddWithValue("@Quantity", txtQty.Text);
                    sqlCmd.Parameters.AddWithValue("@UnitPrice", txtPrice.Text);
                    sqlCmd.Parameters.AddWithValue("@Unit", txtUnit.Text);
                    sqlCmd.Parameters.AddWithValue("@Instock", txtInstock.Text);
                    sqlCmd.Parameters.AddWithValue("@picture", btimg);
                    sqlCmd.Parameters.AddWithValue("@productTypeid", cboType.SelectedValue);

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (picProduct.Image == null)
            {
                MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MemoryStream ms = new MemoryStream();
            picProduct.Image.Save(ms, picProduct.Image.RawFormat);
            byte[] btimg = ms.GetBuffer();

            string sqlstr = "UPDATE tbproducts SET proNo = @proNo, proName = @proName, Quantity = @Quantity, " +
                            "UnitPrice = @UnitPrice, Unit = @Unit, Instock = @Instock, picture = @picture, " +
                            "productTypeid = @productTypeid WHERE proid = @proid";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@proNo", txtProNo.Text);
            sqlCmd.Parameters.AddWithValue("@proName", txtProName.Text);
            sqlCmd.Parameters.AddWithValue("@Quantity", txtQty.Text);
            sqlCmd.Parameters.AddWithValue("@UnitPrice", txtPrice.Text);
            sqlCmd.Parameters.AddWithValue("@Unit", txtUnit.Text);
            sqlCmd.Parameters.AddWithValue("@Instock", txtInstock.Text);
            sqlCmd.Parameters.AddWithValue("@picture", btimg);
            sqlCmd.Parameters.AddWithValue("@productTypeid", cboType.SelectedValue);
            sqlCmd.Parameters.AddWithValue("@proid", pid);

            sqlCmd.ExecuteNonQuery();
            showData();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFdl = new OpenFileDialog();
            opFdl.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (opFdl.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picProduct.Image = Image.FromFile(opFdl.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picProduct.Image = null;
                }
            }
        }


    }
}
