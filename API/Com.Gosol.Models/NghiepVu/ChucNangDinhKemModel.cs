using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class ChucNangDinhKemModel
    {
        public int ID { get; set; }
        public int? NhapBaoCaoID { get; set; }
        public int? ChucNangID { get; set; }
        public int? ChiTietID { get; set; }
        public int? Loai { get; set; }
        public int? STT { get; set; }
    }

    public class InsertOrUpdateChucNangDinhKemModel
    {
        public int? ChucNangID { get; set; }
        public int? ChiTietID { get; set; }
        public int? Loai { get; set; }
        public int? STT { get; set; }
    }
}
