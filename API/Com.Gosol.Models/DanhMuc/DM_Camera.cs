using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.Models.DanhMuc
{
    public class DM_Camera
    {
        public int ID { get; set; }
        public string MaCamera { get; set; }
        public string TenCamera { get; set; }
        public string ViTri { get; set; }
        public float ViDo { get; set; }
        public float KinhDo { get; set; }
        public string DiaChiIP { get; set; }
        public string DiaChiMAC { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
