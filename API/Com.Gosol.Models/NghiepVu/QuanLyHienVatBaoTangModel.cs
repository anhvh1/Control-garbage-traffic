using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyHienVatBaoTangModel
    {
        public string TenHienVat { get; set; }
        public string SoHieu { get; set; }
        public string NienDai { get; set; }
        public int BaoTangID { get; set; }
    }
    public class QuanLyHienVatBaoTangModelSua
    {
        public int ID { get; set; }
        public string TenHienVat { get; set; }
        public string SoHieu { get; set; }
        public string NienDai { get; set; }
        public int BaoTangID { get; set; }
    } 
    public class QuanLyHienVatBaoTangModelDanhSach
    {
        public int ID { get; set; }
        public string TenHienVat { get; set; }
        public string SoHieu { get; set; }
        public string NienDai { get; set; }
        public int BaoTangID { get; set; }
        public string TenBaoTang { get; set; }
        public int NguoiDungID { get; set; }
        public string UrlFile { get; set; }
        public string TenFileGoc { get; set; }
    }
    public class Filters : ThamSoLocDanhMuc
    {
        public int? NguoiDungID { get; set; }
        public int? BaoTangID { get; set; }
    }
}
