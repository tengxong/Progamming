namespace Progamming
{
    partial class frmSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtContrName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Boon Lor", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະຫັດຜູ້ສະໜອງ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Boon Lor", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຊື່ບໍລິສັດ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Boon Lor", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "ຊື່ຜູ້ຕິດຕໍ່:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Boon Lor", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "ເບີໂທຕິດຕໍ່:";
            // 
            // txtSupID
            // 
            this.txtSupID.Font = new System.Drawing.Font("Saysettha OT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupID.Location = new System.Drawing.Point(427, 201);
            this.txtSupID.Multiline = true;
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(667, 58);
            this.txtSupID.TabIndex = 4;
            this.txtSupID.TextChanged += new System.EventHandler(this.txtSupID_TextChanged);
            // 
            // txtSupName
            // 
            this.txtSupName.Font = new System.Drawing.Font("Saysettha OT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupName.Location = new System.Drawing.Point(427, 276);
            this.txtSupName.Multiline = true;
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(667, 58);
            this.txtSupName.TabIndex = 5;
            this.txtSupName.TextChanged += new System.EventHandler(this.txtSupName_TextChanged);
            // 
            // txtContrName
            // 
            this.txtContrName.Font = new System.Drawing.Font("Saysettha OT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrName.Location = new System.Drawing.Point(427, 366);
            this.txtContrName.Multiline = true;
            this.txtContrName.Name = "txtContrName";
            this.txtContrName.Size = new System.Drawing.Size(667, 58);
            this.txtContrName.TabIndex = 6;
            this.txtContrName.TextChanged += new System.EventHandler(this.txtContrName_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Saysettha OT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(427, 452);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(667, 58);
            this.txtTel.TabIndex = 7;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1638, 70);
            this.label5.TabIndex = 8;
            this.label5.Text = "ຟອມຂໍ້ມູນຜູ້ສະໜອງ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Saysettha OT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(427, 535);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(454, 58);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Boon Lor", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 49);
            this.label6.TabIndex = 9;
            this.label6.Text = "ທີ່ຢູ່:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 53);
            this.label7.TabIndex = 11;
            this.label7.Text = "ຮັບຂໍ້ມູນຜູ້ສະໜອງ";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(427, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(192, 64);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEdit.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(676, 618);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(205, 64);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(923, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 64);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "ລົບຂໍ້ມູນ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToOrderColumns = true;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(30, 712);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 82;
            this.dgvShow.RowTemplate.Height = 33;
            this.dgvShow.Size = new System.Drawing.Size(1584, 207);
            this.dgvShow.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Boon Lor", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(903, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 49);
            this.label8.TabIndex = 9;
            this.label8.Text = "ອິເມວ:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Saysettha OT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1013, 535);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 58);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 941);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtContrName);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSupplier";
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtContrName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}