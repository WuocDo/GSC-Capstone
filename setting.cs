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
    public partial class setting : UserControl
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        public event EventHandler onClick;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }

        private void ptbTLG_Click(object sender, EventArgs e)
        {
            ThietLapGame tlg = new ThietLapGame();
            pnlKhung.Controls.Clear();
            pnlKhung.Controls.Add(tlg);
        }

        private void ptbQLDL_Click(object sender, EventArgs e)
        {
            QuanLyDuLieu qldl = new QuanLyDuLieu();
            pnlKhung.Controls.Clear();
            pnlKhung.Controls.Add(qldl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
            pnlKhung.Controls.Clear();
            pnlKhung.Controls.Add(qltk);
        }
    }
}
