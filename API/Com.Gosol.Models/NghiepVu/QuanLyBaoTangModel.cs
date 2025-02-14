using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyBaoTangModel
    {
        public string TenBaoTang { get; set; }
        public string DiaChi { get; set; }

    }
    public class QuanLyBaoTangModelSua
    {
        public int ID { get; set; }
        public string TenBaoTang { get; set; }
        public string DiaChi { get; set; }

    }
    public class QuanLyBaoTangModelDanhSach
    {
        public int ID { get; set; }
        public string TenBaoTang { get; set; }
        public string DiaChi { get; set; }
        public int NguoiDungID { get; set; }
        public string UrlFile { get; set; }
        public string TenFileGoc { get; set; }

    }
    public class FiltersDanhSach : ThamSoLocDanhMuc
    {
        public int? NguoiDungID { get; set; }
    }
    public class DanhSachCoQuanCha
    {
        public int CoQuanChaID { get; set; }
        public int CoQuanID { get; set; }
        
    }
    
}
