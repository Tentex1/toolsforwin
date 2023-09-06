
namespace ToolsForWin
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
            this.twf_btn_about = new System.Windows.Forms.Button();
            this.twf_btn_wopt = new System.Windows.Forms.Button();
            this.twf_lbl_enterance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // twf_btn_about
            // 
            this.twf_btn_about.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.twf_btn_about.Location = new System.Drawing.Point(645, 106);
            this.twf_btn_about.Name = "twf_btn_about";
            this.twf_btn_about.Size = new System.Drawing.Size(95, 42);
            this.twf_btn_about.TabIndex = 1;
            this.twf_btn_about.Text = "About";
            this.twf_btn_about.UseVisualStyleBackColor = true;
            this.twf_btn_about.Click += new System.EventHandler(this.twf_btn_about_Click);
            // 
            // twf_btn_wopt
            // 
            this.twf_btn_wopt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.twf_btn_wopt.Location = new System.Drawing.Point(12, 48);
            this.twf_btn_wopt.Name = "twf_btn_wopt";
            this.twf_btn_wopt.Size = new System.Drawing.Size(95, 44);
            this.twf_btn_wopt.TabIndex = 2;
            this.twf_btn_wopt.Text = "Windows Optimizer";
            this.twf_btn_wopt.UseVisualStyleBackColor = true;
            this.twf_btn_wopt.Click += new System.EventHandler(this.twf_btn_wopt_Click);
            // 
            // twf_lbl_enterance
            // 
            this.twf_lbl_enterance.AutoSize = true;
            this.twf_lbl_enterance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.twf_lbl_enterance.Location = new System.Drawing.Point(13, 22);
            this.twf_lbl_enterance.Name = "twf_lbl_enterance";
            this.twf_lbl_enterance.Size = new System.Drawing.Size(737, 17);
            this.twf_lbl_enterance.TabIndex = 3;
            this.twf_lbl_enterance.Text = "hello, welcome to the program, what are you waiting for, it can be added in the f" +
    "uture about hacking, you test it, I think";
            // 
            // TFW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 160);
            this.Controls.Add(this.twf_lbl_enterance);
            this.Controls.Add(this.twf_btn_wopt);
            this.Controls.Add(this.twf_btn_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TFW";
            this.Text = "Tools For Windows";
            this.Load += new System.EventHandler(this.TWF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button twf_btn_about;
        private System.Windows.Forms.Button twf_btn_wopt;
        private System.Windows.Forms.Label twf_lbl_enterance;
    }
}

