namespace Hesap_Makinesi
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cikti = new System.Windows.Forms.Label();
            this.sayi0 = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.Button();
            this.sayi2 = new System.Windows.Forms.Button();
            this.sayi3 = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.sayi4 = new System.Windows.Forms.Button();
            this.sayi5 = new System.Windows.Forms.Button();
            this.sayi6 = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.sayi7 = new System.Windows.Forms.Button();
            this.sayi8 = new System.Windows.Forms.Button();
            this.sayi9 = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.virgul = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cikti
            // 
            this.cikti.BackColor = System.Drawing.SystemColors.Window;
            this.cikti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikti.Location = new System.Drawing.Point(15, 25);
            this.cikti.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cikti.Name = "cikti";
            this.cikti.Size = new System.Drawing.Size(327, 99);
            this.cikti.TabIndex = 0;
            this.cikti.Text = "0";
            this.cikti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sayi0
            // 
            this.sayi0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi0.Location = new System.Drawing.Point(27, 376);
            this.sayi0.Name = "sayi0";
            this.sayi0.Size = new System.Drawing.Size(70, 70);
            this.sayi0.TabIndex = 1;
            this.sayi0.Text = "0";
            this.sayi0.UseVisualStyleBackColor = false;
            this.sayi0.Click += new System.EventHandler(this.sayi0_Click);
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sonuc.Location = new System.Drawing.Point(179, 376);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(70, 70);
            this.sonuc.TabIndex = 3;
            this.sonuc.Text = "=";
            this.sonuc.UseVisualStyleBackColor = false;
            this.sonuc.Click += new System.EventHandler(this.sonuc_Click);
            // 
            // topla
            // 
            this.topla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.topla.Location = new System.Drawing.Point(255, 376);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(70, 70);
            this.topla.TabIndex = 4;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = false;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // sayi1
            // 
            this.sayi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi1.Location = new System.Drawing.Point(27, 300);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(70, 70);
            this.sayi1.TabIndex = 1;
            this.sayi1.Text = "1";
            this.sayi1.UseVisualStyleBackColor = false;
            this.sayi1.Click += new System.EventHandler(this.sayi1_Click);
            // 
            // sayi2
            // 
            this.sayi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi2.Location = new System.Drawing.Point(103, 300);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(70, 70);
            this.sayi2.TabIndex = 2;
            this.sayi2.Text = "2";
            this.sayi2.UseVisualStyleBackColor = false;
            this.sayi2.Click += new System.EventHandler(this.sayi2_Click);
            // 
            // sayi3
            // 
            this.sayi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi3.Location = new System.Drawing.Point(179, 300);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(70, 70);
            this.sayi3.TabIndex = 3;
            this.sayi3.Text = "3";
            this.sayi3.UseVisualStyleBackColor = false;
            this.sayi3.Click += new System.EventHandler(this.sayi3_Click);
            // 
            // cikar
            // 
            this.cikar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cikar.Location = new System.Drawing.Point(255, 300);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(70, 70);
            this.cikar.TabIndex = 4;
            this.cikar.Text = "-";
            this.cikar.UseVisualStyleBackColor = false;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // sayi4
            // 
            this.sayi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi4.Location = new System.Drawing.Point(27, 224);
            this.sayi4.Name = "sayi4";
            this.sayi4.Size = new System.Drawing.Size(70, 70);
            this.sayi4.TabIndex = 1;
            this.sayi4.Text = "4";
            this.sayi4.UseVisualStyleBackColor = false;
            this.sayi4.Click += new System.EventHandler(this.sayi4_Click);
            // 
            // sayi5
            // 
            this.sayi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi5.Location = new System.Drawing.Point(103, 224);
            this.sayi5.Name = "sayi5";
            this.sayi5.Size = new System.Drawing.Size(70, 70);
            this.sayi5.TabIndex = 2;
            this.sayi5.Text = "5";
            this.sayi5.UseVisualStyleBackColor = false;
            this.sayi5.Click += new System.EventHandler(this.sayi5_Click);
            // 
            // sayi6
            // 
            this.sayi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi6.Location = new System.Drawing.Point(179, 224);
            this.sayi6.Name = "sayi6";
            this.sayi6.Size = new System.Drawing.Size(70, 70);
            this.sayi6.TabIndex = 3;
            this.sayi6.Text = "6";
            this.sayi6.UseVisualStyleBackColor = false;
            this.sayi6.Click += new System.EventHandler(this.sayi6_Click);
            // 
            // carp
            // 
            this.carp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.carp.Location = new System.Drawing.Point(255, 224);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(70, 70);
            this.carp.TabIndex = 4;
            this.carp.Text = "*";
            this.carp.UseVisualStyleBackColor = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // sayi7
            // 
            this.sayi7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi7.Location = new System.Drawing.Point(27, 148);
            this.sayi7.Name = "sayi7";
            this.sayi7.Size = new System.Drawing.Size(70, 70);
            this.sayi7.TabIndex = 1;
            this.sayi7.Text = "7";
            this.sayi7.UseVisualStyleBackColor = false;
            this.sayi7.Click += new System.EventHandler(this.sayi7_Click);
            // 
            // sayi8
            // 
            this.sayi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi8.Location = new System.Drawing.Point(103, 148);
            this.sayi8.Name = "sayi8";
            this.sayi8.Size = new System.Drawing.Size(70, 70);
            this.sayi8.TabIndex = 2;
            this.sayi8.Text = "8";
            this.sayi8.UseVisualStyleBackColor = false;
            this.sayi8.Click += new System.EventHandler(this.sayi8_Click);
            // 
            // sayi9
            // 
            this.sayi9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi9.Location = new System.Drawing.Point(179, 148);
            this.sayi9.Name = "sayi9";
            this.sayi9.Size = new System.Drawing.Size(70, 70);
            this.sayi9.TabIndex = 3;
            this.sayi9.Text = "9";
            this.sayi9.UseVisualStyleBackColor = false;
            this.sayi9.Click += new System.EventHandler(this.sayi9_Click);
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bol.Location = new System.Drawing.Point(255, 148);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(70, 70);
            this.bol.TabIndex = 4;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // virgul
            // 
            this.virgul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.virgul.Location = new System.Drawing.Point(103, 376);
            this.virgul.Name = "virgul";
            this.virgul.Size = new System.Drawing.Size(70, 70);
            this.virgul.TabIndex = 5;
            this.virgul.Text = ",";
            this.virgul.UseVisualStyleBackColor = false;
            this.virgul.Click += new System.EventHandler(this.virgul_Click);
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.White;
            this.temizle.Location = new System.Drawing.Point(27, 452);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(298, 50);
            this.temizle.TabIndex = 6;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.sonuc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.virgul);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.sayi9);
            this.Controls.Add(this.sayi8);
            this.Controls.Add(this.sayi6);
            this.Controls.Add(this.sayi5);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi7);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi4);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.sayi0);
            this.Controls.Add(this.cikti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cikti;
        private System.Windows.Forms.Button sayi0;
        private System.Windows.Forms.Button sonuc;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button sayi1;
        private System.Windows.Forms.Button sayi2;
        private System.Windows.Forms.Button sayi3;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button sayi4;
        private System.Windows.Forms.Button sayi5;
        private System.Windows.Forms.Button sayi6;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button sayi7;
        private System.Windows.Forms.Button sayi8;
        private System.Windows.Forms.Button sayi9;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button virgul;
        private System.Windows.Forms.Button temizle;
    }
}

