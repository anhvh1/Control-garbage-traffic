using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyDiTichToanTinhModelThem
    {            
        public string TenDiTich { get; set; }
        public int LoaiDiTich { get; set; }
        public bool DaDuocXepHang { get; set; }
        public int? CapXepHang { get; set; }
        public string DiaDiem { get; set; }
        public string ThongTinQuyetDinh { get; set; }
        public DateTime? NgayQuyetDinh { get; set; }
    }
    public class QuanLyDiTichToanTinhModelSua
    {
        public  int ID { get; set; }
        public string TenDiTich { get; set; }
        public int LoaiDiTich { get; set; }
        public bool DaDuocXepHang { get; set; }
        public int? CapXepHang { get; set; }
        public string DiaDiem { get; set; }
        public string ThongTinQuyetDinh { get; set; }
        public DateTime? NgayQuyetDinh { get; set; }
    }
    public class QuanLyDiTichToanTinhModelDanhSach
    {
        public int ID { get; set; }
        public string TenDiTich { get; set; }
        public int LoaiDiTich { get; set; }
        public string TenLoaiDiTich { get; set; }
        public bool DaDuocXepHang { get; set; }
        public int CapXepHang { get; set; }
        public string TenCapXepHang { get; set; }
        public string DiaDiem { get; set; }
        public string ThongTinQuyetDinh { get; set; }
        public string NgayQuyetDinh { get; set; }
        public int NguoiDungID { get; set; }
        public string UrlFile { get;set; }
        public string TenFileGoc { get; set; }
    }
    public class Filter :ThamSoLocDanhMuc
    {
        public int? CapXepHang { get; set; }
        public int? LoaiDiTich { get; set; }
        public int? NamXepHang { get; set; }
    }
}
