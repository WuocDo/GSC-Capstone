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
            //this.Dock = DockStyle.Fill;
            //panel1.Controls.Add(tcm);
            if (!panel1.Controls.Contains(TuyChonMot.instance))
            {
                panel1.Controls.Add(TuyChonMot.instance);
                TuyChonMot.instance.Dock = DockStyle.Fill;
                TuyChonMot.instance.BringToFront();
            }
            else
            {
                TuyChonMot.instance.BringToFront();
            }
        }

        private void rdoMot_CheckedChanged(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(tcm);
            if (!panel1.Controls.Contains(TuyChonMot.instance))
            {
                panel1.Controls.Add(TuyChonMot.instance);
                TuyChonMot.instance.Dock = DockStyle.Fill;
                TuyChonMot.instance.BringToFront();
            }
            else
            {
                TuyChonMot.instance.BringToFront();
            }
        }

        private void rdoNhieu_CheckedChanged(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(tcn);
            if (!panel1.Controls.Contains(TuyChonNhieu.instance))
            {
                panel1.Controls.Add(TuyChonNhieu.instance);
                TuyChonNhieu.instance.Dock = DockStyle.Fill;
                TuyChonNhieu.instance.BringToFront();
            }
            else
            {
                TuyChonNhieu.instance.BringToFront();
            }
        }

        private void rdoNgan_CheckedChanged(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //panel1.Controls.Add(tln);
            if (!panel1.Controls.Contains(TraLoiNgan.instance))
            {
                panel1.Controls.Add(TraLoiNgan.instance);
                TraLoiNgan.instance.Dock = DockStyle.Fill;
                TraLoiNgan.instance.BringToFront();
            }
            else
            {
                TraLoiNgan.instance.BringToFront();
            }
        }
    }
}
