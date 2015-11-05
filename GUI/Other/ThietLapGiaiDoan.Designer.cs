namespace GameShowControls
{
    partial class ThietLapGiaiDoan
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
            this.flbThemVongThi = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flbThemVongThi
            // 
            this.flbThemVongThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flbThemVongThi.AutoScroll = true;
            this.flbThemVongThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flbThemVongThi.Location = new System.Drawing.Point(15, 88);
            this.flbThemVongThi.Name = "flbThemVongThi";
            this.flbThemVongThi.Size = new System.Drawing.Size(649, 309);
            this.flbThemVongThi.TabIndex = 0;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Transparent;
            this.btnTao.BackgroundImage = global::GameShowControls.Properties.Resources.create;
            this.btnTao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTao.Location = new System.Drawing.Point(15, 43);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(52, 39);
            this.btnTao.TabIndex = 1;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm vòng thi";
            // 
            // ThietLapGiaiDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.flbThemVongThi);
            this.Name = "ThietLapGiaiDoan";
            this.Size = new System.Drawing.Size(748, 446);
            this.Load += new System.EventHandler(this.ThietLapGiaiDoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flbThemVongThi;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label1;
    }
}
