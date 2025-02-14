using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyDanhMucDiSanVanHoaPhiVatTheModel
    {
        public string Ten { get; set; }
        public string LoaiHinh { get; set; }
        public string ThongTinQuyetDinh { get; set; }
        public DateTime? NgayQuyetDinh { get; set; }
        public string DiaPhuong { get; set; }
    }
    public class QuanLyDanhMucDiSanVanHoaPhiVatTheModelSua
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string LoaiHinh { get; set; }
        public string ThongTinQuyetDinh { get; set; }
        public DateTime NgayQuyetDinh { get; set; }
        public string DiaPhuong { get; set; }
    }
    public class QuanLyDanhMucDiSanVanHoaPhiVatTheModelDanhSach
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string LoaiHinh { get; set; }
        public string ThongTinQuyetDinh { get; set; }
        public DateTime NgayQuyetDinh { get; set; }
        public string DiaPhuong { get; set; }
        public int NguoiDungID { get; set; }
        
    }

}
