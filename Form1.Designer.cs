namespace WF_Homewoke_b4
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
            this.lblQLSV = new System.Windows.Forms.Label();
            this.dtgStudents = new System.Windows.Forms.DataGridView();
            this.lblTongSVNam = new System.Windows.Forms.Label();
            this.lblTongSVNu = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btbThemSua = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.grbQLSV = new System.Windows.Forms.GroupBox();
            this.txtTongSVNam = new System.Windows.Forms.TextBox();
            this.txtTongSVNu = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).BeginInit();
            this.grbQLSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLSV
            // 
            this.lblQLSV.AutoSize = true;
            this.lblQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLSV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblQLSV.Location = new System.Drawing.Point(254, 20);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(367, 31);
            this.lblQLSV.TabIndex = 0;
            this.lblQLSV.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // dtgStudents
            // 
            this.dtgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudents.Location = new System.Drawing.Point(363, 83);
            this.dtgStudents.Name = "dtgStudents";
            this.dtgStudents.RowHeadersWidth = 51;
            this.dtgStudents.RowTemplate.Height = 24;
            this.dtgStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStudents.Size = new System.Drawing.Size(530, 292);
            this.dtgStudents.TabIndex = 13;
            this.dtgStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStudents_CellContentClick);
            // 
            // lblTongSVNam
            // 
            this.lblTongSVNam.AutoSize = true;
            this.lblTongSVNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSVNam.Location = new System.Drawing.Point(600, 403);
            this.lblTongSVNam.Name = "lblTongSVNam";
            this.lblTongSVNam.Size = new System.Drawing.Size(101, 18);
            this.lblTongSVNam.TabIndex = 16;
            this.lblTongSVNam.Text = "Tổng SV Nam";
            // 
            // lblTongSVNu
            // 
            this.lblTongSVNu.AutoSize = true;
            this.lblTongSVNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongSVNu.Location = new System.Drawing.Point(796, 403);
            this.lblTongSVNu.Name = "lblTongSVNu";
            this.lblTongSVNu.Size = new System.Drawing.Size(27, 18);
            this.lblTongSVNu.TabIndex = 18;
            this.lblTongSVNu.Text = "Nữ";
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Location = new System.Drawing.Point(260, 390);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(86, 30);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btbThemSua
            // 
            this.btbThemSua.AutoSize = true;
            this.btbThemSua.Location = new System.Drawing.Point(145, 391);
            this.btbThemSua.Name = "btbThemSua";
            this.btbThemSua.Size = new System.Drawing.Size(105, 30);
            this.btbThemSua.TabIndex = 28;
            this.btbThemSua.Text = "Thêm / Sửa";
            this.btbThemSua.UseVisualStyleBackColor = true;
            this.btbThemSua.Click += new System.EventHandler(this.btbThemSua_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSV.Location = new System.Drawing.Point(21, 39);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(90, 18);
            this.lblMaSV.TabIndex = 17;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(133, 39);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(124, 27);
            this.txtMSV.TabIndex = 18;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(21, 84);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 18);
            this.lblHoTen.TabIndex = 19;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(133, 80);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(184, 27);
            this.txtHoTen.TabIndex = 20;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(21, 129);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(62, 18);
            this.lblGioiTinh.TabIndex = 21;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(133, 129);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(65, 24);
            this.radNam.TabIndex = 22;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(212, 129);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(51, 24);
            this.radNu.TabIndex = 23;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemTB.Location = new System.Drawing.Point(21, 180);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(66, 18);
            this.lblDiemTB.TabIndex = 24;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(133, 179);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(75, 27);
            this.txtDiemTB.TabIndex = 25;
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuyenNganh.Location = new System.Drawing.Point(21, 232);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(102, 18);
            this.lblChuyenNganh.TabIndex = 26;
            this.lblChuyenNganh.Text = "Chuyên ngành";
            // 
            // cbbNganh
            // 
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "Sư Phạm",
            "Marketing",
            "Du Lịch",
            "Kỹ Thuật Ô Tô"});
            this.cbbNganh.Location = new System.Drawing.Point(133, 226);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(121, 28);
            this.cbbNganh.TabIndex = 27;
            // 
            // grbQLSV
            // 
            this.grbQLSV.Controls.Add(this.cbbNganh);
            this.grbQLSV.Controls.Add(this.lblChuyenNganh);
            this.grbQLSV.Controls.Add(this.txtDiemTB);
            this.grbQLSV.Controls.Add(this.lblDiemTB);
            this.grbQLSV.Controls.Add(this.radNu);
            this.grbQLSV.Controls.Add(this.radNam);
            this.grbQLSV.Controls.Add(this.lblGioiTinh);
            this.grbQLSV.Controls.Add(this.txtHoTen);
            this.grbQLSV.Controls.Add(this.lblHoTen);
            this.grbQLSV.Controls.Add(this.txtMSV);
            this.grbQLSV.Controls.Add(this.lblMaSV);
            this.grbQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbQLSV.Location = new System.Drawing.Point(12, 83);
            this.grbQLSV.Name = "grbQLSV";
            this.grbQLSV.Size = new System.Drawing.Size(331, 292);
            this.grbQLSV.TabIndex = 21;
            this.grbQLSV.TabStop = false;
            this.grbQLSV.Text = "Thông tin sinh viên";
            // 
            // txtTongSVNam
            // 
            this.txtTongSVNam.Location = new System.Drawing.Point(707, 402);
            this.txtTongSVNam.Name = "txtTongSVNam";
            this.txtTongSVNam.ReadOnly = true;
            this.txtTongSVNam.Size = new System.Drawing.Size(83, 22);
            this.txtTongSVNam.TabIndex = 28;
            // 
            // txtTongSVNu
            // 
            this.txtTongSVNu.Location = new System.Drawing.Point(829, 403);
            this.txtTongSVNu.Name = "txtTongSVNu";
            this.txtTongSVNu.ReadOnly = true;
            this.txtTongSVNu.Size = new System.Drawing.Size(83, 22);
            this.txtTongSVNu.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.txtTongSVNu);
            this.Controls.Add(this.txtTongSVNam);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.grbQLSV);
            this.Controls.Add(this.btbThemSua);
            this.Controls.Add(this.lblTongSVNu);
            this.Controls.Add(this.lblTongSVNam);
            this.Controls.Add(this.dtgStudents);
            this.Controls.Add(this.lblQLSV);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).EndInit();
            this.grbQLSV.ResumeLayout(false);
            this.grbQLSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLSV;
        private System.Windows.Forms.DataGridView dtgStudents;
        private System.Windows.Forms.Label lblTongSVNam;
        private System.Windows.Forms.Label lblTongSVNu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btbThemSua;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.ComboBox cbbNganh;
        private System.Windows.Forms.GroupBox grbQLSV;
        private System.Windows.Forms.TextBox txtTongSVNam;
        private System.Windows.Forms.TextBox txtTongSVNu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

