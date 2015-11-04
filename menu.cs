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
        public menu()
        {
            InitializeComponent();
        }
       
        private void menu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Hide();
        }
        public event EventHandler onClick;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Show();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.onClick != null)
                this.onClick(this, e);
        }
    }
}
