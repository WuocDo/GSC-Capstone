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
    public partial class TuyChonNhieu : UserControl
    {
        public TuyChonNhieu()
        {
            InitializeComponent();
        }
        private static TuyChonNhieu _instance;
        public static TuyChonNhieu instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TuyChonNhieu();
                return _instance;
            }
        }
        private void TuyChonNhieu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DapAnTuyChonNhieu dntcn = new DapAnTuyChonNhieu();
            flpThemDapAn.Controls.Add(dntcn);
        }
    }
}
