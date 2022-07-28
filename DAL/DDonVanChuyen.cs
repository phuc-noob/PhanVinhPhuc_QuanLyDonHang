using System.Data;
using System.Data.SqlClient;
using System;
namespace DAL
{
    public class DDonVanChuyen
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.connect();
            Conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from DonVanChuyen", Conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            Conn.Close();
            return dt;
        }
        public static bool insertDonHang(string idDonHang,string tenNguoiGui, string diaChiGui, string diaChiNhan,float trongLuong, int chieuDai,int chieuRong,int chieuCao )
        {
            SqlConnection Conn = dbConnectionData.connect();
            
            SqlCommand command = new SqlCommand("INSERT INTO DonVanChuyen (idDonHang, tenNguoiGui, diaChiGui, diaChiNhan, trongLuong, chieuDai, chieuRong, chieuCao)" +
                " VALUES (@id, @tgui, @dcgui, @dcnhan, @tl, @cd, @cc, @cr)", Conn);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = idDonHang;
            command.Parameters.Add("@tgui", SqlDbType.VarChar).Value = tenNguoiGui;
            command.Parameters.Add("@dcgui", SqlDbType.VarChar).Value = diaChiGui;
            command.Parameters.Add("@dcnhan", SqlDbType.VarChar).Value = diaChiNhan;
            command.Parameters.Add("@tl", SqlDbType.Float).Value = trongLuong;
            command.Parameters.Add("@cd", SqlDbType.Int).Value = chieuDai;
            command.Parameters.Add("@cc", SqlDbType.Int).Value = chieuCao;
            command.Parameters.Add("@cr", SqlDbType.Int).Value = chieuRong;

            Conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }

        public static bool updateDonHang(string idDonHang, string tenNguoiGui, string diaChiGui, string diaChiNhan, float trongLuong, int chieuDai, int chieuRong, int chieuCao)
        {
            SqlConnection Conn = dbConnectionData.connect();

            SqlCommand command = new SqlCommand("UPDATE DonVanChuyen SET  tenNguoiGui=@tgui, diaChiGui=@dcgui, diaChiNhan=@dcnhan, trongLuong=@tl, chieuDai=@cd, chieuRong=@cr, chieuCao=@cc WHERE idDonHang=@id", Conn);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = idDonHang;
            command.Parameters.Add("@tgui", SqlDbType.VarChar).Value = tenNguoiGui;
            command.Parameters.Add("@dcgui", SqlDbType.VarChar).Value = diaChiGui;
            command.Parameters.Add("@dcnhan", SqlDbType.VarChar).Value = diaChiNhan;
            command.Parameters.Add("@tl", SqlDbType.Float).Value = trongLuong;
            command.Parameters.Add("@cd", SqlDbType.Int).Value = chieuDai;
            command.Parameters.Add("@cc", SqlDbType.Int).Value = chieuCao;
            command.Parameters.Add("@cr", SqlDbType.Int).Value = chieuRong;

            Conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }

        public static bool deleteDonHang(string id)
        {
            SqlConnection Conn = dbConnectionData.connect();
            SqlCommand command = new SqlCommand("DELETE FROM DonVanChuyen WHERE idDonHang = @id");
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Connection = Conn ;
            Conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }

    }
}