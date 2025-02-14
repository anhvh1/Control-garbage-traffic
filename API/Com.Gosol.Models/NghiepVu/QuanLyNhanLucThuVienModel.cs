using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyNhanLucThuVienModel
    {
        public string TenNhanVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
        public int ThuVienID { get; set; }
        public string SoDienThoai { get; set; }
        public bool TrangThai { get; set; }
       

    }
    public class QuanLyNhanLucThuVienModelImport
    {
        public string TenNhanVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
        public int ThuVienID { get; set; }
        public string SoDienThoai { get; set; }
        public bool TrangThai { get; set; }
        public string ErrorMess { get; set; }
        public bool FileMau { get; set; }
    }
    public class QuanLyNhanLucThuVienModelSua
    {
        public int NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
        public int ThuVienID { get; set; }
        public string SoDienThoai { get; set; }
        public bool TrangThai { get; set; }

    }
    public class QuanLyNhanLucThuVienModelDanhSach
    {
        public int NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public int ThuVienID { get; set; }
        public string TenThuVien { get; set; }
        public string SoDienThoai { get; set; }
        public bool TrangThai { get; set; }
        public int NguoiDungID { get; set; }

    }
    public class FiltersQuanLyNhanLucThuVien : ThamSoLocDanhMuc
    {
        public int? NguoiDungID { get; set; }
        public int? ThuVienID { get; set; }
    }
    
}
