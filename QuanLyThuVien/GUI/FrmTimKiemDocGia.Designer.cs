namespace QuanLyThuVien.GUI
{
    partial class FrmTimKiemDocGia
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
            this.dataGridViewTimKiemDocGia = new System.Windows.Forms.DataGridView();
            this.cbbDocGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTimKiemDocGia
            // 
            this.dataGridViewTimKiemDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewTimKiemDocGia.Location = new System.Drawing.Point(13, 11);
            this.dataGridViewTimKiemDocGia.Name = "dataGridViewTimKiemDocGia";
            this.dataGridViewTimKiemDocGia.Size = new System.Drawing.Size(444, 149);
            this.dataGridViewTimKiemDocGia.TabIndex = 0;
            this.dataGridViewTimKiemDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimKiemDocGia_CellClick);
            this.dataGridViewTimKiemDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTimKiemDocGia_CellContentClick);
            // 
            // cbbDocGia
            // 
            this.cbbDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDocGia.FormattingEnabled = true;
            this.cbbDocGia.Items.AddRange(new object[] {
            "Mã Đọc Giả",
            "Họ Tên",
            "Số Điện Thoại",
            "Email"});
            this.cbbDocGia.Location = new System.Drawing.Point(37, 175);
            this.cbbDocGia.Name = "cbbDocGia";
            this.cbbDocGia.Size = new System.Drawing.Size(211, 28);
            this.cbbDocGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ Cần Tìm";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(109, 218);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(139, 20);
            this.txtTu.TabIndex = 3;
            this.txtTu.TextChanged += new System.EventHandler(this.txtTu_TextChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADOCGIA";
            this.Column1.HeaderText = "Mã Đọc Giả";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EMAIL";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(286, 198);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // FrmTimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 256);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDocGia);
            this.Controls.Add(this.dataGridViewTimKiemDocGia);
            this.Name = "FrmTimKiemDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemDocGia";
            this.Load += new System.EventHandler(this.FrmTimKiemDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimKiemDocGia;
        private System.Windows.Forms.ComboBox cbbDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnLamLai;
    }
}