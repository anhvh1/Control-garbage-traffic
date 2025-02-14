using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyBaoVatQuocGiaModelThemMoi
    {
        public string TenBaoVat { get; set; }
        public string SoHieu { get; set; }
        public string NienDai { get; set; }
        public bool? LaBaoTang { get; set; }
        public int? BaoTangID { get; set; }
        public string TenDonViKhac { get; set; }
        public string DiaPhuong { get; set; }
    }
    public class QuanLyBaoVatQuocGiaModelSua
    {
        public int IDBaoVat { get; set; }
        public string TenBaoVat { get; set; }
        public string SoHieu { get; set; }
        public string NienDai { get; set; }
        public bool? LaBaoTang { get; set; }
        public int? BaoTangID { get; set; }
        public string TenDonViKhac { get; set; }
        public string DiaPhuong { get; set; }
    }
    public class QuanLyBaoVatQuocGiaModelXoa
    {
        public int IDBaoVat { get; set; }
    }
    public class QuanLyBaoVatQuocGiaModelDanhSach
    {
        public int IDBaoVat { get; set; }
        public string TenBaoVat { get; set; }
        public string SoHieu { get; set; }
        public string NienDai { get; set; }
        public bool? LaBaoTang { get; set; }
        public int? BaoTangID { get; set; }
        public string TenBaoTang { get; set; }
        public string TenDonViKhac { get; set; }
        public string DiaPhuong { get; set; }
        public int NguoiDungID { get; set; }
        public string UrlFile { get; set; }
        public string TenFileGoc { get; set; }
    }
}
