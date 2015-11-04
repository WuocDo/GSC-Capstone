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
    public partial class ThietLapChung : UserControl
    {
        public ThietLapChung()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                grbCauHoi.Enabled = true;
            }
            else
            {
                grbCauHoi.Enabled = false;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                grbTraLoi.Enabled = true;
            }
            else
            {
                grbTraLoi.Enabled = false;
            }
        }
    }
}
