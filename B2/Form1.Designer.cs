
namespace B2
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpHV = new System.Windows.Forms.GroupBox();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDiaCho = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lstHV = new System.Windows.Forms.ListBox();
            this.grpHV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(2, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp";
            // 
            // grpHV
            // 
            this.grpHV.Controls.Add(this.btnTiep);
            this.grpHV.Controls.Add(this.btnXoa);
            this.grpHV.Controls.Add(this.btnCapNhat);
            this.grpHV.Controls.Add(this.txtDiaCho);
            this.grpHV.Controls.Add(this.txtNgaySinh);
            this.grpHV.Controls.Add(this.txtGioiTinh);
            this.grpHV.Controls.Add(this.txtHoTen);
            this.grpHV.Controls.Add(this.txtMaHV);
            this.grpHV.Controls.Add(this.label7);
            this.grpHV.Controls.Add(this.label6);
            this.grpHV.Controls.Add(this.label5);
            this.grpHV.Controls.Add(this.label4);
            this.grpHV.Controls.Add(this.label3);
            this.grpHV.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHV.ForeColor = System.Drawing.Color.Blue;
            this.grpHV.Location = new System.Drawing.Point(380, 69);
            this.grpHV.Name = "grpHV";
            this.grpHV.Size = new System.Drawing.Size(405, 402);
            this.grpHV.TabIndex = 1;
            this.grpHV.TabStop = false;
            this.grpHV.Text = "Thông tin học viên";
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(302, 328);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(97, 42);
            this.btnTiep.TabIndex = 2;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(176, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(27, 328);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 42);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDiaCho
            // 
            this.txtDiaCho.ForeColor = System.Drawing.Color.Black;
            this.txtDiaCho.Location = new System.Drawing.Point(158, 253);
            this.txtDiaCho.Name = "txtDiaCho";
            this.txtDiaCho.Size = new System.Drawing.Size(241, 33);
            this.txtDiaCho.TabIndex = 1;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.txtNgaySinh.Location = new System.Drawing.Point(158, 199);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(241, 33);
            this.txtNgaySinh.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.txtGioiTinh.Location = new System.Drawing.Point(158, 145);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(241, 33);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(158, 91);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(241, 33);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaHV
            // 
            this.txtMaHV.ForeColor = System.Drawing.Color.Black;
            this.txtMaHV.Location = new System.Drawing.Point(158, 37);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(241, 33);
            this.txtMaHV.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(22, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(22, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(22, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên HV";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(22, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HV";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH HỌC VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboLop
            // 
            this.cboLop.AllowDrop = true;
            this.cboLop.Enabled = false;
            this.cboLop.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboLop.Location = new System.Drawing.Point(120, 76);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(242, 33);
            this.cboLop.TabIndex = 2;
            // 
            // lstHV
            // 
            this.lstHV.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHV.ForeColor = System.Drawing.Color.Blue;
            this.lstHV.FormattingEnabled = true;
            this.lstHV.ItemHeight = 25;
            this.lstHV.Location = new System.Drawing.Point(12, 127);
            this.lstHV.Name = "lstHV";
            this.lstHV.Size = new System.Drawing.Size(349, 354);
            this.lstHV.TabIndex = 3;
            this.lstHV.SelectedIndexChanged += new System.EventHandler(this.lstHV_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lstHV);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.grpHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHV.ResumeLayout(false);
            this.grpHV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtDiaCho;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.ListBox lstHV;
    }
}

