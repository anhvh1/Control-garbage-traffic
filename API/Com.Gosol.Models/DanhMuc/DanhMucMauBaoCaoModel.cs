using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
    public class DanhMucMauBaoCaoModel
    {
        public string MaMauBaoCao { get; set; }
        public string TenMauBaoCao { get; set; }
        public int CoQuanID { get; set; }
        public int Nam { get; set; }
        public bool TrangThai { get; set; }
        public int NguoiTaoID { get; set; }
        public string DuLieuMauBaoCao { get; set; }
        public bool LuuThanhMau { get; set; }
        public string Image { get; set; }
    }

    public class HandleMauBaoCaoModel : DanhMucMauBaoCaoModel
    {
        public int MauBaoCaoID { get; set; }
    }

    public class DeleteMauBaoCaoModel : BaseDeleteParams { }

    public class ThamSoLocDanhMucMBC : ThamSoLocDanhMuc
    {
        public int? Nam { get; set; }
        public bool? LuuThanhMau { get; set; }
    }

    public class ThamSoLocMbcGoiY
    {
        public string Keyword { get; set; } = "";
        public int Number { get; set; } = 8;
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////

    //public class GetDanhMucMauBaoCaoModel : DanhMucMauBaoCaoModel
    //{
    //    public int MauBaoCaoID { get; set; }
    //    public List<GetChiTietMauBaoCaoModel> CotHeader { get; set; }
    //    public List<GetChiTietMauBaoCaoModel> CotContent { get; set; }
    //    public List<GetChiTietMauBaoCaoModel> CotFooter { get; set; }
    //}

    //public class AddDanhMucMauBaoCaoModel : DanhMucMauBaoCaoModel 
    //{
    //    public List<HandleChiTietMauBaoCaoModel> CotMauBaoCao { get; set; }
    //}

    //public class UpdateDanhMucMauBaoCaoModel : DanhMucMauBaoCaoModel
    //{
    //    public int MauBaoCaoID { get; set; }
    //    public List<HandleChiTietMauBaoCaoModel> CotMauBaoCao { get; set; }
    //}

    //public class DeleteDanhMucMauBaoCaoModel : BaseDeleteParams { }

    //public class ChiTietMauBaoCaoModel : DanhMucCotModel
    //{
    //    public int CotID { get; set; }
    //    public int SoThuTu { get; set; }

    //}

    //public class GetChiTietMauBaoCaoModel : ChiTietMauBaoCaoModel
    //{
    //    public int ChiTietMauBaoCaoID { get; set; }
    //    public List<GetChiTietMauBaoCaoModel> ChildrenChiTietMauBaoCao { get; set; }
    //}

    //public class HandleChiTietMauBaoCaoModel
    //{
    //    public int CotID { get; set; }
    //    public int SoThuTu { get; set; }
    //}

    //public class ThamSoLocDanhMucMBC : ThamSoLocDanhMuc
    //{
    //    public int? LocNamMauBaoCao { get; set; }
    //}

    //public class HandleCotMbcModel : BaseDeleteParams
    //{
    //    public int idMbc { get; set; }
    //}
}
