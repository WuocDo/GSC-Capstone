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
    public partial class menu : UserControl 
    {
        public event EventHandler onClick;
        public menu()
        {
            InitializeComponent();
        }
       
        private void menu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
      
        //start
        private void pb_Start_Click(object sender, EventArgs e)
        {
                 if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pb_Start_MouseHover(object sender, EventArgs e)
        {
                pb_StartHover.Show();
        }

        private void pb_Start_MouseLeave(object sender, EventArgs e)
        {
                pb_StartHover.Hide();
        }


        //seting
        private void pb_Setting_Click(object sender, EventArgs e)
        {
                 if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pb_Setting_MouseHover(object sender, EventArgs e)
        {
                pb_SettingHover.Show();
        }

        private void pb_Setting_MouseLeave(object sender, EventArgs e)
        {
                pb_SettingHover.Hide();
        }


        //Help
        private void pb_Help_Click(object sender, EventArgs e)
        {
                 if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pb_Help_MouseHover(object sender, EventArgs e)
        {
                pb_HelpHover.Show();
        }

        private void pb_Help_MouseLeave(object sender, EventArgs e)
        {
                pb_HelpHover.Hide();
        }


        //Exit
        private void pb_Exit_Click(object sender, EventArgs e)
        {
                 if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pb_Exit_MouseHover(object sender, EventArgs e)
        {
                 pb_ExitHover.Show();
        }

        private void pb_Exit_MouseLeave(object sender, EventArgs e)
        {
                pb_ExitHover.Hide();
        }


        
    }
}
