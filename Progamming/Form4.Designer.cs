namespace Progamming
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(752, 395);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(139, 76);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(897, 395);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 76);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "<=";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(752, 477);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(139, 76);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(897, 477);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(139, 76);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(752, 559);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(139, 76);
            this.times.TabIndex = 7;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(897, 559);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(139, 76);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(897, 641);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(139, 76);
            this.percent.TabIndex = 9;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(608, 641);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(283, 76);
            this.equals.TabIndex = 10;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 76);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(608, 477);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 76);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(608, 395);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 76);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 76);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 76);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(463, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 76);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(463, 641);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(139, 76);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 76);
            this.button4.TabIndex = 19;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(318, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 76);
            this.button7.TabIndex = 20;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(318, 641);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(139, 76);
            this.buttonDot.TabIndex = 21;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 76);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DisplayTextBox.Location = new System.Drawing.Point(318, 327);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(718, 62);
            this.DisplayTextBox.TabIndex = 10;
            this.DisplayTextBox.TabStop = false;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(318, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 93);
            this.label1.TabIndex = 50;
            this.label1.Text = "ໂປຣແກລມຄິດໄລ່ເລກ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 980);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.buttonClear);
            this.Name = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label label1;
    }
}