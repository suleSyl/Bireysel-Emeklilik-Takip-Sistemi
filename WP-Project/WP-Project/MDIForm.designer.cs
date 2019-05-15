namespace WP_Project
{
    partial class MDIForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.müşteriBilgileriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriyeÖdemeYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.ödemeTakipToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBulToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniMüşteriEkleToolStripMenuItem,
            this.toolStripSeparator2,
            this.müşteriBilgileriniGüncelleToolStripMenuItem,
            this.toolStripSeparator3,
            this.müşteriSilToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriBulToolStripMenuItem
            // 
            this.müşteriBulToolStripMenuItem.Name = "müşteriBulToolStripMenuItem";
            this.müşteriBulToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.müşteriBulToolStripMenuItem.Text = "Müşteri Bul";
            this.müşteriBulToolStripMenuItem.Click += new System.EventHandler(this.mevcutMüşterilerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle";
            this.yeniMüşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşterilerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // müşteriBilgileriniGüncelleToolStripMenuItem
            // 
            this.müşteriBilgileriniGüncelleToolStripMenuItem.Name = "müşteriBilgileriniGüncelleToolStripMenuItem";
            this.müşteriBilgileriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.müşteriBilgileriniGüncelleToolStripMenuItem.Text = "Müşteri Bilgilerini Güncelle";
            this.müşteriBilgileriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriniGüncelleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // ödemeTakipToolStripMenuItem
            // 
            this.ödemeTakipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeGirToolStripMenuItem,
            this.müşteriyeÖdemeYapToolStripMenuItem});
            this.ödemeTakipToolStripMenuItem.Name = "ödemeTakipToolStripMenuItem";
            this.ödemeTakipToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.ödemeTakipToolStripMenuItem.Text = "Ödeme Takip";
            // 
            // ödemeGirToolStripMenuItem
            // 
            this.ödemeGirToolStripMenuItem.Name = "ödemeGirToolStripMenuItem";
            this.ödemeGirToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ödemeGirToolStripMenuItem.Text = "Müşterinin Ödemesini Gir";
            this.ödemeGirToolStripMenuItem.Click += new System.EventHandler(this.ödemeGirToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // müşteriyeÖdemeYapToolStripMenuItem
            // 
            this.müşteriyeÖdemeYapToolStripMenuItem.Name = "müşteriyeÖdemeYapToolStripMenuItem";
            this.müşteriyeÖdemeYapToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.müşteriyeÖdemeYapToolStripMenuItem.Text = "Müşteriye Ödeme Yap";
            this.müşteriyeÖdemeYapToolStripMenuItem.Click += new System.EventHandler(this.müşteriyeÖdemeYapToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 599);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bireysel Emeklilik Takip Sistemi";
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriniGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeGirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriyeÖdemeYapToolStripMenuItem;
    }
}