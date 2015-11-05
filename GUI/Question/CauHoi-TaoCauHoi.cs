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
    public partial class CauHoi_TaoCauHoi : Form
    {
        public CauHoi_TaoCauHoi()
        {
            InitializeComponent();
        }
        TaoCauHoi tch = new TaoCauHoi();
        TuyChonNhieu tcn = new TuyChonNhieu();
        TuyChonMot tcm = new TuyChonMot();
        private void CauHoi_TaoCauHoi_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(tch);
        }
    }
}
