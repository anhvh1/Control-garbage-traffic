using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyNgheNhanModel
    {
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int LinhVucID { get; set; }
        public int DanhHieu { get; set; }
        public bool DaMat { get; set; }
    }
    public class QuanLyNgheNhanModelSua
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int LinhVucID { get; set; }
        public int DanhHieu { get; set; }
        public bool DaMat { get; set; }
    }
    public class QuanLyNgheNhanModelDanhSach
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public string NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int LinhVucID { get; set; }
        public string TenLinhVuc { get; set; }
        public int DanhHieu { get; set; }
        public bool DaMat { get; set; }
        public int NguoiDungID { get; set; }
    }
}
