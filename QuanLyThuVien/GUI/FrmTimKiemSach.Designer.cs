namespace QuanLyThuVien.GUI
{
    partial class FrmTimKiemSach
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
            this.txtTu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.dataGridViewTimKiemSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(98, 210);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(139, 20);
            this.txtTu.TabIndex = 7;
            this.txtTu.TextChanged += new System.EventHandler(this.txtTu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Cần Tìm";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã Sách",
            "Tên Sách",
            "Thể Loại",
            "Nhà Xuất Bản",
            "Tác Giả",
            "Năm Xuất Bản",
            "Số Trang"});
            this.cbbTimKiem.Location = new System.Drawing.Point(26, 167);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(211, 28);
            this.cbbTimKiem.TabIndex = 5;
            // 
            // dataGridViewTimKiemSach
            // 
            this.dataGridViewTimKiemSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewTimKiemSach.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewTimKiemSach.Name = "dataGridViewTimKiemSach";
            this.dataGridViewTimKiemSach.Size = new System.Drawing.Size(601, 149);
            this.dataGridViewTimKiemSach.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASACH";
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSACH";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "THELOAI";
            this.Column3.HeaderText = "Thể Loại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NXB";
            this.Column4.HeaderText = "Nhà Xuất Bản";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TACGIA";
            this.Column5.HeaderText = "Tác Giả";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NAMXUATBAN";
            this.Column6.HeaderText = "Năm Xuất Bản";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SOTRANG";
            this.Column7.HeaderText = "Số Trang";
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Làm Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.dataGridViewTimKiemSach);
            this.Name = "FrmTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTimKiemSach";
            this.Load += new System.EventHandler(this.FrmTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewTimKiemSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button1;
    }
}