using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyThuVienModel
    {
        public string TenThuVien { get; set; }
        public int LoaiThuVienID { get; set; }
        public int ThuTuHienThi { get; set; }
    }
    public class QuanLyThuVienModelSua
    {
        public int ID{ get; set; }
        public string TenThuVien { get; set; }
        public int LoaiThuVienID { get; set; }
        public int ThuTuHienThi { get; set; }
    }
    public class QuanLyThuVienModelDanhSach
    {
        public int ID{ get; set; }
        public string TenThuVien { get; set; }
        public int LoaiThuVienID { get; set; }
        public string TenLoaiThuVien{ get; set; }
        public int ThuTuHienThi { get; set; }
        public int NguoiDungID{ get; set; }
    }
    public class FiltersQuanLyThuVien:ThamSoLocDanhMuc
    {
        public int? NguoiDungID { get; set; }
    }
}
