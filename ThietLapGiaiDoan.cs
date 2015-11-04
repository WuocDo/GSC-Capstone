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
    public partial class ThietLapGiaiDoan : UserControl
    {
        public ThietLapGiaiDoan()
        {
            InitializeComponent();
        }
        
        private void btnTao_Click(object sender, EventArgs e)
        {
            VongThi vt = new VongThi();
            flbThemVongThi.Controls.Add(vt);
        }

        private void ThietLapGiaiDoan_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
