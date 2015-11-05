using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShowControls
{
    public partial class QuanLyDuLieu : UserControl
    {
        XemDanhSachCauHoiThuocChuDe xdsch = new XemDanhSachCauHoiThuocChuDe();
        TaoCauHoiChuDe tchcd = new TaoCauHoiChuDe();
        XoaChuDe xcd = new XoaChuDe();
        public QuanLyDuLieu()
        {
            InitializeComponent();
            
        }
        private void QuanLyDuLieu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            ChuDe_TaoChuDe chuDe = new ChuDe_TaoChuDe();
            chuDe.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CauHoi_TaoCauHoi cauHoi = new CauHoi_TaoCauHoi();
            cauHoi.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CauHoi_Import nhap = new CauHoi_Import();
            nhap.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xdsch.ShowDialog();
        }

        private void btnNhapCauHoi_Click(object sender, EventArgs e)
        {
            tchcd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xcd.ShowDialog();
        }
    }
}
