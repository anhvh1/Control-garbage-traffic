using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
    public class DanhMucDonViTinhMOD : DanhMucDonViTinhThemMoiMOD
    {
        public int? DonViTinhID { get; set; }
    }
    public class DanhMucDonViTinhThemMoiMOD
    {
        public string MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
        public string GhiChu { get; set; }
    }
}
