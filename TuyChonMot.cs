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
    public partial class TuyChonMot : UserControl
    {
        public TuyChonMot()
        {
            InitializeComponent();
        }
        private static TuyChonMot _instance;
        public static TuyChonMot instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TuyChonMot();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TuyChonMot_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DapAnTuyChonMot dntcm = new DapAnTuyChonMot();
            flpThemDapAn.Controls.Add(dntcm);
        }

        private void flpThemDapAn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
