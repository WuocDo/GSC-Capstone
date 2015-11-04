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
    public partial class ThietLapDoiThi : UserControl
    {
        public ThietLapDoiThi()
        {
            InitializeComponent();
        }
        
        private void btnTao_Click(object sender, EventArgs e)
        {
            DoiChoi dc = new DoiChoi();
            flbThemDoiThi.Controls.Add(dc);
        }

        private void ThietLapDoiThi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void flbThemDoiThi_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
