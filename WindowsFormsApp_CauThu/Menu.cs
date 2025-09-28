using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Lib_CauThu;
using Newtonsoft.Json;
using System.Drawing;

namespace WindowsFormsApp_CauThu
{
    public partial class Menu : Form
    {
        private List<CauThu> dsDeCu = new List<CauThu>();
        private CauThu cauThuYeuThich = null; // chỉ 1 cầu thủ

        public Menu()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            // Đường dẫn tới file JSON
            string path = @"D:\Project\NguyenQuyTung_DotNet\DotNet_Project\WindowsFormsApp_CauThu\Resources\DanhSachCauThu.json";
            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy file danh sách cầu thủ!");
                return;
            }

            string json = File.ReadAllText(path, Encoding.UTF8);
            dsDeCu = JsonConvert.DeserializeObject<List<CauThu>>(json);

            dataGridViewCauThu.Rows.Clear();

            // BasePath cho ảnh
            string basePath = @"D:\Project\NguyenQuyTung_DotNet\DotNet_Project\WindowsFormsApp_CauThu";

            foreach (var ct in dsDeCu)
            {
                string imgPath = Path.Combine(basePath, ct.Anh);
                Image img = null;
                if (File.Exists(imgPath))
                {
                    img = Image.FromFile(imgPath);
                }

                dataGridViewCauThu.Rows.Add(img, ct.Ten, ct.ViTri, ct.QuocTich, ct.CLB.TenCLB);
            }
        }

        // Nút xem cầu thủ đã chọn
        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            if (dataGridViewCauThu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn cầu thủ nào!");
                return;
            }

            string ten = dataGridViewCauThu.SelectedRows[0].Cells["colTen"].Value.ToString();
            cauThuYeuThich = dsDeCu.Find(c => c.Ten == ten);

            listBoxYeuThich.Items.Clear();
            if (cauThuYeuThich != null)
            {
                listBoxYeuThich.Items.Add(cauThuYeuThich.HienThiThongTin());
            }
        }

        // Nút kết quả bình chọn (random)
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (dsDeCu.Count == 0) return;

            Random rnd = new Random();
            CauThu winner = dsDeCu[rnd.Next(dsDeCu.Count)];

            // Mở form Champion để hiển thị ảnh + thông tin
            Champion frm = new Champion(winner);
            frm.ShowDialog();

            if (cauThuYeuThich != null && cauThuYeuThich.SoAo == winner.SoAo)
            {
                MessageBox.Show("Chúc mừng! Cầu thủ bạn chọn đã giành TOTY!");
            }
            else
            {
                MessageBox.Show("Tiếc quá, cầu thủ bạn chọn không giành giải.");
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc load thêm gì đó khi form mở
        }
    }
}
