using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace B2
{
    public partial class Form1 : Form
    {
        List<HocVien> hocViens = new List<HocVien>();
        List<LopHoc> lopHocs = new List<LopHoc>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoListBox();
            KhoiTaoCombobox();
        }

        private void KhoiTaoCombobox()
        {
            cboLop.DisplayMember = "TenLH";
            cboLop.ValueMember = "MaLH";
            cboLop.DataSource = lopHocs;
        }

        private void KhoiTaoListBox()
        {
            lstHV.DataSource = null;
            lstHV.DisplayMember = "HoTen";
            lstHV.ValueMember = "MaHV";
            lstHV.DataSource = hocViens;
        }

        private void KhoiTaoDuLieu()
        {
            DocHocVien();
            DocLopHoc();
        }

        private void DocHocVien()
        {
            string filePath = @"..\..\Dulieu\HocVien" + ".txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string chuoiSV = line;
                string[] mangthanhPhan = chuoiSV.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                HocVien hv = new HocVien();
                hv.MaHV= mangthanhPhan[0];
                hv.HoTen = mangthanhPhan[1];
                hv.GT = mangthanhPhan[2].ToUpper() == "Nam" ? true : false;
                DateTime ngaySinh;
                DateTime.TryParseExact(mangthanhPhan[3], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh);
                hv.NgaySinh = ngaySinh;
                hv.DiaChi = mangthanhPhan[4];
                hv.MaLH = mangthanhPhan[5];
                hocViens.Add(hv);
            }
        }

        private void DocLopHoc()
        {
            string filePath = @"..\..\Dulieu\LopHoc" + ".txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string chuoiSV = line;
                string[] mangthanhPhan = chuoiSV.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                LopHoc lh = new LopHoc();
                lh.MaLH = mangthanhPhan[0];
                lh.TenLH = mangthanhPhan[1];
                lopHocs.Add(lh);
            }
        }

        private void lstHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHV.SelectedIndex == -1) return;
            HocVien hv = lstHV.SelectedItem as HocVien;
            txtMaHV.Text = hv.MaHV;
            txtHoTen.Text = hv.HoTen;
            txtGioiTinh.Text = hv.GT ? "Nam" : "Nữ";
            txtDiaCho.Text = hv.DiaChi;
            txtNgaySinh.Text = hv.NgaySinh.ToString("dd/MM/yyyy");
            cboLop.SelectedValue = hv.MaLH;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach(Control ctl in grpHV.Controls)
            {
                if( ctl is TextBox)
                {
                    (ctl as TextBox).Clear();
                }
            }
            txtMaHV.ReadOnly = false;
            cboLop.Enabled = true;
            txtMaHV.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            if (!txtMaHV.ReadOnly)
            {
                hv.MaHV = txtMaHV.Text;
                hv.HoTen = txtHoTen.Text;
                hv.GT = txtGioiTinh.Text.ToUpper() == "NAM" ? true : false;
                //hv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                hv.NgaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                hv.MaLH = cboLop.SelectedValue.ToString();
                hv.DiaChi = txtDiaCho.Text;
                txtMaHV.ReadOnly = true;
                hocViens.Add(hv);
            }
            else
            {
                hv = lstHV.SelectedItem as HocVien;
                hv.HoTen = txtHoTen.Text;
                hv.GT = txtGioiTinh.Text.ToUpper() == "NAM" ? true : false;
                hv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                hv.DiaChi = txtDiaCho.Text;
            }
            GhiHocVien();
            KhoiTaoListBox();
            lstHV.SelectedIndex = lstHV.Items.IndexOf(hv);
        }

        private void GhiHocVien()
        {
            string filePath = @"..\..\Dulieu\HocVien" + ".txt";
            string[] mangghi = new string[hocViens.Count];
            for (int i = 0; i < hocViens.Count; i++)
            {
                // Lấy sinh viên tại vị trí i
                HocVien hv = hocViens[i];
                string gioitinh;
                if (hv.GT)
                {
                    gioitinh = "Nam";
                }
                {
                    gioitinh = "Nữ";
                }
                string ngaysinh = hv.NgaySinh.ToString();
                mangghi[i] = $"{hv.MaHV};{hv.HoTen};{gioitinh};{ngaysinh};{hv.DiaChi};{hv.MaLH}";
            }
            File.WriteAllLines(filePath, mangghi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstHV.SelectedIndex == -1) return;

            DialogResult kq = MessageBox.Show("Ban co chac muon xoa sinh vien dang chon", "Canh Bao", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == kq)
            {
                hocViens.Remove(lstHV.SelectedItem as HocVien);
                GhiHocVien();
                KhoiTaoListBox();
                lstHV.SelectedIndex = 0;
                KhoiTaoListBox();

            }
        }
    }
}
