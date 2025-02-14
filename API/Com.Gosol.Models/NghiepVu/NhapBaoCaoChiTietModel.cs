using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class NhapBaoCaoChiTietModel
    {
        public int ID { get; set; }
        public int? NhapBaoCaoID { get; set; }
        public int? ChiTieuID { get; set; }
        public string CotIDs { get; set; }
        public int? ThangBaoCao { get; set; }
        public bool? GopCot { get; set; }
        public int? GopTuCot { get; set; }
        public int? GopDenCot { get; set; }
        public string GiaTri { get; set; }
        public string MaCotTarget { get; set; }
    }

    public class InsertOrUpdateNhapBaoCaoChiTietModel
    {
        public int? NhapBaoCaoID { get; set; }
        public int? ChiTieuID { get; set; }
        public string CotIDs { get; set; }
        public int? ThangBaoCao { get; set; }
        public bool? GopCot { get; set; }
        public int? GopTuCot { get; set; }
        public int? GopDenCot { get; set; }
        public string GiaTri { get; set; }
        public string MaCotTarget { get; set; }
    }
}
