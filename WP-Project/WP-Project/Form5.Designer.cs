namespace WP_Project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tcTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.bulBtn1 = new System.Windows.Forms.Button();
            this.odemeBtn = new System.Windows.Forms.Button();
            this.musteriListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(432, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(638, 73);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ödeme bilgisi girmek istediğiniz müşterinin TC kimlik numarasını giriniz:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(433, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // tcTxtBox
            // 
            this.tcTxtBox.BackColor = System.Drawing.Color.FloralWhite;
            this.tcTxtBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcTxtBox.ForeColor = System.Drawing.Color.Black;
            this.tcTxtBox.Location = new System.Drawing.Point(572, 74);
            this.tcTxtBox.Mask = "0  0  0  0  0  0  0  0  0  0  0";
            this.tcTxtBox.Name = "tcTxtBox";
            this.tcTxtBox.Size = new System.Drawing.Size(213, 29);
            this.tcTxtBox.TabIndex = 34;
            this.tcTxtBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tcTxtBox.TextChanged += new System.EventHandler(this.tcTxtBox_TextChanged);
            // 
            // bulBtn1
            // 
            this.bulBtn1.BackColor = System.Drawing.Color.ForestGreen;
            this.bulBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulBtn1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.bulBtn1.Image = ((System.Drawing.Image)(resources.GetObject("bulBtn1.Image")));
            this.bulBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bulBtn1.Location = new System.Drawing.Point(806, 68);
            this.bulBtn1.Name = "bulBtn1";
            this.bulBtn1.Size = new System.Drawing.Size(87, 39);
            this.bulBtn1.TabIndex = 35;
            this.bulBtn1.Text = "Bul";
            this.bulBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bulBtn1.UseVisualStyleBackColor = false;
            this.bulBtn1.Click += new System.EventHandler(this.bulBtn1_Click);
            // 
            // odemeBtn
            // 
            this.odemeBtn.BackColor = System.Drawing.Color.DimGray;
            this.odemeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.odemeBtn.Enabled = false;
            this.odemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odemeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.odemeBtn.Image = ((System.Drawing.Image)(resources.GetObject("odemeBtn.Image")));
            this.odemeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odemeBtn.Location = new System.Drawing.Point(436, 275);
            this.odemeBtn.Name = "odemeBtn";
            this.odemeBtn.Size = new System.Drawing.Size(634, 55);
            this.odemeBtn.TabIndex = 36;
            this.odemeBtn.Text = "Hesaba Para Yatır";
            this.odemeBtn.UseVisualStyleBackColor = false;
            this.odemeBtn.Click += new System.EventHandler(this.odemeBtn_Click);
            // 
            // musteriListView
            // 
            this.musteriListView.BackColor = System.Drawing.Color.PapayaWhip;
            this.musteriListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader30,
            this.columnHeader29});
            this.musteriListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musteriListView.Location = new System.Drawing.Point(0, 368);
            this.musteriListView.Name = "musteriListView";
            this.musteriListView.Size = new System.Drawing.Size(1094, 193);
            this.musteriListView.TabIndex = 38;
            this.musteriListView.UseCompatibleStateImageBehavior = false;
            this.musteriListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tc";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ad";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Soyad";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Cep Telefonu";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Sabit Telefon";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Doğum Tarihi";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "E-posta";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Adres";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Sisteme Giriş Tarihi";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Son Ödeme Tarihi";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Ödeme Periyodu";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Ödeme Miktarı";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Devlet Katkısı";
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Ödeme Şekli";
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Biriken Tutar";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 561);
            this.Controls.Add(this.musteriListView);
            this.Controls.Add(this.odemeBtn);
            this.Controls.Add(this.bulBtn1);
            this.Controls.Add(this.tcTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tcTxtBox;
        private System.Windows.Forms.Button bulBtn1;
        private System.Windows.Forms.Button odemeBtn;
        private System.Windows.Forms.ListView musteriListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader29;
    }
}