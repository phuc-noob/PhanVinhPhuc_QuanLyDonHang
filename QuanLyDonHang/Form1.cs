using BUS;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDonHang
{
    public partial class Form1 : Form
    {
        public string idDonhang, tenNguoiGui, dc_gui, dc_nhan;
        public float trongLuong;
        public int chieuCao, chieuDai, chieuRong;

        
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
            /*DataTable dt = new DataTable();
            dt = DDonVanChuyen.getData();*/
            
            dgv_don_hang.DataSource = B_DonHang.GetAllDonHang();

            int rowindex = 0;
            idDonhang = dgv_don_hang.Rows[rowindex].Cells[0].Value.ToString();
            tenNguoiGui = dgv_don_hang.Rows[rowindex].Cells[1].Value.ToString();
            dc_gui = dgv_don_hang.Rows[rowindex].Cells[2].Value.ToString();
            dc_nhan = dgv_don_hang.Rows[rowindex].Cells[3].Value.ToString();
            trongLuong = float.Parse(dgv_don_hang.Rows[rowindex].Cells[4].Value.ToString());
            chieuDai = int.Parse(dgv_don_hang.Rows[rowindex].Cells[5].Value.ToString());
            chieuRong = int.Parse(dgv_don_hang.Rows[rowindex].Cells[6].Value.ToString());
            chieuCao = int.Parse(dgv_don_hang.Rows[rowindex].Cells[7].Value.ToString());

            tb_delete_id.Text = idDonhang;
            tb_tenNguoiGui.Text = tenNguoiGui;
            tb_dc_gui.Text = dc_gui;
            tb_chieuDai.Text = chieuDai.ToString();
            tb_chieuCao.Text = chieuCao.ToString();
            tb_chieuRong.Text = chieuRong.ToString();
            tb_tl.Text = trongLuong.ToString();
            tb_dc_nhan.Text = dc_nhan;
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

            bool testAdd = B_DonHang.addDonHang(idDonhang, tenNguoiGui, dc_gui, dc_nhan, trongLuong, chieuDai, chieuRong, chieuCao);
            
            if (testAdd)
            {
                MessageBox.Show("done");
                DataTable dt = new DataTable();
                dt = B_DonHang.GetAllDonHang();
                dgv_don_hang.DataSource = dt;
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string id = tb_delete_id.Text;
            /*bool statusDelete = DDonVanChuyen.deleteDonHang(id);*/
            if (B_DonHang.deleteDonHang(id))
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

            bool testUpdate = B_DonHang.updateDonHang(idDonhang, tenNguoiGui, dc_gui, dc_nhan, trongLuong, chieuDai, chieuRong, chieuCao);

            /*bool test = DDonVanChuyen.updateDonHang(idDonhang, tenNguoiGui, dc_gui, dc_nhan, trongLuong, chieuDai, chieuRong, chieuCao);*/
            if (testUpdate)
            {
                MessageBox.Show("Cập Nhật Đơn Hàng Thành Công !!!");
                dgv_don_hang.DataSource = B_DonHang.GetAllDonHang();
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại !!!");
            }
        }

        private void dgv_don_hang_Click(object sender, EventArgs e)
        {

        }

        private void dgv_don_hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = dgv_don_hang.CurrentCell.RowIndex;
                idDonhang = dgv_don_hang.Rows[rowindex].Cells[0].Value.ToString();
                tenNguoiGui = dgv_don_hang.Rows[rowindex].Cells[1].Value.ToString();
                dc_gui = dgv_don_hang.Rows[rowindex].Cells[2].Value.ToString();
                dc_nhan = dgv_don_hang.Rows[rowindex].Cells[3].Value.ToString();
                trongLuong = float.Parse(dgv_don_hang.Rows[rowindex].Cells[4].Value.ToString());
                chieuDai = int.Parse(dgv_don_hang.Rows[rowindex].Cells[5].Value.ToString());
                chieuRong = int.Parse(dgv_don_hang.Rows[rowindex].Cells[6].Value.ToString());
                chieuCao = int.Parse(dgv_don_hang.Rows[rowindex].Cells[7].Value.ToString());
            }catch(Exception ex)
            {
                
            }
            

            tb_delete_id.Text = idDonhang;
            tb_tenNguoiGui.Text = tenNguoiGui;
            tb_dc_gui.Text = dc_gui;
            tb_chieuDai.Text = chieuDai.ToString();
            tb_chieuCao.Text = chieuCao.ToString();
            tb_chieuRong.Text = chieuRong.ToString();
            tb_tl.Text = trongLuong.ToString();
            tb_dc_nhan.Text = dc_nhan;
        }
    }
}