using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class CauHinhNhapBaoCaoChiTietModel
    {
        public int LoaiMauPhieuID { get; set; }
        public int MauPhieuID { get; set; }
        public int ChiTieuID { get; set; }
        public int ChucNangID { get; set; }
        public string ChiTieuIds { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int SoLuongNhapBaoCao { get; set; }
    }

    public class InsertCauHinhNhapBaoCaoChiTietModel
    {
        public int LoaiMauPhieuID { get; set; }
        public int MauPhieuID { get; set; }
        public int ChiTieuID { get; set; }
        public int ChucNangID { get; set; }
        public string ChiTieuIds { get; set; }
    }

    public class UpdateCauHinhNhapBaoCaoChiTietModel : InsertCauHinhNhapBaoCaoChiTietModel
    {
        public int ID { get; set; }
    }


    public class GetCauHinhNhapBaoCaoChiTietModel : CauHinhNhapBaoCaoChiTietModel
    {
        public int ID { get; set; }
        public string TenLoaiMauPhieu { get; set; }
        public string TenChiTieu { get; set; }
    }

    public class CauHinhNhapBaoCaoChiTietModelFilter : BasePagingParams
    {
        public int? LoaiMauPhieuID { get; set; }
        public int? MauPhieuID { get; set; }
        public int? ChucNangID { get; set; }
        public int? ChiTieuID { get; set; }
    }
}
