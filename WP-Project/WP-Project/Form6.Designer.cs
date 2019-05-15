namespace WP_Project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.odemeYapBtn = new System.Windows.Forms.Button();
            this.tcTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odemeYapBtn
            // 
            this.odemeYapBtn.BackColor = System.Drawing.Color.DimGray;
            this.odemeYapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.odemeYapBtn.Enabled = false;
            this.odemeYapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odemeYapBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeYapBtn.ForeColor = System.Drawing.Color.Transparent;
            this.odemeYapBtn.Image = ((System.Drawing.Image)(resources.GetObject("odemeYapBtn.Image")));
            this.odemeYapBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odemeYapBtn.Location = new System.Drawing.Point(401, 102);
            this.odemeYapBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odemeYapBtn.Name = "odemeYapBtn";
            this.odemeYapBtn.Size = new System.Drawing.Size(318, 38);
            this.odemeYapBtn.TabIndex = 124;
            this.odemeYapBtn.Text = "Müşteriye Ödeme Yap";
            this.odemeYapBtn.UseVisualStyleBackColor = false;
            this.odemeYapBtn.Click += new System.EventHandler(this.odemeYapBtn_Click);
            // 
            // tcTxtBox
            // 
            this.tcTxtBox.BackColor = System.Drawing.Color.LightCoral;
            this.tcTxtBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcTxtBox.ForeColor = System.Drawing.Color.White;
            this.tcTxtBox.Location = new System.Drawing.Point(177, 106);
            this.tcTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcTxtBox.Mask = "0  0  0  0  0  0  0  0  0  0  0";
            this.tcTxtBox.Name = "tcTxtBox";
            this.tcTxtBox.Size = new System.Drawing.Size(201, 29);
            this.tcTxtBox.TabIndex = 123;
            this.tcTxtBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tcTxtBox.TextChanged += new System.EventHandler(this.tcTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 122;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 23);
            this.label1.TabIndex = 125;
            this.label1.Text = "Ödeme yapılacak olan müşterinin TC kimlik numarasını giriniz:";
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(71)))), ((int)(((byte)(52)))));
            this.iptalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iptalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalBtn.ForeColor = System.Drawing.Color.White;
            this.iptalBtn.Image = ((System.Drawing.Image)(resources.GetObject("iptalBtn.Image")));
            this.iptalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iptalBtn.Location = new System.Drawing.Point(401, 152);
            this.iptalBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(318, 39);
            this.iptalBtn.TabIndex = 157;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 561);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odemeYapBtn);
            this.Controls.Add(this.tcTxtBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odemeYapBtn;
        public System.Windows.Forms.MaskedTextBox tcTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iptalBtn;
    }
}