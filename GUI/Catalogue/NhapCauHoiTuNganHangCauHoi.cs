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
    public partial class NhapCauHoiTuNganHangCauHoi : UserControl
    {
        public NhapCauHoiTuNganHangCauHoi()
        {
            InitializeComponent();
        }
        private void NhapCauHoiTuNganHangCauHoi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;      
        }
    }
}
