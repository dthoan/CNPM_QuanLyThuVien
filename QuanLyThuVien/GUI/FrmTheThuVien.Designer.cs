namespace QuanLyThuVien.GUI
{
    partial class FrmTheThuVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCTMuonTra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDocGia = new System.Windows.Forms.ComboBox();
            this.dateNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.dateNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTheThuVien = new System.Windows.Forms.DataGridView();
            this.MATHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAPTHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHETHANJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHETHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTMUONTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewTheThuVien);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 441);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 264);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamLai);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(365, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác Với Sách";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(303, 28);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(206, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(113, 28);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbCTMuonTra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbDocGia);
            this.groupBox1.Controls.Add(this.dateNgayLapThe);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Controls.Add(this.dateNgayHetHan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(404, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày hết hạn phải lớn hơn ngày lập phiếu";
            // 
            // cbbCTMuonTra
            // 
            this.cbbCTMuonTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCTMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCTMuonTra.FormattingEnabled = true;
            this.cbbCTMuonTra.Location = new System.Drawing.Point(182, 135);
            this.cbbCTMuonTra.Name = "cbbCTMuonTra";
            this.cbbCTMuonTra.Size = new System.Drawing.Size(200, 28);
            this.cbbCTMuonTra.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chi Tiết Mượn Trả";
            // 
            // cbbDocGia
            // 
            this.cbbDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDocGia.FormattingEnabled = true;
            this.cbbDocGia.Location = new System.Drawing.Point(530, 95);
            this.cbbDocGia.Name = "cbbDocGia";
            this.cbbDocGia.Size = new System.Drawing.Size(200, 28);
            this.cbbDocGia.TabIndex = 5;
            // 
            // dateNgayLapThe
            // 
            this.dateNgayLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayLapThe.Location = new System.Drawing.Point(182, 93);
            this.dateNgayLapThe.Name = "dateNgayLapThe";
            this.dateNgayLapThe.Size = new System.Drawing.Size(200, 26);
            this.dateNgayLapThe.TabIndex = 3;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(182, 32);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(200, 26);
            this.txtMaThe.TabIndex = 1;
            // 
            // dateNgayHetHan
            // 
            this.dateNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayHetHan.Location = new System.Drawing.Point(530, 40);
            this.dateNgayHetHan.Name = "dateNgayHetHan";
            this.dateNgayHetHan.Size = new System.Drawing.Size(200, 26);
            this.dateNgayHetHan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Đọc Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Hết Hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập Thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thẻ";
            // 
            // dataGridViewTheThuVien
            // 
            this.dataGridViewTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheThuVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHE,
            this.NGAYLAPTHE,
            this.NGAYHETHANJ,
            this.NGAYHETHAN,
            this.CTMUONTRA});
            this.dataGridViewTheThuVien.Location = new System.Drawing.Point(126, 3);
            this.dataGridViewTheThuVien.Name = "dataGridViewTheThuVien";
            this.dataGridViewTheThuVien.Size = new System.Drawing.Size(548, 164);
            this.dataGridViewTheThuVien.TabIndex = 0;
            this.dataGridViewTheThuVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheThuVien_CellClick);
            this.dataGridViewTheThuVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheThuVien_CellContentClick);
            // 
            // MATHE
            // 
            this.MATHE.DataPropertyName = "MATHETHUVIEN";
            this.MATHE.HeaderText = "Mã Thẻ";
            this.MATHE.Name = "MATHE";
            // 
            // NGAYLAPTHE
            // 
            this.NGAYLAPTHE.DataPropertyName = "NGAYLAPTHE";
            this.NGAYLAPTHE.HeaderText = "Ngày Lập Thẻ";
            this.NGAYLAPTHE.Name = "NGAYLAPTHE";
            // 
            // NGAYHETHANJ
            // 
            this.NGAYHETHANJ.DataPropertyName = "NGAYHETHAN";
            this.NGAYHETHANJ.HeaderText = "Ngày Hết Hạn";
            this.NGAYHETHANJ.Name = "NGAYHETHANJ";
            // 
            // NGAYHETHAN
            // 
            this.NGAYHETHAN.DataPropertyName = "MADOCGIA";
            this.NGAYHETHAN.HeaderText = "Đọc Giả";
            this.NGAYHETHAN.Name = "NGAYHETHAN";
            // 
            // CTMUONTRA
            // 
            this.CTMUONTRA.DataPropertyName = "CTMUONTRA";
            this.CTMUONTRA.HeaderText = "CT Mượn Trả";
            this.CTMUONTRA.Name = "CTMUONTRA";
            // 
            // FrmTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTheThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thẻ Thư Viện";
            this.Load += new System.EventHandler(this.FrmTheThuVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheThuVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayLapThe;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.DateTimePicker dateNgayHetHan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTheThuVien;
        private System.Windows.Forms.ComboBox cbbDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAPTHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHETHANJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHETHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMUONTRA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCTMuonTra;
        private System.Windows.Forms.Label label7;
    }
}