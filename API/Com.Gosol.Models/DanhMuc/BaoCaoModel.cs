using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
    public class BaoCaoModel
    {
        public string TenBaoCao { get; set; }
        public int NamBaoCao { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public int NguoiTaoID { get; set; }
        public int MauBaoCaoID { get; set; }
    }

    public class HandleKyBaoCaoModel : BaoCaoModel
    {
        public int KyBaoCaoID { get; set; }
    }

    public class DeleteKyBaoCaoModel : BaseDeleteParams { }

    public class ThamSoLocDanhMucKBC : ThamSoLocDanhMuc
    {
        public int? Nam { get; set; }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //public class KyBaoCaoModel
    //{
    //    public string TenKyBaoCao { get; set; }
    //    public int NamKyBaoCao { get; set; }
    //    public DateTime ThoiGianBaoCao { get; set; }
    //    public int MauBaoCaoID { get; set; }
    //}

    //public class GetKyBaoCaoModel : KyBaoCaoModel
    //{
    //    public int KyBaoCaoID { get; set; }
    //    public List<GetDuLieuChiTietMBC> DuLieuChiTietMBCs { get; set; }
    //}

    //public class AddKyBaoCaoModel : KyBaoCaoModel
    //{
    //    public List<DuLieuChiTietMBC>? DuLieuChiTietHeaderAndFooter { get; set; }
    //    public List<List<DuLieuChiTietMBC>>? DuLieuChiTietContent { get; set; }
    //}

    //public class UpdateKyBaoCaoModel : KyBaoCaoModel
    //{
    //    public int KyBaoCaoID { get; set; }
    //    public List<HandleDuLieuChiTietMBC> DuLieuKyBaoCao { get; set; }
    //}

    //public class DuLieuChiTietMBC
    //{
    //    public string GiaTri { get; set; }
    //    public int CotID { get; set; }
    //}

    //public class GetDuLieuChiTietMBC
    //{
    //    public int NhomDuLieu { get; set; }
    //    public List<DuLieuCuaNhom> DuLieuCuaNhom { get; set; }
    //}

    //public class DuLieuCuaNhom : DuLieuChiTietMBC
    //{
    //    public int ChiTietDuLieuID { get; set; }
    //    public int CotID { get; set; }
    //    public string TenCot { get; set; }
    //    public int SoThuTu { get; set; }
    //}

    //public class HandleDuLieuChiTietMBC : DuLieuChiTietMBC
    //{
    //    public int TypeHandle { get; set; }
    //    public int ChiTietDuLieuID { get; set; }
    //}
}
