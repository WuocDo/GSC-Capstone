namespace GameShowControls
{
    partial class QuanLyTaiKhoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThemTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(20, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(501, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Danh Sách Tài Khoản Người Dùng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 312);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // lblThemTaiKhoan
            // 
            this.lblThemTaiKhoan.AutoSize = true;
            this.lblThemTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblThemTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThemTaiKhoan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemTaiKhoan.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblThemTaiKhoan.Location = new System.Drawing.Point(29, 99);
            this.lblThemTaiKhoan.Name = "lblThemTaiKhoan";
            this.lblThemTaiKhoan.Size = new System.Drawing.Size(265, 23);
            this.lblThemTaiKhoan.TabIndex = 2;
            this.lblThemTaiKhoan.Text = "+ Thêm tài khoản người dùng";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameShowControls.Properties.Resources.KhungPanner2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblThemTaiKhoan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl1);
            this.DoubleBuffered = true;
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(635, 580);
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblThemTaiKhoan;
    }
}
