using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.Models.DanhMuc
{
    public class DM_ThungRac
    {
        public int ID { get; set; }
        public string MaThungRac { get; set; }
        public string TenThungRac { get; set; }
        public string ViTri { get; set; }
        public float ViDo { get; set; }
        public float KinhDo { get; set; }
        public int SoLuongRacHienTai { get; set; }
        public int SucChuaToiDa { get; set; }
        public bool TrangThaiDay { get; set; }
        public DateTime LanThuGomGanNhat { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
