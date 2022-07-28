using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonVanChuyen
    {
        public string idDonHang { get; set; }
        public string tenNguoiGui { get; set; }
        public string diaChiGui { get; set; }
        public string diaChiNhan { get; set; }
        public float trongLuong { get; set; }
        public int chieuDai { get; set; }
        public int chieuRong { get; set; }
        public int chieuCao { get; set; }
        public DonVanChuyen(string idDonHang, string tenNguoiGui, string diaChiGui, string diaChiNhan, float trongLuong, int chieuDai, int chieuRong, int chieuCao)
        {
            this.idDonHang = idDonHang;
            this.tenNguoiGui = tenNguoiGui;
            this.diaChiGui = diaChiGui;
            this.diaChiNhan = diaChiNhan;
            this.trongLuong = trongLuong;
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.chieuCao = chieuCao;
        }
    }
}
