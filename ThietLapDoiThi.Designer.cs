namespace GameShowControls
{
    partial class ThietLapDoiThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.flbThemDoiThi = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thêm đội thi";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Transparent;
            this.btnTao.BackgroundImage = global::GameShowControls.Properties.Resources.create;
            this.btnTao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTao.Location = new System.Drawing.Point(15, 48);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(52, 39);
            this.btnTao.TabIndex = 4;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // flbThemDoiThi
            // 
            this.flbThemDoiThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flbThemDoiThi.AutoScroll = true;
            this.flbThemDoiThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flbThemDoiThi.Location = new System.Drawing.Point(15, 93);
            this.flbThemDoiThi.Name = "flbThemDoiThi";
            this.flbThemDoiThi.Size = new System.Drawing.Size(680, 319);
            this.flbThemDoiThi.TabIndex = 3;
            this.flbThemDoiThi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flbThemDoiThi_MouseMove);
            // 
            // ThietLapDoiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.flbThemDoiThi);
            this.Name = "ThietLapDoiThi";
            this.Size = new System.Drawing.Size(748, 446);
            this.Load += new System.EventHandler(this.ThietLapDoiThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        public System.Windows.Forms.FlowLayoutPanel flbThemDoiThi;
    }
}
