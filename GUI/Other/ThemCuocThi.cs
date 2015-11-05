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
    public partial class ThemCuocThi : Form
    {
        public ThemCuocThi()
        {
            InitializeComponent();
        }
        ThietLapChung tlc = new ThietLapChung();
        ThietLapGiaiDoan tlgd = new ThietLapGiaiDoan();
        ThietLapDoiThi tldt = new ThietLapDoiThi();
        ThietLapThiDau tltd = new ThietLapThiDau();
        private void ThemCuocThi_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(tlc);
            btnLui.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nutTiep();
        }
        int i = 0;
        public void nutTiep()
        {
            i = i + 1;
            if (i == 1)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(tlgd);
                btnLui.Visible = true;
            }
            else if (i == 2)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(tldt);
            }
            else if (i == 3)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(tltd);
                button1.Visible = false;
                btnLuuLai.Visible = true;
            }
            else
            {

            }
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            nutLui();
        }
        public void nutLui()
        {
            i = i - 1;
            if (i == 2)
            {
                button1.Visible = true;
                btnLuuLai.Visible = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(tldt);
           
            }
            else if (i == 1)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(tlgd);
            }
            else if (i == 0)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(tlc);
                btnLui.Visible = false;
            }
            else
            {

            }
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            
        }
       
        
    }
}
