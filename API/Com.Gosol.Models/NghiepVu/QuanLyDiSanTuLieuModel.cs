using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class QuanLyDiSanTuLieuModel
    {
        public string TenDiSan { get; set; }
        public int LoaiDiSanID { get; set; }
        public string NoiLuuTru { get; set; }
        public DateTime NgayCongNhan { get; set; }
    }
    public class QuanLyDiSanTuLieuModelSua
    {
        public int ID { get; set; }
        public string TenDiSan { get; set; }
        public int LoaiDiSanID { get; set; }
        public string NoiLuuTru { get; set; }
        public DateTime NgayCongNhan { get; set; }
    }
    public class QuanLyDiSanTuLieuModelDanhSach
    {
        public int ID { get; set; }
        public string TenDiSan { get; set; }
        public string TenLoaiDiSan { get; set; }
        public int LoaiDiSanID { get; set; }
        public string NoiLuuTru { get; set; }
        public DateTime? NgayCongNhan { get; set; }
        public int NguoiDungID { get; set; }        
    }

}
