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
    public partial class TraLoiNgan : UserControl
    {
        public TraLoiNgan()
        {
            InitializeComponent();
        }
        private static TraLoiNgan _instance;
        public static TraLoiNgan instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TraLoiNgan();
                return _instance;
            }
        }

        private void TraLoiNgan_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
