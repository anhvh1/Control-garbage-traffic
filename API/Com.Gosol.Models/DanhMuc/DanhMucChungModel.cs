using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.DanhMuc
{
	public class DanhMucChungModel
	{
        public int ID { get; set; }
        public int? ChaID { get; set; }
        public string Ten { get; set; }
        public string Ma { get; set; }
        public bool? TrangThai { get; set; }
        public string GhiChu { get; set; }
        public int? Loai { get; set; }
    }
}
