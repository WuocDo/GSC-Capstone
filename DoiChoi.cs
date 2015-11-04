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
    public partial class DoiChoi : UserControl
    {
        public DoiChoi()
        {
            InitializeComponent();
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                btnKhungMau.BackColor = colorDialog1.Color;
                panel1.BackColor = colorDialog1.Color;
                //this.BackColor = colorDialog1.Color;
            }
        }

        private void DoiChoi_Load(object sender, EventArgs e)
        {

        }

        private void btnTat_Click(object sender, EventArgs e)
        {
           
        }
    }
}
