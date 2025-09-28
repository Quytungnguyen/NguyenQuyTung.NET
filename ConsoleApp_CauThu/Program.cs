using System;
using System.Collections.Generic;
using System.IO;
using Lib_CauThu;
using Newtonsoft.Json;
using System.Text;

namespace ConsoleApp_CauThu
{
    class Program
    {
        static List<CauThu> dsDeCu = new List<CauThu>();
        static List<CauThu> dsYeuThich = new List<CauThu>();

        static void Main(string[] args)
        {
            // Thiết lập encoding UTF-8 để hiển thị tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            LoadDanhSach();

            HienThiDanhSachDeCu();

            ChonCauThuYeuThich();

            HienThiDanhSachYeuThich();

            int chemistry = TinhChemistry(dsYeuThich);
            Console.WriteLine($"\nTổng điểm Chemistry của bạn: {chemistry}");

            // Random cầu thủ thắng giải
            Random rnd = new Random();
            CauThu winner = dsDeCu[rnd.Next(dsDeCu.Count)];

            Console.WriteLine($"\nCầu thủ giành giải TOTY là: {winner.Ten} ({winner.CLB.TenCLB})");

            // Kiểm tra xem người dùng có chọn đúng không
            bool trung = dsYeuThich.Exists(ct => ct.SoAo == winner.SoAo);
            if (trung)
                Console.WriteLine("Chúc mừng! Cầu thủ bạn yêu thích đã giành TOTY!");
            else
                Console.WriteLine("Tiếc quá, cầu thủ bạn chọn không giành giải.");

            Console.ReadLine();
        }

        static void LoadDanhSach()
        {
            string path = @"D:\Project\NguyenQuyTung_DotNet\DotNet_Project\Project_Resource\DanhSachCauThu.json";
            if (!File.Exists(path))
            {
                Console.WriteLine("Không tìm thấy file danh sách cầu thủ!");
                Environment.Exit(0);
            }

            string json = File.ReadAllText(path, Encoding.UTF8); // đọc file với UTF-8
            dsDeCu = JsonConvert.DeserializeObject<List<CauThu>>(json);
        }

        static void HienThiDanhSachDeCu()
        {
            Console.WriteLine("=== DANH SÁCH ĐỀ CỬ TOTY ===");
            foreach (var ct in dsDeCu)
            {
                Console.WriteLine($"{ct.SoAo}. {ct.Ten} - {ct.ViTri} - {ct.QuocTich} - {ct.CLB.TenCLB}");
            }
        }

        static void ChonCauThuYeuThich()
        {
            Console.WriteLine("\nChọn tối đa 3 cầu thủ yêu thích (nhập số áo, cách nhau bởi dấu phẩy): ");
            string input = Console.ReadLine();
            string[] nums = input.Split(',');

            for (int i = 0; i < nums.Length && i < 3; i++)
            {
                if (int.TryParse(nums[i].Trim(), out int soAo))
                {
                    CauThu ct = dsDeCu.Find(c => c.SoAo == soAo);
                    if (ct != null && !dsYeuThich.Exists(x => x.SoAo == soAo))
                    {
                        dsYeuThich.Add(ct);
                    }
                }
            }
        }

        static void HienThiDanhSachYeuThich()
        {
            Console.WriteLine("\n=== DANH SÁCH YÊU THÍCH ===");
            if (dsYeuThich.Count == 0)
            {
                Console.WriteLine("Bạn chưa chọn cầu thủ nào.");
                return;
            }

            foreach (var ct in dsYeuThich)
            {
                Console.WriteLine(ct.HienThiThongTin());
                Console.WriteLine("----------------------");
            }
        }

        static int TinhChemistry(List<CauThu> list)
        {
            int score = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].CLB.TenCLB == list[j].CLB.TenCLB) score += 10;
                    if (list[i].QuocTich == list[j].QuocTich) score += 5;
                    if (CungTuyen(list[i].ViTri, list[j].ViTri)) score += 3;
                }
            }
            return score;
        }

        static bool CungTuyen(string v1, string v2)
        {
            string[] attack = { "ST", "CF", "LW", "RW" };
            string[] mid = { "CM", "CAM", "CDM", "LM", "RM" };
            string[] def = { "CB", "LB", "RB" };

            if (Array.Exists(attack, p => p == v1) && Array.Exists(attack, p => p == v2)) return true;
            if (Array.Exists(mid, p => p == v1) && Array.Exists(mid, p => p == v2)) return true;
            if (Array.Exists(def, p => p == v1) && Array.Exists(def, p => p == v2)) return true;
            return false;
        }
    }
}
