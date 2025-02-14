using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
    public class DanhMucCotModel
    {
        public int CotChaID { get; set; }
        public string TenCot { get; set; } = "";
        public string GhiChu { get; set; } = "";
        public int KieuDuLieuCot { get; set; }
        public bool TrangThai { get; set; }
        public int LoaiCot { get; set; }
        public string MaCot { get; set; } = "";
        public int CapDo { get; set; }
    }

    public class GetDanhMucCotModel : DanhMucCotModel
    {
        public int CotID { get; set; }
        public List<GetDanhMucCotModel> Children { get; set; }
    }

    public class AddDanhMucCotModel : DanhMucCotModel { }

    public class UpdateDanhMucCotModel : DanhMucCotModel
    {
        public int CotID { get; set; }
    }
    
    public class DeleteDanhMucCotModel : BaseDeleteParams { }

    public class ThamSoLocDanhMucCot : ThamSoLocDanhMuc 
    {
    }

    public class CotExport
    {
        public int CotID { get; set; }
        public int CotChaID { get; set; }
        public string TenCot { get; set; } = "";
        public string GhiChu { get; set; } = "";
        public int KieuDuLieuCot { get; set; }
        public bool TrangThai { get; set; }
        public int LoaiCot { get; set; }
        public string MaCot { get; set; } = "";
        public int CapDo { get; set; }

        public string GiaTri { get; set; }
        public List<CotExport> Children { get; set; }
        public int Index { get; set; }
        public int ThangBaoCao { get; set; }

    }
}