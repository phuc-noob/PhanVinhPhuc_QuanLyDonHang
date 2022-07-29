namespace QuanLyDonHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_don_hang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.tb_delete_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_chieuRong = new System.Windows.Forms.TextBox();
            this.tb_chieuCao = new System.Windows.Forms.TextBox();
            this.tb_chieuDai = new System.Windows.Forms.TextBox();
            this.tb_tl = new System.Windows.Forms.TextBox();
            this.tb_dc_nhan = new System.Windows.Forms.TextBox();
            this.tb_dc_gui = new System.Windows.Forms.TextBox();
            this.tb_tenNguoiGui = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_don_hang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_don_hang);
            this.groupBox1.Location = new System.Drawing.Point(21, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Dơn Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_don_hang
            // 
            this.dgv_don_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_don_hang.Location = new System.Drawing.Point(13, 26);
            this.dgv_don_hang.Name = "dgv_don_hang";
            this.dgv_don_hang.RowHeadersWidth = 51;
            this.dgv_don_hang.RowTemplate.Height = 29;
            this.dgv_don_hang.Size = new System.Drawing.Size(1052, 256);
            this.dgv_don_hang.TabIndex = 0;
            this.dgv_don_hang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_don_hang_CellClick);
            this.dgv_don_hang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_don_hang.Click += new System.EventHandler(this.dgv_don_hang_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_update);
            this.groupBox2.Controls.Add(this.tb_delete_id);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bt_delete);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Controls.Add(this.tb_chieuRong);
            this.groupBox2.Controls.Add(this.tb_chieuCao);
            this.groupBox2.Controls.Add(this.tb_chieuDai);
            this.groupBox2.Controls.Add(this.tb_tl);
            this.groupBox2.Controls.Add(this.tb_dc_nhan);
            this.groupBox2.Controls.Add(this.tb_dc_gui);
            this.groupBox2.Controls.Add(this.tb_tenNguoiGui);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1081, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Thông Tin Đơn Hàng";
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(971, 121);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(94, 29);
            this.bt_update.TabIndex = 18;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // tb_delete_id
            // 
            this.tb_delete_id.Location = new System.Drawing.Point(773, 168);
            this.tb_delete_id.Name = "tb_delete_id";
            this.tb_delete_id.Size = new System.Drawing.Size(100, 27);
            this.tb_delete_id.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Xóa Sửa Đơn Hàng Theo ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(971, 172);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(94, 29);
            this.bt_delete.TabIndex = 15;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(971, 26);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(94, 29);
            this.bt_add.TabIndex = 14;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_chieuRong
            // 
            this.tb_chieuRong.Location = new System.Drawing.Point(682, 118);
            this.tb_chieuRong.Name = "tb_chieuRong";
            this.tb_chieuRong.Size = new System.Drawing.Size(191, 27);
            this.tb_chieuRong.TabIndex = 13;
            // 
            // tb_chieuCao
            // 
            this.tb_chieuCao.Location = new System.Drawing.Point(682, 76);
            this.tb_chieuCao.Name = "tb_chieuCao";
            this.tb_chieuCao.Size = new System.Drawing.Size(191, 27);
            this.tb_chieuCao.TabIndex = 12;
            // 
            // tb_chieuDai
            // 
            this.tb_chieuDai.Location = new System.Drawing.Point(682, 33);
            this.tb_chieuDai.Name = "tb_chieuDai";
            this.tb_chieuDai.Size = new System.Drawing.Size(191, 27);
            this.tb_chieuDai.TabIndex = 11;
            // 
            // tb_tl
            // 
            this.tb_tl.Location = new System.Drawing.Point(167, 161);
            this.tb_tl.Name = "tb_tl";
            this.tb_tl.Size = new System.Drawing.Size(191, 27);
            this.tb_tl.TabIndex = 10;
            // 
            // tb_dc_nhan
            // 
            this.tb_dc_nhan.Location = new System.Drawing.Point(167, 118);
            this.tb_dc_nhan.Name = "tb_dc_nhan";
            this.tb_dc_nhan.Size = new System.Drawing.Size(191, 27);
            this.tb_dc_nhan.TabIndex = 9;
            // 
            // tb_dc_gui
            // 
            this.tb_dc_gui.Location = new System.Drawing.Point(167, 76);
            this.tb_dc_gui.Name = "tb_dc_gui";
            this.tb_dc_gui.Size = new System.Drawing.Size(191, 27);
            this.tb_dc_gui.TabIndex = 8;
            // 
            // tb_tenNguoiGui
            // 
            this.tb_tenNguoiGui.Location = new System.Drawing.Point(167, 33);
            this.tb_tenNguoiGui.Name = "tb_tenNguoiGui";
            this.tb_tenNguoiGui.Size = new System.Drawing.Size(191, 27);
            this.tb_tenNguoiGui.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chiều Rộng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chiều Cao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chiều Dài";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trọng Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ Nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ Gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Người Gửi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_don_hang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgv_don_hang;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tb_chieuRong;
        private TextBox tb_chieuCao;
        private TextBox tb_chieuDai;
        private TextBox tb_tl;
        private TextBox tb_dc_nhan;
        private TextBox tb_dc_gui;
        private TextBox tb_tenNguoiGui;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button bt_add;
        private Button bt_delete;
        private Label label9;
        private TextBox tb_delete_id;
        private Button bt_update;
    }
}