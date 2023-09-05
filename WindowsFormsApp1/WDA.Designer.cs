namespace WindowsFormsApp1
{
    partial class WDA
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
            this.wda_btn_compilers = new System.Windows.Forms.Button();
            this.wda_btn_teditors = new System.Windows.Forms.Button();
            this.wda_btn_ides = new System.Windows.Forms.Button();
            this.wda_lbl_ides = new System.Windows.Forms.Label();
            this.wda_lbl_teditors = new System.Windows.Forms.Label();
            this.wda_lbl_compilers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wda_btn_compilers
            // 
            this.wda_btn_compilers.Location = new System.Drawing.Point(12, 70);
            this.wda_btn_compilers.Name = "wda_btn_compilers";
            this.wda_btn_compilers.Size = new System.Drawing.Size(75, 23);
            this.wda_btn_compilers.TabIndex = 1;
            this.wda_btn_compilers.Text = "Compiler\'s";
            this.wda_btn_compilers.UseVisualStyleBackColor = true;
            this.wda_btn_compilers.Click += new System.EventHandler(this.wda_btn_compilers_Click);
            // 
            // wda_btn_teditors
            // 
            this.wda_btn_teditors.Location = new System.Drawing.Point(12, 41);
            this.wda_btn_teditors.Name = "wda_btn_teditors";
            this.wda_btn_teditors.Size = new System.Drawing.Size(75, 23);
            this.wda_btn_teditors.TabIndex = 2;
            this.wda_btn_teditors.Text = "Text Editors";
            this.wda_btn_teditors.UseVisualStyleBackColor = true;
            this.wda_btn_teditors.Click += new System.EventHandler(this.wda_btn_teditors_Click);
            // 
            // wda_btn_ides
            // 
            this.wda_btn_ides.Location = new System.Drawing.Point(12, 12);
            this.wda_btn_ides.Name = "wda_btn_ides";
            this.wda_btn_ides.Size = new System.Drawing.Size(75, 23);
            this.wda_btn_ides.TabIndex = 3;
            this.wda_btn_ides.Text = "IDE\'s";
            this.wda_btn_ides.UseVisualStyleBackColor = true;
            this.wda_btn_ides.Click += new System.EventHandler(this.wda_btn_ides_Click);
            // 
            // wda_lbl_ides
            // 
            this.wda_lbl_ides.AutoSize = true;
            this.wda_lbl_ides.Location = new System.Drawing.Point(93, 17);
            this.wda_lbl_ides.Name = "wda_lbl_ides";
            this.wda_lbl_ides.Size = new System.Drawing.Size(439, 13);
            this.wda_lbl_ides.TabIndex = 4;
            this.wda_lbl_ides.Text = "- IDE (which stands for integrated development environment) is a development envi" +
    "ronment.";
            // 
            // wda_lbl_teditors
            // 
            this.wda_lbl_teditors.AutoSize = true;
            this.wda_lbl_teditors.Location = new System.Drawing.Point(93, 46);
            this.wda_lbl_teditors.Name = "wda_lbl_teditors";
            this.wda_lbl_teditors.Size = new System.Drawing.Size(265, 13);
            this.wda_lbl_teditors.TabIndex = 5;
            this.wda_lbl_teditors.Text = "- Text Editor are programs that exist to edit simple texts.";
            // 
            // wda_lbl_compilers
            // 
            this.wda_lbl_compilers.AutoSize = true;
            this.wda_lbl_compilers.Location = new System.Drawing.Point(93, 75);
            this.wda_lbl_compilers.Name = "wda_lbl_compilers";
            this.wda_lbl_compilers.Size = new System.Drawing.Size(491, 13);
            this.wda_lbl_compilers.TabIndex = 6;
            this.wda_lbl_compilers.Text = "- A special program that translates a source code into machine code or another pr" +
    "ogramming language.";
            // 
            // WDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 103);
            this.Controls.Add(this.wda_lbl_compilers);
            this.Controls.Add(this.wda_lbl_teditors);
            this.Controls.Add(this.wda_lbl_ides);
            this.Controls.Add(this.wda_btn_ides);
            this.Controls.Add(this.wda_btn_teditors);
            this.Controls.Add(this.wda_btn_compilers);
            this.Name = "WDA";
            this.Text = "Windows Developer Apps";
            this.Load += new System.EventHandler(this.WDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button wda_btn_compilers;
        private System.Windows.Forms.Button wda_btn_teditors;
        private System.Windows.Forms.Button wda_btn_ides;
        private System.Windows.Forms.Label wda_lbl_ides;
        private System.Windows.Forms.Label wda_lbl_teditors;
        private System.Windows.Forms.Label wda_lbl_compilers;
    }
}