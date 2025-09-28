namespace Lib_CauThu
{
    public class CauThu
    {
        public int SoAo { get; set; }
        public string Ten { get; set; }
        public string QuocTich { get; set; }
        public string ViTri { get; set; }
        public CauLacBo CLB { get; set; }
        public string Anh { get; set; } // đường dẫn ảnh (PNG/JPG)

        public CauThu(int soAo, string ten, string quocTich, string viTri, CauLacBo clb, string anh)
        {
            SoAo = soAo;
            Ten = ten;
            QuocTich = quocTich;
            ViTri = viTri;
            CLB = clb;
            Anh = anh;
        }

        public string HienThiThongTin()
        {
            return $"{SoAo}. {Ten} - {ViTri} - {QuocTich} - {CLB.TenCLB}";
        }
    }

    public class CauLacBo
    {
        public string TenCLB { get; set; }
    }
}
