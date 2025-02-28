using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Gosol.Models.DanhMuc
{
    public class DM_Camera_ThungRac
    {
        public int ID { get; set; }            // ID của bản ghi (primary key)
        public int CameraID { get; set; }      // ID của camera
        public int ThungRacID { get; set; }    // ID của thùng rác

        // Constructor mặc định
        public DM_Camera_ThungRac() { }

        // Constructor với các tham số
        public DM_Camera_ThungRac(int cameraID, int thungRacID)
        {
            CameraID = cameraID;
            ThungRacID = thungRacID;
        }
    }

    public class DM_Camera_ThungRacRespone
    {
        public int ID { get; set; }
        public int CameraID { get; set; }
        public int ThungRacID { get; set; }
        public string MaCamera { get; set; }
        public string TenCamera { get; set; }
        public string ViTri { get; set; }
        public double ViDo { get; set; }
        public double KinhDo { get; set; }
        public string DiaChiIP { get; set; }
        public string DiaChiMAC { get; set; }
        public DateTime CameraNgayTao { get; set; }
        public string TenThungRac { get; set; }
        public int SoLuongRacHienTai { get; set; }
        public int SucChuaToiDa { get; set; }
        public bool TrangThaiDay { get; set; }
        public int LoaiThayDoi { get; set; }

    }
}
