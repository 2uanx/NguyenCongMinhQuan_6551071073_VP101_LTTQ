namespace NguyenCongMinhQuan_6551071073_VP101_LTTQ
{
    partial class Form1
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaCV = new System.Windows.Forms.Label();
            this.lblTenCV = new System.Windows.Forms.Label();
            this.lblLuongThang = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtLuongThang = new System.Windows.Forms.TextBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(220, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(262, 29);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ CÔNG VIỆC";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaCV);
            this.grpThongTin.Controls.Add(this.lblTenCV);
            this.grpThongTin.Controls.Add(this.lblLuongThang);
            this.grpThongTin.Controls.Add(this.txtMaCV);
            this.grpThongTin.Controls.Add(this.txtTenCV);
            this.grpThongTin.Controls.Add(this.txtLuongThang);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.Location = new System.Drawing.Point(20, 55);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(430, 150);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin công việc";
            // 
            // lblMaCV
            // 
            this.lblMaCV.AutoSize = true;
            this.lblMaCV.Location = new System.Drawing.Point(15, 30);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(100, 18);
            this.lblMaCV.TabIndex = 0;
            this.lblMaCV.Text = "Mã công việc:";
            // 
            // lblTenCV
            // 
            this.lblTenCV.AutoSize = true;
            this.lblTenCV.Location = new System.Drawing.Point(15, 70);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(104, 18);
            this.lblTenCV.TabIndex = 2;
            this.lblTenCV.Text = "Tên công việc:";
            // 
            // lblLuongThang
            // 
            this.lblLuongThang.AutoSize = true;
            this.lblLuongThang.Location = new System.Drawing.Point(15, 110);
            this.lblLuongThang.Name = "lblLuongThang";
            this.lblLuongThang.Size = new System.Drawing.Size(94, 18);
            this.lblLuongThang.TabIndex = 4;
            this.lblLuongThang.Text = "Lương tháng:";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(130, 27);
            this.txtMaCV.MaxLength = 10;
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(280, 24);
            this.txtMaCV.TabIndex = 1;
            this.txtMaCV.TextChanged += new System.EventHandler(this.txtInputs_TextChanged);
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(130, 67);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(280, 24);
            this.txtTenCV.TabIndex = 3;
            this.txtTenCV.TextChanged += new System.EventHandler(this.txtInputs_TextChanged);
            // 
            // txtLuongThang
            // 
            this.txtLuongThang.Location = new System.Drawing.Point(130, 107);
            this.txtLuongThang.MaxLength = 8;
            this.txtLuongThang.Name = "txtLuongThang";
            this.txtLuongThang.Size = new System.Drawing.Size(280, 24);
            this.txtLuongThang.TabIndex = 5;
            this.txtLuongThang.TextChanged += new System.EventHandler(this.txtInputs_TextChanged);
            this.txtLuongThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongThang_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(475, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(590, 65);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(475, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(590, 120);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvCongViec);
            this.grpDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.Location = new System.Drawing.Point(20, 220);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(665, 230);
            this.grpDanhSach.TabIndex = 6;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách công việc";
            // 
            // dgvCongViec
            // 
            this.dgvCongViec.AllowUserToAddRows = false;
            this.dgvCongViec.AllowUserToDeleteRows = false;
            this.dgvCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongViec.Location = new System.Drawing.Point(3, 20);
            this.dgvCongViec.MultiSelect = false;
            this.dgvCongViec.Name = "dgvCongViec";
            this.dgvCongViec.ReadOnly = true;
            this.dgvCongViec.RowHeadersWidth = 30;
            this.dgvCongViec.RowTemplate.Height = 24;
            this.dgvCongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongViec.Size = new System.Drawing.Size(659, 207);
            this.dgvCongViec.TabIndex = 0;
            this.dgvCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongViec_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 465);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công việc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaCV;
        private System.Windows.Forms.Label lblTenCV;
        private System.Windows.Forms.Label lblLuongThang;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtLuongThang;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}