namespace GameShowControls
{
    partial class TaoCauHoi
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
            this.grpChonDangCauHoi = new System.Windows.Forms.GroupBox();
            this.rdoNgan = new System.Windows.Forms.RadioButton();
            this.rdoNhieu = new System.Windows.Forms.RadioButton();
            this.rdoMot = new System.Windows.Forms.RadioButton();
            this.grpTaoCauHoi = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpChonDangCauHoi.SuspendLayout();
            this.grpTaoCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChonDangCauHoi
            // 
            this.grpChonDangCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChonDangCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.grpChonDangCauHoi.Controls.Add(this.rdoNgan);
            this.grpChonDangCauHoi.Controls.Add(this.rdoNhieu);
            this.grpChonDangCauHoi.Controls.Add(this.rdoMot);
            this.grpChonDangCauHoi.ForeColor = System.Drawing.Color.White;
            this.grpChonDangCauHoi.Location = new System.Drawing.Point(13, 3);
            this.grpChonDangCauHoi.Name = "grpChonDangCauHoi";
            this.grpChonDangCauHoi.Size = new System.Drawing.Size(768, 57);
            this.grpChonDangCauHoi.TabIndex = 0;
            this.grpChonDangCauHoi.TabStop = false;
            this.grpChonDangCauHoi.Text = "Chọn dạng câu hỏi";
            // 
            // rdoNgan
            // 
            this.rdoNgan.AutoSize = true;
            this.rdoNgan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNgan.Location = new System.Drawing.Point(511, 19);
            this.rdoNgan.Name = "rdoNgan";
            this.rdoNgan.Size = new System.Drawing.Size(113, 23);
            this.rdoNgan.TabIndex = 1;
            this.rdoNgan.Text = "Trả lời ngắn";
            this.rdoNgan.UseVisualStyleBackColor = true;
            this.rdoNgan.CheckedChanged += new System.EventHandler(this.rdoNgan_CheckedChanged);
            // 
            // rdoNhieu
            // 
            this.rdoNhieu.AutoSize = true;
            this.rdoNhieu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhieu.Location = new System.Drawing.Point(342, 19);
            this.rdoNhieu.Name = "rdoNhieu";
            this.rdoNhieu.Size = new System.Drawing.Size(137, 23);
            this.rdoNhieu.TabIndex = 1;
            this.rdoNhieu.Text = "Tùy chọn nhiều";
            this.rdoNhieu.UseVisualStyleBackColor = true;
            this.rdoNhieu.CheckedChanged += new System.EventHandler(this.rdoNhieu_CheckedChanged);
            // 
            // rdoMot
            // 
            this.rdoMot.AutoSize = true;
            this.rdoMot.Checked = true;
            this.rdoMot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMot.Location = new System.Drawing.Point(181, 19);
            this.rdoMot.Name = "rdoMot";
            this.rdoMot.Size = new System.Drawing.Size(126, 23);
            this.rdoMot.TabIndex = 0;
            this.rdoMot.TabStop = true;
            this.rdoMot.Text = "Tùy chọn một";
            this.rdoMot.UseVisualStyleBackColor = true;
            this.rdoMot.CheckedChanged += new System.EventHandler(this.rdoMot_CheckedChanged);
            // 
            // grpTaoCauHoi
            // 
            this.grpTaoCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTaoCauHoi.Controls.Add(this.panel1);
            this.grpTaoCauHoi.ForeColor = System.Drawing.Color.White;
            this.grpTaoCauHoi.Location = new System.Drawing.Point(13, 62);
            this.grpTaoCauHoi.Name = "grpTaoCauHoi";
            this.grpTaoCauHoi.Size = new System.Drawing.Size(768, 518);
            this.grpTaoCauHoi.TabIndex = 1;
            this.grpTaoCauHoi.TabStop = false;
            this.grpTaoCauHoi.Text = "Tạo câu hỏi";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 492);
            this.panel1.TabIndex = 0;
            // 
            // TaoCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpTaoCauHoi);
            this.Controls.Add(this.grpChonDangCauHoi);
            this.Name = "TaoCauHoi";
            this.Size = new System.Drawing.Size(792, 583);
            this.Load += new System.EventHandler(this.TaoCauHoi_Load);
            this.grpChonDangCauHoi.ResumeLayout(false);
            this.grpChonDangCauHoi.PerformLayout();
            this.grpTaoCauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChonDangCauHoi;
        private System.Windows.Forms.RadioButton rdoNgan;
        private System.Windows.Forms.RadioButton rdoNhieu;
        private System.Windows.Forms.RadioButton rdoMot;
        private System.Windows.Forms.GroupBox grpTaoCauHoi;
        private System.Windows.Forms.Panel panel1;
    }
}
