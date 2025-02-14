using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
    public class DanhMucChiTieuModel
    {
        public string MaChiTieu { get; set; }
        public string TenChiTieu { get; set; }
        public string GhiChu { get; set; }
        public int? ChiTieuChaID { get; set; }
        public bool TrangThai { get; set; }
        public int LoaiMauPhieuID { get; set; }
        public bool CoCapNhapSoLieuThongKe { get; set; }

        // public int DonViTinhID { get; set; }
    }

    // Get
    public class GetChiTieuModel : DanhMucChiTieuModel
    {
        public int ChiTieuID { get; set; }
        public List<GetChiTieuModel> Children { get; set; }
    }

    // Add
    public class AddChiTieuModel : DanhMucChiTieuModel { }

    // Up
    public class UpdateChiTieuModel : DanhMucChiTieuModel
    {
        [Required]
        public int ChiTieuID { get; set; }
    }

    public class ChiTieuExport
    {
        public string MaChiTieu { get; set; }
        public string TenChiTieu { get; set; }
        public string GhiChu { get; set; }
        public int? ChiTieuChaID { get; set; }
        public bool TrangThai { get; set; }
        public int ChiTieuID { get; set; }
        public List<ChiTieuExport> Children { get; set; }
        public int LoaiHienThi { get; set; }
        public bool CoHienThiSTT { get; set; }
        public int LoaiSTT { get; set; }
        public int RowIndex { get; set; }
        public bool IsEdit { get; set; }
    }
    public class FiltesDMChiTieu:ThamSoLocDanhMuc
    {
        public int? LoaiMauPhieuID { get; set; }
    }
    public class DanhMucChiTieuModelPartial
    {
        public int ChiTieuID { get; set; }
        public string MaChiTieu { get; set; }
        public string TenChiTieu { get; set; }
        public string GhiChu { get; set; }
        public int? ChiTieuChaID { get; set; }
        public bool TrangThai { get; set; }
        public int LoaiMauPhieuID { get; set; }
        public List<DanhMucChiTieuModelPartial> Children { get; set; }
       
    }
    public class ChiTieu
    {
        public int ChiTieuID { get; set; }
        public int ChiTieuChaID { get; set; }
    }
}
