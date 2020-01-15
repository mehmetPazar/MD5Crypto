namespace sifreleme
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
            this.Encryption = new System.Windows.Forms.TextBox();
            this.Kripto_string = new System.Windows.Forms.Button();
            this.Kripto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encryption
            // 
            this.Encryption.Location = new System.Drawing.Point(99, 12);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(100, 20);
            this.Encryption.TabIndex = 0;
            // 
            // Kripto_string
            // 
            this.Kripto_string.Location = new System.Drawing.Point(112, 38);
            this.Kripto_string.Name = "Kripto_string";
            this.Kripto_string.Size = new System.Drawing.Size(75, 23);
            this.Kripto_string.TabIndex = 1;
            this.Kripto_string.Text = "Kripto";
            this.Kripto_string.UseVisualStyleBackColor = true;
            this.Kripto_string.Click += new System.EventHandler(this.Kripto_string_Click);
            // 
            // Kripto
            // 
            this.Kripto.AutoSize = true;
            this.Kripto.Location = new System.Drawing.Point(25, 72);
            this.Kripto.Name = "Kripto";
            this.Kripto.Size = new System.Drawing.Size(0, 13);
            this.Kripto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 106);
            this.Controls.Add(this.Kripto);
            this.Controls.Add(this.Kripto_string);
            this.Controls.Add(this.Encryption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Encryption;
        private System.Windows.Forms.Button Kripto_string;
        private System.Windows.Forms.Label Kripto;
    }
}

