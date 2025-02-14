using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyDiSanVanHoaPhiVatTheModel
    {
        public string TenDiSan { get; set; }
        public int DanhMucID { get; set; }     
    }
    public class QuanLyDiSanVanHoaPhiVatTheModelSua
    {
        public int ID { get; set; }
        public string TenDiSan { get; set; }
        public int DanhMucID { get; set; }     
    }
    public class QuanLyDiSanVanHoaPhiVatTheModelDanhSach
    {
        public int ID { get; set; }
        public string TenDiSan { get; set; }
        public int DanhMucID { get; set; }
        public string TenDanhMuc { get; set; }
        public int NguoiDungID { get; set; }
        public string UrlFile { get; set; }
        public string TenFileGoc { get; set; }
    }
}
