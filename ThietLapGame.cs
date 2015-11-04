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
    public partial class ThietLapGame : UserControl
    {
        public ThietLapGame()
        {
            InitializeComponent();
        }

        private void ThietLapGame_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CacCuocThi cct = new CacCuocThi();
            panel1.Controls.Add(cct);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ThemCuocThi tct = new ThemCuocThi();
            tct.ShowDialog();
        }
    }
}
