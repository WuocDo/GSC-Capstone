using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShowControls
{
    public partial class TaoCauHoiChuDe : Form
    {
        public TaoCauHoiChuDe()
        {
            InitializeComponent();
        }
        NhapCauHoiTuNganHangCauHoi tnh = new NhapCauHoiTuNganHangCauHoi();
        Import nhap = new Import();
        TaoCauHoi tch = new TaoCauHoi();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(tnh);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(nhap);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(tch);
        }

        private void TaoCauHoiChuDe_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(tnh);
        }
    }
}
