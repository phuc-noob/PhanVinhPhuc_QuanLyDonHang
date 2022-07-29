using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class B_DonHang
    {
        public static DataTable GetAllDonHang()
        {
           return DDonVanChuyen.getData();
        }

        public static bool addDonHang(string idDonHang, string tenNguoiGui, string diaChiGui, string diaChiNhan, float trongLuong, int chieuDai, int chieuRong, int chieuCao)
        {
            bool test = DDonVanChuyen.insertDonHang( idDonHang , tenNguoiGui ,diaChiGui, diaChiNhan, trongLuong, chieuDai, chieuRong, chieuCao);
            if (test)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool updateDonHang(string idDonHang, string tenNguoiGui, string diaChiGui, string diaChiNhan, float trongLuong, int chieuDai, int chieuRong, int chieuCao)
        {
            if (DDonVanChuyen.updateDonHang(idDonHang, tenNguoiGui, diaChiGui, diaChiNhan, trongLuong, chieuDai, chieuRong, chieuCao))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool deleteDonHang(string id)
        {
            if (DDonVanChuyen.deleteDonHang(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
