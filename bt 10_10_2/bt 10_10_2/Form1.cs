using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bt_10_10_2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<DichVu>> dsDichVu = new Dictionary<string, List<DichVu>>();

        public Form1()
        {
            InitializeComponent();
            DangKySuKien();
        }

        // Tự động gán sự kiện cho các Control
        private void DangKySuKien()
        {
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            btnSelect.Click += btnSelect_Click;
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Click += btnClearAll_Click;
            nudChietKhau.ValueChanged += nudChietKhau_ValueChanged;

            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            lstSelectedServices.DoubleClick += lstSelectedServices_DoubleClick;
        }

        // Khởi tạo danh sách dịch vụ khi Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            dsDichVu.Add("Khám bệnh", new List<DichVu>
            {
                new DichVu("Khám tổng quát", 150000),
                new DichVu("Khám chuyên khoa", 250000),
                new DichVu("Khám VIP", 500000)
            });

            dsDichVu.Add("Xét nghiệm", new List<DichVu>
            {
                new DichVu("Xét nghiệm máu tổng phân tích", 120000),
                new DichVu("Xét nghiệm đường huyết", 80000),
                new DichVu("Xét nghiệm chức năng gan/thận", 200000)
            });

            dsDichVu.Add("Chụp X-Quang", new List<DichVu>
            {
                new DichVu("Chụp X-Quang Phổi", 180000),
                new DichVu("Chụp X-Quang Cột sống", 220000),
                new DichVu("Chụp X-Quang Tứ chi", 150000)
            });

            dsDichVu.Add("Vắc-xin", new List<DichVu>
            {
                new DichVu("Vắc-xin Cúm mùa", 350000),
                new DichVu("Vắc-xin Viêm gan B", 250000),
                new DichVu("Vắc-xin Dại", 400000)
            });

            cboCategory.Items.Clear();
            foreach (var category in dsDichVu.Keys)
            {
                cboCategory.Items.Add(category);
            }

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        // Thay đổi loại dịch vụ -> Load vào lstAvailableServices
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem == null) return;

            string selectedCategory = cboCategory.SelectedItem.ToString();
            if (dsDichVu.ContainsKey(selectedCategory))
            {
                foreach (var dv in dsDichVu[selectedCategory])
                {
                    lstAvailableServices.Items.Add(dv);
                }
            }
        }

        // Thêm dịch vụ chọn
        private void ChuyenDichVuSangDaChon()
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                DichVu selectedDv = (DichVu)lstAvailableServices.SelectedItem;
                lstSelectedServices.Items.Add(selectedDv);
                TinhTongTien();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) => ChuyenDichVuSangDaChon();

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e) => ChuyenDichVuSangDaChon();

        // Xóa dịch vụ đã chọn
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                TinhTongTien();
            }
        }

        private void lstSelectedServices_DoubleClick(object sender, EventArgs e) => btnRemove_Click(sender, e);

        // Xóa tất cả dịch vụ đã chọn
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhTongTien();
        }

        // Tính toán lại tổng tiền và thành tiền
        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DichVu dv in lstSelectedServices.Items)
            {
                tongTien += dv.DonGia;
            }

            decimal chietKhau = nudChietKhau.Value;
            decimal thanhTien = tongTien * (1 - chietKhau / 100);

            txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            txtThanhTien.Text = thanhTien.ToString("N0") + " VNĐ";
        }

        private void nudChietKhau_ValueChanged(object sender, EventArgs e) => TinhTongTien();

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
