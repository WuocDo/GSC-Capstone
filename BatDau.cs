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
    public partial class BatDau : UserControl
    {
        public BatDau()
        {
            InitializeComponent();
        }

        private void BatDau_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CacCuocThi cct = new CacCuocThi();
            panel1.Controls.Add(cct);
        }
        public event EventHandler onClick;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }
    }
}
