using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShowControls
{
    public partial class Login : Form
    {
        Thread Thread;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //GuiMenu GuiMenu = new GuiMenu();
            //GuiMenu.ShowDialog();
            this.Close();
            Thread = new Thread(Open_GuiMenu);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }
        private void Open_GuiMenu()
        {
            Application.Run(new GuiMenu());
        }
    }
}
