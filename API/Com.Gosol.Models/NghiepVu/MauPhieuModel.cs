using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class MauPhieuModel
    {
        public MauPhieuModel()
        {
            chiTietMauPhieuModels = new List<ChiTietMauPhieuModel>();
        }
        public int MauPhieuID { get; set; }
        public string TenMauPhieu { get; set; }
        public string MaMauPhieu { get; set; }
        public int? Nam { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        //public DateTime? TuNgay { get; set; }
        //public DateTime? DenNgay { get; set; }
        public int CapDoMauPhieu { get; set; }
        public bool GoiY { get; set; }
        public int? NguoiDungID { get; set; }
        public string ChiTieuIDs { get; set; }
        public string CotIDs { get; set; }
        public int? LoaiMauPhieuID { get; set; }
        public int? MauPhieuChaID { get; set; }
        public int? KyBaoCaoID { get; set; }
        public string? ThangBaoCao { get; set; }
        public bool? MauPhieuGoc { get; set; }
        public int SoBieuDuLieu { get; set; }
        public int SoLuongCauHinh { get; set; }
        public List<ChiTietMauPhieuModel> chiTietMauPhieuModels { get; set; }
    }

    public class MauPhieuModelFilter : BasePagingParams
    {
        public int? KyBaoCaoID { get; set; }
        public int? NguoiDungID { get; set; }
        public int? Nam { get; set; }
        public int? LoaiMauPhieuID { get; set; }
        public int? CapDoMauPhieu { get; set; }

    }


    public class FilerExportMauPhieuModel
    {
        public bool TaiBieuMau { get; set; }
        public int? KyBaoCaoID { get; set; }
        public int? Nam { get; set; }
        public List<int> Ids { get; set; }

    }
}
