namespace QuanLyThuVien.GUI
{
    partial class FrmThongKe
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
            this.btnTKSach = new System.Windows.Forms.Button();
            this.btnTKDocGia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTKSach
            // 
            this.btnTKSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSach.Location = new System.Drawing.Point(48, 53);
            this.btnTKSach.Name = "btnTKSach";
            this.btnTKSach.Size = new System.Drawing.Size(169, 32);
            this.btnTKSach.TabIndex = 0;
            this.btnTKSach.Text = "Thống Kê Sách";
            this.btnTKSach.UseVisualStyleBackColor = true;
            this.btnTKSach.Click += new System.EventHandler(this.btnTKSach_Click);
            // 
            // btnTKDocGia
            // 
            this.btnTKDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKDocGia.Location = new System.Drawing.Point(249, 53);
            this.btnTKDocGia.Name = "btnTKDocGia";
            this.btnTKDocGia.Size = new System.Drawing.Size(169, 32);
            this.btnTKDocGia.TabIndex = 0;
            this.btnTKDocGia.Text = "Thống Kê Đọc Giả";
            this.btnTKDocGia.UseVisualStyleBackColor = true;
            this.btnTKDocGia.Click += new System.EventHandler(this.btnTKDocGia_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 139);
            this.Controls.Add(this.btnTKDocGia);
            this.Controls.Add(this.btnTKSach);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTKSach;
        private System.Windows.Forms.Button btnTKDocGia;
    }
}