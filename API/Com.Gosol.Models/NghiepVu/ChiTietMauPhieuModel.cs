using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class ChiTietMauPhieuModel
    {
        public int ChiTietMauPhieuID { get; set; }
        public int MauPhieuID { get; set; }
        public int? ChiTieuID { get; set; }
        public string? CotIDs { get; set; }
        public int? ThangBaoCao { get; set; }
        public Boolean? GopCot { get; set; }
        public int? GopTuCot { get; set; }
        public int? GopDenCot { get; set; }
        public string? GiaTri { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? SoCotGop { get; set; }
        public string? MaCotTarget { get; set; }
        public int? LoaiHienThi { get; set; }
        public bool? CoHienThiSTT { get; set; }
        public int? LoaiSTT { get; set; }
        
    }

    public class ChiTietMauPhieuImportModel : ChiTietMauPhieuModel
    {
        public string ErrorMsg { get; set; }
        public bool IsError { get; set; }

    }
}
