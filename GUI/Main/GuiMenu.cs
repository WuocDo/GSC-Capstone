﻿using System;
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
    public partial class GuiMenu : Form
    {
        menu UcMenu = new menu();
        setting UcSeting = new setting();
        BatDau UcStart = new BatDau();
        huongDan Uchd = new huongDan();
        Login Uclg = new Login();
        public GuiMenu()
        {
            InitializeComponent();
            this.UcMenu.pb_Setting.Click += new EventHandler(pictureBox3_onClick);
            this.UcSeting.pictureBox3.Click += new EventHandler(thoat_onClick);
            this.UcMenu.pb_Start.Click += new EventHandler(batDau_onClick);
            this.UcMenu.pb_Help.Click += new EventHandler(huongDan_onClick);
            this.UcMenu.pb_Exit.Click += new EventHandler(thoatMenu_onClick);
            this.UcStart.button1.Click += new EventHandler(thoatBatDau_onClick);

        }

        private void GuiMenu_Load(object sender, EventArgs e)
        {
            this.Controls.Add(UcMenu);
        }

        void pictureBox3_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(UcSeting);
        }
        void thoat_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(UcMenu);
        }
        void batDau_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(UcStart);
        }
        void huongDan_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(Uchd);
        }
        void thoatMenu_onClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không ?");
            this.Close();
        }
        void thoatBatDau_onClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(UcMenu);
        }

        private void menu1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
