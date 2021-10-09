
namespace okul_kat_yerleştirme_planı
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.kat_txt = new System.Windows.Forms.TextBox();
            this.goster_btn = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okul Kat Yerleştirme Planı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kat Numarası";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kat_txt
            // 
            this.kat_txt.Location = new System.Drawing.Point(294, 197);
            this.kat_txt.Name = "kat_txt";
            this.kat_txt.Size = new System.Drawing.Size(100, 20);
            this.kat_txt.TabIndex = 2;
            this.kat_txt.TextChanged += new System.EventHandler(this.kat_txt_TextChanged);
            // 
            // goster_btn
            // 
            this.goster_btn.Location = new System.Drawing.Point(434, 190);
            this.goster_btn.Name = "goster_btn";
            this.goster_btn.Size = new System.Drawing.Size(75, 23);
            this.goster_btn.TabIndex = 4;
            this.goster_btn.Text = "Göster";
            this.goster_btn.UseVisualStyleBackColor = true;
            this.goster_btn.Click += new System.EventHandler(this.goster_btn_Click);
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(189, 285);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(320, 95);
            this.liste.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.goster_btn);
            this.Controls.Add(this.kat_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kat_txt;
        private System.Windows.Forms.Button goster_btn;
        private System.Windows.Forms.ListBox liste;
    }
}

