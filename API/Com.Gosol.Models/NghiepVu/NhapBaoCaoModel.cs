using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.NghiepVu
{
    public class NhapBaoCaoModel
    {
        public int ID { get; set; }
        public int CauHinhNhapBaoCaoChiTietID { get; set; }
        public DateTime? ThoiGianNhap { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? NguoiDungID { get; set; }
    }

    public class InsertNhapBaoCaoModel
    {
        public InsertNhapBaoCaoModel()
        {
            listChucNangDinhKemModel = new List<InsertOrUpdateChucNangDinhKemModel>();
            listNhapBaoCaoChiTietModel = new List<InsertOrUpdateNhapBaoCaoChiTietModel>();
        }
        public int CauHinhNhapBaoCaoChiTietID { get; set; }
        public DateTime? ThoiGianNhap { get; set; }
        public int? NguoiDungID { get; set; }
        public List<InsertOrUpdateChucNangDinhKemModel> listChucNangDinhKemModel { get; set; }
        public List<InsertOrUpdateNhapBaoCaoChiTietModel> listNhapBaoCaoChiTietModel { get; set; }
    }

    public class UpdateNhapBaoCaoModel : InsertNhapBaoCaoModel
    {
        public int ID { get; set; }
    }

    public class NhapBaoCaoModelFilter : BasePagingParams
    {
        public int NguoiDungID { get; set; }
        public int? ChucNangID { get; set; }
        public int? ChiTietID { get; set; }
        public DateTime? ThoiGianNhap { get; set; }
    }

    public class GetNhapBaoCaoModel : NhapBaoCaoModel
    {
        public GetNhapBaoCaoModel()
        {
            listChucNangDinhKemModel = new List<ChucNangDinhKemModel>();
            listNhapBaoCaoChiTietModel = new List<NhapBaoCaoChiTietModel>();
        }

        public string Ten { get; set; }

        public List<ChucNangDinhKemModel> listChucNangDinhKemModel { get; set; }
        public List<NhapBaoCaoChiTietModel> listNhapBaoCaoChiTietModel { get; set; }
    }
}
