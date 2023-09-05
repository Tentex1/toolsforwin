namespace WindowsFormsApp1
{
    partial class WDA_COMPILERS
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
            this.compilers_btn_dotnet = new System.Windows.Forms.Button();
            this.compilers_btn_gcc = new System.Windows.Forms.Button();
            this.compilers_btn_rust = new System.Windows.Forms.Button();
            this.compilers_lbl_dotnet = new System.Windows.Forms.Label();
            this.compilers_lbl_gcc = new System.Windows.Forms.Label();
            this.compilers_lbl_rust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compilers_btn_dotnet
            // 
            this.compilers_btn_dotnet.Location = new System.Drawing.Point(13, 13);
            this.compilers_btn_dotnet.Name = "compilers_btn_dotnet";
            this.compilers_btn_dotnet.Size = new System.Drawing.Size(86, 23);
            this.compilers_btn_dotnet.TabIndex = 0;
            this.compilers_btn_dotnet.Text = ".NET Compiler";
            this.compilers_btn_dotnet.UseVisualStyleBackColor = true;
            this.compilers_btn_dotnet.Click += new System.EventHandler(this.compilers_btn_dotnet_Click);
            // 
            // compilers_btn_gcc
            // 
            this.compilers_btn_gcc.Location = new System.Drawing.Point(13, 42);
            this.compilers_btn_gcc.Name = "compilers_btn_gcc";
            this.compilers_btn_gcc.Size = new System.Drawing.Size(131, 23);
            this.compilers_btn_gcc.TabIndex = 1;
            this.compilers_btn_gcc.Text = "GCC (MinGW) Compiler";
            this.compilers_btn_gcc.UseVisualStyleBackColor = true;
            this.compilers_btn_gcc.Click += new System.EventHandler(this.compilers_btn_gcc_Click);
            // 
            // compilers_btn_rust
            // 
            this.compilers_btn_rust.Location = new System.Drawing.Point(13, 71);
            this.compilers_btn_rust.Name = "compilers_btn_rust";
            this.compilers_btn_rust.Size = new System.Drawing.Size(131, 23);
            this.compilers_btn_rust.TabIndex = 2;
            this.compilers_btn_rust.Text = "Rust (Official) Compiler";
            this.compilers_btn_rust.UseVisualStyleBackColor = true;
            this.compilers_btn_rust.Click += new System.EventHandler(this.compilers_btn_rust_Click);
            // 
            // compilers_lbl_dotnet
            // 
            this.compilers_lbl_dotnet.AutoSize = true;
            this.compilers_lbl_dotnet.Location = new System.Drawing.Point(105, 18);
            this.compilers_lbl_dotnet.Name = "compilers_lbl_dotnet";
            this.compilers_lbl_dotnet.Size = new System.Drawing.Size(415, 13);
            this.compilers_lbl_dotnet.TabIndex = 3;
            this.compilers_lbl_dotnet.Text = "- The compiler used to compile the official 3 Microsoft Languages C#, Visual Basi" +
    "c, F#.";
            // 
            // compilers_lbl_gcc
            // 
            this.compilers_lbl_gcc.AutoSize = true;
            this.compilers_lbl_gcc.Location = new System.Drawing.Point(150, 47);
            this.compilers_lbl_gcc.Name = "compilers_lbl_gcc";
            this.compilers_lbl_gcc.Size = new System.Drawing.Size(408, 13);
            this.compilers_lbl_gcc.TabIndex = 4;
            this.compilers_lbl_gcc.Text = "- This Compiler allows you to run 4 languages ​​languages ​​are C, C++, Fortran, " +
    "Go, Ada";
            // 
            // compilers_lbl_rust
            // 
            this.compilers_lbl_rust.AutoSize = true;
            this.compilers_lbl_rust.Location = new System.Drawing.Point(150, 76);
            this.compilers_lbl_rust.Name = "compilers_lbl_rust";
            this.compilers_lbl_rust.Size = new System.Drawing.Size(484, 13);
            this.compilers_lbl_rust.TabIndex = 5;
            this.compilers_lbl_rust.Text = "- It is the official compiler of the Rust programming language. Known for a power" +
    "ful debugging system.";
            // 
            // WDA_COMPILERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 101);
            this.Controls.Add(this.compilers_lbl_rust);
            this.Controls.Add(this.compilers_lbl_gcc);
            this.Controls.Add(this.compilers_lbl_dotnet);
            this.Controls.Add(this.compilers_btn_rust);
            this.Controls.Add(this.compilers_btn_gcc);
            this.Controls.Add(this.compilers_btn_dotnet);
            this.Name = "WDA_COMPILERS";
            this.Text = "Windows Developer Apps - Compiler\'s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compilers_btn_dotnet;
        private System.Windows.Forms.Button compilers_btn_gcc;
        private System.Windows.Forms.Button compilers_btn_rust;
        private System.Windows.Forms.Label compilers_lbl_dotnet;
        private System.Windows.Forms.Label compilers_lbl_gcc;
        private System.Windows.Forms.Label compilers_lbl_rust;
    }
}