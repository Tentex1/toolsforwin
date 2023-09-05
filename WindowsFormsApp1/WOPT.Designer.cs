namespace WindowsFormsApp1
{
    partial class WOPT
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
            this.wopt_btn_clean_files = new System.Windows.Forms.Button();
            this.wopt_btn_change_power_settings = new System.Windows.Forms.Button();
            this.wopt_lbl_clean_files = new System.Windows.Forms.Label();
            this.wopt_lbl_change_power_cfg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wopt_btn_clean_files
            // 
            this.wopt_btn_clean_files.Location = new System.Drawing.Point(13, 13);
            this.wopt_btn_clean_files.Name = "wopt_btn_clean_files";
            this.wopt_btn_clean_files.Size = new System.Drawing.Size(170, 23);
            this.wopt_btn_clean_files.TabIndex = 0;
            this.wopt_btn_clean_files.Text = "Clean Empty Files and Folders";
            this.wopt_btn_clean_files.UseVisualStyleBackColor = true;
            this.wopt_btn_clean_files.Click += new System.EventHandler(this.wopt_btn_clean_files_Click);
            // 
            // wopt_btn_change_power_settings
            // 
            this.wopt_btn_change_power_settings.Location = new System.Drawing.Point(189, 12);
            this.wopt_btn_change_power_settings.Name = "wopt_btn_change_power_settings";
            this.wopt_btn_change_power_settings.Size = new System.Drawing.Size(202, 23);
            this.wopt_btn_change_power_settings.TabIndex = 1;
            this.wopt_btn_change_power_settings.Text = "Set Power Config to High Performance";
            this.wopt_btn_change_power_settings.UseVisualStyleBackColor = true;
            this.wopt_btn_change_power_settings.Click += new System.EventHandler(this.wopt_btn_change_power_settings_Click);
            // 
            // wopt_lbl_clean_files
            // 
            this.wopt_lbl_clean_files.AutoSize = true;
            this.wopt_lbl_clean_files.Location = new System.Drawing.Point(12, 39);
            this.wopt_lbl_clean_files.Name = "wopt_lbl_clean_files";
            this.wopt_lbl_clean_files.Size = new System.Drawing.Size(0, 13);
            this.wopt_lbl_clean_files.TabIndex = 2;
            // 
            // wopt_lbl_change_power_cfg
            // 
            this.wopt_lbl_change_power_cfg.AutoSize = true;
            this.wopt_lbl_change_power_cfg.Location = new System.Drawing.Point(186, 38);
            this.wopt_lbl_change_power_cfg.Name = "wopt_lbl_change_power_cfg";
            this.wopt_lbl_change_power_cfg.Size = new System.Drawing.Size(0, 13);
            this.wopt_lbl_change_power_cfg.TabIndex = 3;
            // 
            // WOPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 70);
            this.Controls.Add(this.wopt_lbl_change_power_cfg);
            this.Controls.Add(this.wopt_lbl_clean_files);
            this.Controls.Add(this.wopt_btn_change_power_settings);
            this.Controls.Add(this.wopt_btn_clean_files);
            this.Name = "WOPT";
            this.Text = "Windows Optimizer";
            this.Load += new System.EventHandler(this.WOPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wopt_btn_clean_files;
        private System.Windows.Forms.Button wopt_btn_change_power_settings;
        private System.Windows.Forms.Label wopt_lbl_clean_files;
        private System.Windows.Forms.Label wopt_lbl_change_power_cfg;
    }
}