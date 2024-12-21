namespace SmartTicket.comV1
{
    partial class oListeAracı
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbloAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbloAdi
            // 
            this.lbloAdi.AutoSize = true;
            this.lbloAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.lbloAdi.Location = new System.Drawing.Point(2, 11);
            this.lbloAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloAdi.Name = "lbloAdi";
            this.lbloAdi.Size = new System.Drawing.Size(36, 13);
            this.lbloAdi.TabIndex = 3;
            this.lbloAdi.Text = "label1";
            this.lbloAdi.Click += new System.EventHandler(this.lbloAdi_Click);
            this.lbloAdi.MouseLeave += new System.EventHandler(this.lbloAdi_MouseLeave);
            this.lbloAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbloAdi_MouseMove);
            // 
            // oListeAracı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbloAdi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "oListeAracı";
            this.Size = new System.Drawing.Size(116, 37);
            this.Load += new System.EventHandler(this.oListeAracı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbloAdi;
    }
}
