using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
    public class DanhMucDiSanTuLieuModel
    {
        public string TenDiSanTuLieu { get; set; }
        public int LoaiMauPhieuID { get; set; }
        public int ChiTieuChaID { get; set; }
        public int ChiTieuID { get; set; }
    }
    public class DanhMucDiSanTuLieuModelSua
    {
        public int DiSanTuLieuID { get; set; }
        public string TenDiSanTuLieu { get; set; }
        public int LoaiMauPhieuID { get; set; }
        public int ChiTieuChaID { get; set; }
        public int ChiTieuID { get; set; }
    }
    public class DanhMucDiSanTuLieuModelDanhSach
    {
        public int DiSanTuLieuID { get; set; }
        public string TenDiSanTuLieu { get; set; }
        public int LoaiMauPhieuID { get; set; }
        public int ChiTieuChaID { get; set; }
        public int ChiTieuID { get; set; }
        public int NguoiDungID { get; set; }
    }
}
