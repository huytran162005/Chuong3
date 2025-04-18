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


namespace Chuong3
{
    public partial class Form1 : Form
    {
        List<SinhVien> sinhViens = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DocSinhVien();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
            lstSinhVien.DataSource = null;
            lstSinhVien.DisplayMember = "HoTen";
            lstSinhVien.ValueMember = "MaSV";
            lstSinhVien.DataSource = sinhViens;
        }

        public void DocSinhVien()
        {
            string filePath = @"..\..\Dulieu\TextFile1"+".txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach(string line in lines)
            {
                string chuoiSV = line;
                string[] mangthanhPhan = chuoiSV.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                SinhVien s = new SinhVien();
                s.MaSV = int.Parse(mangthanhPhan[0]);
                s.HoTen = mangthanhPhan[1];
                s.HocBong =int.Parse(mangthanhPhan[2]);
                sinhViens.Add(s);
            }
        }
        public void GhiSinhVien()
        {
            string filePath = @"..\..\Dulieu\TextFile1" + ".txt";
            string[] mangghi = new string[sinhViens.Count];
            for (int i = 0; i < sinhViens.Count; i++)
            {
                // Lấy sinh viên tại vị trí i
                SinhVien sv = sinhViens[i];
                mangghi[i] = $"{sv.MaSV},{sv.HoTen},{sv.HocBong}";
            }
            File.WriteAllLines(filePath, mangghi);
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1) return;
            SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
            txtMasv.Text = sv.MaSV.ToString();
            txtHoTen.Text = sv.HoTen;
            txtHocBong.Text = sv.HocBong.ToString("#,##0 $");
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv;
            if(!txtMasv.ReadOnly)
            {
                sv = new SinhVien();
                if (string.IsNullOrEmpty(txtMasv.Text)) {
                    MessageBox.Show("Vui long nhap ma sinh vien");
                    txtMasv.Focus();
                    return;
                }
                if (int.TryParse(txtMasv.Text, out int masv) == true)
                {
                    sv.MaSV = masv;
                }
                else
                {
                    MessageBox.Show("Vui long nhập Mã sinh viên là số");
                    txtMasv.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    MessageBox.Show("Vui long nhap Ho ten");
                    txtHoTen.Focus();
                    return;
                }
                else
                {
                    sv.HoTen = txtHoTen.Text;
                }
                if (string.IsNullOrEmpty(txtHocBong.Text))
                {
                    MessageBox.Show("Vui long nhap Hoc bong");
                    txtHocBong.Focus();
                    return;
                    
                }
                if(int.TryParse(txtHocBong.Text, out int hocbong) == true)
                    {
                    sv.HocBong = hocbong;
                }
                    else
                {
                    MessageBox.Show("Vui long nhập Hoc bong là số");
                    txtHocBong.Focus();
                    return;
                }
                sinhViens.Add(sv);
                txtMasv.ReadOnly = true;
                
            }
            else
            {
                sv = lstSinhVien.SelectedItem as SinhVien;
                sv.HoTen = txtHoTen.Text;
                sv.HocBong = int.Parse(txtHocBong.Text.Replace(".", "").Replace("$", ""));

            }
            KhoiTaoListBox();
            lstSinhVien.SelectedIndex = lstSinhVien.Items.IndexOf(sv);
            GhiSinhVien();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach(Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Clear();
                }
                txtMasv.ReadOnly = false;
                txtMasv.Focus();
                
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1) return;
            
            DialogResult kq = MessageBox.Show("Ban co chac muon xoa sinh vien dang chon", "Canh Bao", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == kq) {
                sinhViens.Remove(lstSinhVien.SelectedItem as SinhVien);
                GhiSinhVien();
                KhoiTaoListBox();
                lstSinhVien.SelectedIndex = 0;
            }
            
        }
    }
}
