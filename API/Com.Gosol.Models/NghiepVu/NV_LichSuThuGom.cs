using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.Models.NghiepVu
{
    public class NV_LichSuThuGom
    {
        public int ID { get; set; }
        public int ThungRacID { get; set; }
        public string NguoiThuGom { get; set; } = string.Empty;
        public DateTime ThoiGianThuGom { get; set; }
    }
}
