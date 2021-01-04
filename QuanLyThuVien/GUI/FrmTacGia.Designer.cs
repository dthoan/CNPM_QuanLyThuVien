namespace QuanLyThuVien.GUI
{
    partial class FrmTacGia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLaLaiTG = new System.Windows.Forms.Button();
            this.txtXoaTG = new System.Windows.Forms.Button();
            this.txtSuaTG = new System.Windows.Forms.Button();
            this.txtThemTG = new System.Windows.Forms.Button();
            this.dataGridViewTacGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLamLaiNXB = new System.Windows.Forms.Button();
            this.txtXoaNXB = new System.Windows.Forms.Button();
            this.txtSuaNXB = new System.Windows.Forms.Button();
            this.txtThemC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewNXB = new System.Windows.Forms.DataGridView();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenTacGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaTacGia);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridViewTacGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tác Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Tác Giả";
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTacGia.Location = new System.Drawing.Point(139, 255);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(221, 26);
            this.txtTenTacGia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Tác Giả";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTacGia.Location = new System.Drawing.Point(139, 216);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(221, 26);
            this.txtMaTacGia.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLaLaiTG);
            this.groupBox3.Controls.Add(this.txtXoaTG);
            this.groupBox3.Controls.Add(this.txtSuaTG);
            this.groupBox3.Controls.Add(this.txtThemTG);
            this.groupBox3.Location = new System.Drawing.Point(6, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 58);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao Tác Với Tác Giả";
            // 
            // txtLaLaiTG
            // 
            this.txtLaLaiTG.Location = new System.Drawing.Point(279, 19);
            this.txtLaLaiTG.Name = "txtLaLaiTG";
            this.txtLaLaiTG.Size = new System.Drawing.Size(75, 23);
            this.txtLaLaiTG.TabIndex = 0;
            this.txtLaLaiTG.Text = "Làm Lại";
            this.txtLaLaiTG.UseVisualStyleBackColor = true;
            // 
            // txtXoaTG
            // 
            this.txtXoaTG.Location = new System.Drawing.Point(183, 19);
            this.txtXoaTG.Name = "txtXoaTG";
            this.txtXoaTG.Size = new System.Drawing.Size(75, 23);
            this.txtXoaTG.TabIndex = 0;
            this.txtXoaTG.Text = "Xóa";
            this.txtXoaTG.UseVisualStyleBackColor = true;
            // 
            // txtSuaTG
            // 
            this.txtSuaTG.Location = new System.Drawing.Point(102, 19);
            this.txtSuaTG.Name = "txtSuaTG";
            this.txtSuaTG.Size = new System.Drawing.Size(75, 23);
            this.txtSuaTG.TabIndex = 0;
            this.txtSuaTG.Text = "Sửa";
            this.txtSuaTG.UseVisualStyleBackColor = true;
            // 
            // txtThemTG
            // 
            this.txtThemTG.Location = new System.Drawing.Point(6, 19);
            this.txtThemTG.Name = "txtThemTG";
            this.txtThemTG.Size = new System.Drawing.Size(75, 23);
            this.txtThemTG.TabIndex = 0;
            this.txtThemTG.Text = "Thêm";
            this.txtThemTG.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTacGia
            // 
            this.dataGridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTacGia.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewTacGia.Name = "dataGridViewTacGia";
            this.dataGridViewTacGia.Size = new System.Drawing.Size(381, 150);
            this.dataGridViewTacGia.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridViewNXB);
            this.groupBox2.Controls.Add(this.txtTenNXB);
            this.groupBox2.Controls.Add(this.txtMaNXB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(432, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhà Xuất Bản";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLamLaiNXB);
            this.groupBox4.Controls.Add(this.txtXoaNXB);
            this.groupBox4.Controls.Add(this.txtSuaNXB);
            this.groupBox4.Controls.Add(this.txtThemC);
            this.groupBox4.Location = new System.Drawing.Point(15, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao Tác Với Tác Giả";
            // 
            // txtLamLaiNXB
            // 
            this.txtLamLaiNXB.Location = new System.Drawing.Point(279, 19);
            this.txtLamLaiNXB.Name = "txtLamLaiNXB";
            this.txtLamLaiNXB.Size = new System.Drawing.Size(75, 23);
            this.txtLamLaiNXB.TabIndex = 0;
            this.txtLamLaiNXB.Text = "Làm Lại";
            this.txtLamLaiNXB.UseVisualStyleBackColor = true;
            // 
            // txtXoaNXB
            // 
            this.txtXoaNXB.Location = new System.Drawing.Point(183, 19);
            this.txtXoaNXB.Name = "txtXoaNXB";
            this.txtXoaNXB.Size = new System.Drawing.Size(75, 23);
            this.txtXoaNXB.TabIndex = 0;
            this.txtXoaNXB.Text = "Xóa";
            this.txtXoaNXB.UseVisualStyleBackColor = true;
            // 
            // txtSuaNXB
            // 
            this.txtSuaNXB.Location = new System.Drawing.Point(102, 19);
            this.txtSuaNXB.Name = "txtSuaNXB";
            this.txtSuaNXB.Size = new System.Drawing.Size(75, 23);
            this.txtSuaNXB.TabIndex = 0;
            this.txtSuaNXB.Text = "Sửa";
            this.txtSuaNXB.UseVisualStyleBackColor = true;
            // 
            // txtThemC
            // 
            this.txtThemC.Location = new System.Drawing.Point(6, 19);
            this.txtThemC.Name = "txtThemC";
            this.txtThemC.Size = new System.Drawing.Size(75, 23);
            this.txtThemC.TabIndex = 0;
            this.txtThemC.Text = "Thêm";
            this.txtThemC.UseVisualStyleBackColor = true;
            this.txtThemC.Click += new System.EventHandler(this.txtThemC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhà Xuất Bản";
            // 
            // dataGridViewNXB
            // 
            this.dataGridViewNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNXB.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewNXB.Name = "dataGridViewNXB";
            this.dataGridViewNXB.Size = new System.Drawing.Size(381, 150);
            this.dataGridViewNXB.TabIndex = 1;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.Location = new System.Drawing.Point(166, 258);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(203, 26);
            this.txtTenNXB.TabIndex = 2;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.Location = new System.Drawing.Point(166, 219);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(203, 26);
            this.txtMaNXB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Nhà Xuất Bản";
            // 
            // FrmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tác giả - Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FrmTacGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTacGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtLaLaiTG;
        private System.Windows.Forms.Button txtXoaTG;
        private System.Windows.Forms.Button txtSuaTG;
        private System.Windows.Forms.Button txtThemTG;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button txtLamLaiNXB;
        private System.Windows.Forms.Button txtXoaNXB;
        private System.Windows.Forms.Button txtSuaNXB;
        private System.Windows.Forms.Button txtThemC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label3;
    }
}