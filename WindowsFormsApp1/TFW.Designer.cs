namespace WindowsFormsApp1
{
    partial class TFW
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
            this.tfw_btn_wda = new System.Windows.Forms.Button();
            this.tfw_btn_wopt = new System.Windows.Forms.Button();
            this.twf_lbl_enterance = new System.Windows.Forms.Label();
            this.tfw_lbl_info = new System.Windows.Forms.Label();
            this.tfw_lbl_copyright = new System.Windows.Forms.Label();
            this.tfw_btn_website = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tfw_btn_wda
            // 
            this.tfw_btn_wda.Location = new System.Drawing.Point(12, 58);
            this.tfw_btn_wda.Name = "tfw_btn_wda";
            this.tfw_btn_wda.Size = new System.Drawing.Size(94, 39);
            this.tfw_btn_wda.TabIndex = 2;
            this.tfw_btn_wda.Text = "Windows Developer Apps";
            this.tfw_btn_wda.UseVisualStyleBackColor = true;
            this.tfw_btn_wda.Click += new System.EventHandler(this.btn_wda_Click);
            // 
            // tfw_btn_wopt
            // 
            this.tfw_btn_wopt.Location = new System.Drawing.Point(11, 103);
            this.tfw_btn_wopt.Name = "tfw_btn_wopt";
            this.tfw_btn_wopt.Size = new System.Drawing.Size(95, 36);
            this.tfw_btn_wopt.TabIndex = 3;
            this.tfw_btn_wopt.Text = "Windows Optimizer";
            this.tfw_btn_wopt.UseVisualStyleBackColor = true;
            this.tfw_btn_wopt.Click += new System.EventHandler(this.btn_wopt_Click);
            // 
            // twf_lbl_enterance
            // 
            this.twf_lbl_enterance.AutoSize = true;
            this.twf_lbl_enterance.Location = new System.Drawing.Point(13, 23);
            this.twf_lbl_enterance.Name = "twf_lbl_enterance";
            this.twf_lbl_enterance.Size = new System.Drawing.Size(383, 13);
            this.twf_lbl_enterance.TabIndex = 4;
            this.twf_lbl_enterance.Text = "Hello, Welcome to the program. This program offers some features for Windows.";
            // 
            // tfw_lbl_info
            // 
            this.tfw_lbl_info.AutoSize = true;
            this.tfw_lbl_info.Location = new System.Drawing.Point(13, 409);
            this.tfw_lbl_info.Name = "tfw_lbl_info";
            this.tfw_lbl_info.Size = new System.Drawing.Size(198, 13);
            this.tfw_lbl_info.TabIndex = 5;
            this.tfw_lbl_info.Text = "Program, UI Desing and Code by Tentex";
            // 
            // tfw_lbl_copyright
            // 
            this.tfw_lbl_copyright.AutoSize = true;
            this.tfw_lbl_copyright.Location = new System.Drawing.Point(13, 428);
            this.tfw_lbl_copyright.Name = "tfw_lbl_copyright";
            this.tfw_lbl_copyright.Size = new System.Drawing.Size(110, 13);
            this.tfw_lbl_copyright.TabIndex = 6;
            this.tfw_lbl_copyright.Text = "Copyright by Tentex :)";
            // 
            // tfw_btn_website
            // 
            this.tfw_btn_website.Location = new System.Drawing.Point(456, 409);
            this.tfw_btn_website.Name = "tfw_btn_website";
            this.tfw_btn_website.Size = new System.Drawing.Size(159, 31);
            this.tfw_btn_website.TabIndex = 7;
            this.tfw_btn_website.Text = "Tentex/duranforreal\'s Website";
            this.tfw_btn_website.UseVisualStyleBackColor = true;
            this.tfw_btn_website.Click += new System.EventHandler(this.tfw_btn_website_Click);
            // 
            // TFW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.tfw_btn_website);
            this.Controls.Add(this.tfw_lbl_copyright);
            this.Controls.Add(this.tfw_lbl_info);
            this.Controls.Add(this.twf_lbl_enterance);
            this.Controls.Add(this.tfw_btn_wopt);
            this.Controls.Add(this.tfw_btn_wda);
            this.Name = "TFW";
            this.Text = "Tools For Windows";
            this.Load += new System.EventHandler(this.TFW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tfw_btn_wda;
        private System.Windows.Forms.Button tfw_btn_wopt;
        private System.Windows.Forms.Label twf_lbl_enterance;
        private System.Windows.Forms.Label tfw_lbl_info;
        private System.Windows.Forms.Label tfw_lbl_copyright;
        private System.Windows.Forms.Button tfw_btn_website;
    }
}

