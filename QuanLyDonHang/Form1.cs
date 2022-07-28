using BUS;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDonHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DDonVanChuyen.getData();
            dgv_don_hang.DataSource = dt;   
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string idDonhang, tenNguoiGui,dc_gui,dc_nhan;
            float trongLuong;
            int chieuCao, chieuDai, chieuRong;
            
            Random rnd = new Random();
            int i = rnd.Next(1, 100000);
            idDonhang = "MDH" + i.ToString();
            
            tenNguoiGui = tb_tenNguoiGui.Text;
            dc_gui = tb_dc_gui.Text;
            dc_nhan = tb_dc_nhan.Text;

            trongLuong = float.Parse(tb_tl.Text);
            chieuDai = int.Parse(tb_chieuDai.Text);
            chieuCao = int.Parse(tb_chieuCao.Text);
            chieuRong = int.Parse(tb_chieuCao.Text);

            bool test = DDonVanChuyen.insertDonHang(idDonhang, tenNguoiGui, dc_gui, dc_nhan, trongLuong, chieuDai, chieuRong, chieuCao);
            if (test)
            {
                MessageBox.Show("done");
                DataTable dt = new DataTable();
                dt = DDonVanChuyen.getData();
                dgv_don_hang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string id = tb_delete_id.Text;
            bool statusDelete = DDonVanChuyen.deleteDonHang(id);
            if (statusDelete)
            {
                MessageBox.Show("Xóa đơn hàng thành công !!!");
                DataTable dt = new DataTable();
                dt = DDonVanChuyen.getData();
                dgv_don_hang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string idDonhang, tenNguoiGui, dc_gui, dc_nhan;
            float trongLuong;
            int chieuCao, chieuDai, chieuRong;

            idDonhang = tb_delete_id.Text;

            tenNguoiGui = tb_tenNguoiGui.Text;
            dc_gui = tb_dc_gui.Text;
            dc_nhan = tb_dc_nhan.Text;

            trongLuong = float.Parse(tb_tl.Text);
            chieuDai = int.Parse(tb_chieuDai.Text);
            chieuCao = int.Parse(tb_chieuCao.Text);
            chieuRong = int.Parse(tb_chieuCao.Text);

            bool test = DDonVanChuyen.updateDonHang(idDonhang, tenNguoiGui, dc_gui, dc_nhan, trongLuong, chieuDai, chieuRong, chieuCao);
            if (test)
            {
                MessageBox.Show("Cập Nhật Đơn Hàng Thành Công !!!");
                DataTable dt = new DataTable();
                dt = DDonVanChuyen.getData();
                dgv_don_hang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại !!!");
            }
        }
    }
}