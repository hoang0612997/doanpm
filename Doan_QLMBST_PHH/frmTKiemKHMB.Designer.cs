namespace Doan_QLMBST_PHH
{
    partial class frmTKiemKHMB
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
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luoi_kq2 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.luoi_kq = new System.Windows.Forms.DataGridView();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.rd_ms = new System.Windows.Forms.RadioButton();
            this.rd_mt = new System.Windows.Forms.RadioButton();
            this.rd_makh = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luoi_kq2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi_kq)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaS";
            this.Column11.HeaderText = "Mã sim";
            this.Column11.Name = "Column11";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DiaChi";
            this.Column9.HeaderText = "Địa chỉ";
            this.Column9.Name = "Column9";
            this.Column9.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Tenkh";
            this.Column8.HeaderText = "Họ tên";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Makh";
            this.Column7.HeaderText = "Mã khách hàng";
            this.Column7.Name = "Column7";
            // 
            // luoi_kq2
            // 
            this.luoi_kq2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi_kq2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.luoi_kq2.Location = new System.Drawing.Point(17, 20);
            this.luoi_kq2.Name = "luoi_kq2";
            this.luoi_kq2.RowTemplate.Height = 24;
            this.luoi_kq2.Size = new System.Drawing.Size(786, 113);
            this.luoi_kq2.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoDienThoai";
            this.Column10.HeaderText = "Số điện thoại";
            this.Column10.Name = "Column10";
            this.Column10.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.luoi_kq2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(84, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách hàng mua sim";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaThe";
            this.Column5.HeaderText = "Mã thẻ";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoDienThoai";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tenkh";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Makh";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.luoi_kq);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(84, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng mua thẻ";
            // 
            // luoi_kq
            // 
            this.luoi_kq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi_kq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.luoi_kq.Location = new System.Drawing.Point(17, 20);
            this.luoi_kq.Name = "luoi_kq";
            this.luoi_kq.RowTemplate.Height = 24;
            this.luoi_kq.Size = new System.Drawing.Size(786, 115);
            this.luoi_kq.TabIndex = 0;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(563, 87);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(117, 38);
            this.bt_thoat.TabIndex = 7;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_tim.Location = new System.Drawing.Point(563, 23);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(117, 38);
            this.bt_tim.TabIndex = 6;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // rd_ms
            // 
            this.rd_ms.AutoSize = true;
            this.rd_ms.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_ms.Location = new System.Drawing.Point(194, 104);
            this.rd_ms.Name = "rd_ms";
            this.rd_ms.Size = new System.Drawing.Size(81, 23);
            this.rd_ms.TabIndex = 5;
            this.rd_ms.Text = "Mã sim";
            this.rd_ms.UseVisualStyleBackColor = true;
            // 
            // rd_mt
            // 
            this.rd_mt.AutoSize = true;
            this.rd_mt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mt.Location = new System.Drawing.Point(194, 66);
            this.rd_mt.Name = "rd_mt";
            this.rd_mt.Size = new System.Drawing.Size(77, 23);
            this.rd_mt.TabIndex = 4;
            this.rd_mt.Text = "Mã thẻ";
            this.rd_mt.UseVisualStyleBackColor = true;
            // 
            // rd_makh
            // 
            this.rd_makh.AutoSize = true;
            this.rd_makh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_makh.Location = new System.Drawing.Point(194, 23);
            this.rd_makh.Name = "rd_makh";
            this.rd_makh.Size = new System.Drawing.Size(130, 23);
            this.rd_makh.TabIndex = 3;
            this.rd_makh.Text = "Mã khách hàng";
            this.rd_makh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tìm kiếm theo mã sim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm kiếm theo mã thẻ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo MAKH:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.bt_thoat);
            this.panel1.Controls.Add(this.bt_tim);
            this.panel1.Controls.Add(this.rd_ms);
            this.panel1.Controls.Add(this.rd_mt);
            this.panel1.Controls.Add(this.rd_makh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(84, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 144);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM THÔNG TIN KHÁCH HÀNG ĐÃ MUA";
            // 
            // frmTKiemKHMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmTKiemKHMB";
            this.Text = "frmTKiemKHMB";
            this.Load += new System.EventHandler(this.frmTKiemKHMB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi_kq2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoi_kq)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView luoi_kq2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView luoi_kq;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.RadioButton rd_ms;
        private System.Windows.Forms.RadioButton rd_mt;
        private System.Windows.Forms.RadioButton rd_makh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}