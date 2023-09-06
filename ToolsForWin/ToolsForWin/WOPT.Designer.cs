
namespace ToolsForWin
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
            this.wopt_btn_cleanfiles = new System.Windows.Forms.Button();
            this.wopt_btn_changepowercfg = new System.Windows.Forms.Button();
            this.wopt_lbl_changepowercfg = new System.Windows.Forms.Label();
            this.wopt_lbl_cleanemptyfiles = new System.Windows.Forms.Label();
            this.wopt_btn_diskcleanup = new System.Windows.Forms.Button();
            this.wopt_lbl_diskcleanup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wopt_btn_cleanfiles
            // 
            this.wopt_btn_cleanfiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wopt_btn_cleanfiles.Location = new System.Drawing.Point(306, 12);
            this.wopt_btn_cleanfiles.Name = "wopt_btn_cleanfiles";
            this.wopt_btn_cleanfiles.Size = new System.Drawing.Size(170, 27);
            this.wopt_btn_cleanfiles.TabIndex = 1;
            this.wopt_btn_cleanfiles.Text = "Clean Empty Files and Folders";
            this.wopt_btn_cleanfiles.UseVisualStyleBackColor = true;
            this.wopt_btn_cleanfiles.Click += new System.EventHandler(this.wopt_btn_cleanfiles_Click);
            // 
            // wopt_btn_changepowercfg
            // 
            this.wopt_btn_changepowercfg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wopt_btn_changepowercfg.Location = new System.Drawing.Point(12, 12);
            this.wopt_btn_changepowercfg.Name = "wopt_btn_changepowercfg";
            this.wopt_btn_changepowercfg.Size = new System.Drawing.Size(288, 27);
            this.wopt_btn_changepowercfg.TabIndex = 2;
            this.wopt_btn_changepowercfg.Text = "Change Power Config to High Performance";
            this.wopt_btn_changepowercfg.UseVisualStyleBackColor = true;
            this.wopt_btn_changepowercfg.Click += new System.EventHandler(this.wopt_btn_changepowercfg_Click);
            // 
            // wopt_lbl_changepowercfg
            // 
            this.wopt_lbl_changepowercfg.AutoSize = true;
            this.wopt_lbl_changepowercfg.Location = new System.Drawing.Point(13, 42);
            this.wopt_lbl_changepowercfg.Name = "wopt_lbl_changepowercfg";
            this.wopt_lbl_changepowercfg.Size = new System.Drawing.Size(0, 13);
            this.wopt_lbl_changepowercfg.TabIndex = 3;
            // 
            // wopt_lbl_cleanemptyfiles
            // 
            this.wopt_lbl_cleanemptyfiles.AutoSize = true;
            this.wopt_lbl_cleanemptyfiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wopt_lbl_cleanemptyfiles.Location = new System.Drawing.Point(239, 42);
            this.wopt_lbl_cleanemptyfiles.Name = "wopt_lbl_cleanemptyfiles";
            this.wopt_lbl_cleanemptyfiles.Size = new System.Drawing.Size(0, 17);
            this.wopt_lbl_cleanemptyfiles.TabIndex = 4;
            // 
            // wopt_btn_diskcleanup
            // 
            this.wopt_btn_diskcleanup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wopt_btn_diskcleanup.Location = new System.Drawing.Point(482, 11);
            this.wopt_btn_diskcleanup.Name = "wopt_btn_diskcleanup";
            this.wopt_btn_diskcleanup.Size = new System.Drawing.Size(135, 28);
            this.wopt_btn_diskcleanup.TabIndex = 5;
            this.wopt_btn_diskcleanup.Text = "Open Disk Cleanup App";
            this.wopt_btn_diskcleanup.UseVisualStyleBackColor = true;
            this.wopt_btn_diskcleanup.Click += new System.EventHandler(this.wopt_btn_diskcleanup_Click);
            // 
            // wopt_lbl_diskcleanup
            // 
            this.wopt_lbl_diskcleanup.AutoSize = true;
            this.wopt_lbl_diskcleanup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wopt_lbl_diskcleanup.Location = new System.Drawing.Point(416, 42);
            this.wopt_lbl_diskcleanup.Name = "wopt_lbl_diskcleanup";
            this.wopt_lbl_diskcleanup.Size = new System.Drawing.Size(0, 17);
            this.wopt_lbl_diskcleanup.TabIndex = 6;
            // 
            // WOPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 66);
            this.Controls.Add(this.wopt_lbl_diskcleanup);
            this.Controls.Add(this.wopt_btn_diskcleanup);
            this.Controls.Add(this.wopt_lbl_cleanemptyfiles);
            this.Controls.Add(this.wopt_lbl_changepowercfg);
            this.Controls.Add(this.wopt_btn_changepowercfg);
            this.Controls.Add(this.wopt_btn_cleanfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WOPT";
            this.Text = "Windows Optimizer";
            this.Load += new System.EventHandler(this.WOPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button wopt_btn_cleanfiles;
        private System.Windows.Forms.Button wopt_btn_changepowercfg;
        private System.Windows.Forms.Label wopt_lbl_changepowercfg;
        private System.Windows.Forms.Label wopt_lbl_cleanemptyfiles;
        private System.Windows.Forms.Button wopt_btn_diskcleanup;
        private System.Windows.Forms.Label wopt_lbl_diskcleanup;
    }
}