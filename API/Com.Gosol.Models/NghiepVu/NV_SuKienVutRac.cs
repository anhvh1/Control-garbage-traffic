using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.Models.NghiepVu
{
    public class NV_SuKienVutRac
    {
        public int ID { get; set; }
        public int ThungRacID { get; set; }
        public int CameraID { get; set; }
        public DateTime ThoiGianVut { get; set; }
    }
}
