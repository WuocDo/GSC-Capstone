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
    public partial class TaoCauHoi : UserControl
    {
        public TaoCauHoi()
        {
            InitializeComponent();
        }
        TuyChonMot tcm = new TuyChonMot();
        TuyChonNhieu tcn = new TuyChonNhieu();
        TraLoiNgan tln = new TraLoiNgan();
        private void TaoCauHoi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            panel1.Controls.Add(tcm);
        }

        private void rdoMot_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(tcm);         
        }

        private void rdoNhieu_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(tcn);
           
        }

        private void rdoNgan_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(tln);
            
        }
    }
}
