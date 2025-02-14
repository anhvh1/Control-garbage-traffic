using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.VHTT.Models.HeThong
{
    public class CauHinhDangNhap
    {
        public int? ID { get; set; }
        public string TenPhanMem { get; set; }
        public string SlideAnh { get; set; }
        public int? LogoDangNhap { get; set; }
        public int? HinhNenDangNhap { get; set; }
        public string FileDinhKemJson { get; set; }
        public List<IFormFile> SlideAnhFiles { get; set; }
        public IFormFile LogoDangNhapFile { get; set; }
        public IFormFile HinhNenDangNhapFile { get; set; }
        
    }

    public class GetCauHinhDangNhap : CauHinhDangNhap
    {
        public string SlideAnhUrl { get; set; }
        public string LogoDangNhapUrl { get; set; }
        public string HinhNenDangNhapURL { get; set; }
    }

    public class InsertCauHinhDangNhap
    {
        public string TenPhanMem { get; set; }
        public string FileDinhKemJson { get; set; }
        public List<IFormFile> SlideAnhFiles { get; set; }
        public IFormFile LogoDangNhapFile { get; set; }
        public IFormFile HinhNenDangNhapFile { get; set; }
    }
}
