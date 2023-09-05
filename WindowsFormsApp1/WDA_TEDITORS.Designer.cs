namespace WindowsFormsApp1
{
    partial class WDA_TEDITORS
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
            this.teditors_btn_atom = new System.Windows.Forms.Button();
            this.teditors_btn_brackets = new System.Windows.Forms.Button();
            this.teditors_btn_gvim = new System.Windows.Forms.Button();
            this.teditors_btn_lighttable = new System.Windows.Forms.Button();
            this.teditors_btn_neovim = new System.Windows.Forms.Button();
            this.teditors_btn_npp = new System.Windows.Forms.Button();
            this.teditors_btn_n2 = new System.Windows.Forms.Button();
            this.teditors_btn_sublimetext = new System.Windows.Forms.Button();
            this.teditors_lbl_atom = new System.Windows.Forms.Label();
            this.teditors_lbl_brackets = new System.Windows.Forms.Label();
            this.teditors_lbl_gvim = new System.Windows.Forms.Label();
            this.teditors_lbl_lighttable = new System.Windows.Forms.Label();
            this.teditors_lbl_neovim = new System.Windows.Forms.Label();
            this.teditors_lbl_npp = new System.Windows.Forms.Label();
            this.teditors_lbl_sublimetext = new System.Windows.Forms.Label();
            this.teditors_lbl_n2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teditors_btn_atom
            // 
            this.teditors_btn_atom.Location = new System.Drawing.Point(13, 13);
            this.teditors_btn_atom.Name = "teditors_btn_atom";
            this.teditors_btn_atom.Size = new System.Drawing.Size(101, 23);
            this.teditors_btn_atom.TabIndex = 0;
            this.teditors_btn_atom.Text = "Atom Text Editor";
            this.teditors_btn_atom.UseVisualStyleBackColor = true;
            this.teditors_btn_atom.Click += new System.EventHandler(this.teditors_btn_atom_Click);
            // 
            // teditors_btn_brackets
            // 
            this.teditors_btn_brackets.Location = new System.Drawing.Point(13, 42);
            this.teditors_btn_brackets.Name = "teditors_btn_brackets";
            this.teditors_btn_brackets.Size = new System.Drawing.Size(121, 23);
            this.teditors_btn_brackets.TabIndex = 1;
            this.teditors_btn_brackets.Text = "Brackets Text Editor";
            this.teditors_btn_brackets.UseVisualStyleBackColor = true;
            this.teditors_btn_brackets.Click += new System.EventHandler(this.teditors_btn_brackets_Click);
            // 
            // teditors_btn_gvim
            // 
            this.teditors_btn_gvim.Location = new System.Drawing.Point(13, 71);
            this.teditors_btn_gvim.Name = "teditors_btn_gvim";
            this.teditors_btn_gvim.Size = new System.Drawing.Size(101, 23);
            this.teditors_btn_gvim.TabIndex = 2;
            this.teditors_btn_gvim.Text = "GVim Text Editor";
            this.teditors_btn_gvim.UseVisualStyleBackColor = true;
            this.teditors_btn_gvim.Click += new System.EventHandler(this.teditors_btn_gvim_Click);
            // 
            // teditors_btn_lighttable
            // 
            this.teditors_btn_lighttable.Location = new System.Drawing.Point(13, 100);
            this.teditors_btn_lighttable.Name = "teditors_btn_lighttable";
            this.teditors_btn_lighttable.Size = new System.Drawing.Size(132, 23);
            this.teditors_btn_lighttable.TabIndex = 3;
            this.teditors_btn_lighttable.Text = "Light Table Text Editor";
            this.teditors_btn_lighttable.UseVisualStyleBackColor = true;
            this.teditors_btn_lighttable.Click += new System.EventHandler(this.teditors_btn_lighttable_Click);
            // 
            // teditors_btn_neovim
            // 
            this.teditors_btn_neovim.Location = new System.Drawing.Point(13, 129);
            this.teditors_btn_neovim.Name = "teditors_btn_neovim";
            this.teditors_btn_neovim.Size = new System.Drawing.Size(121, 23);
            this.teditors_btn_neovim.TabIndex = 4;
            this.teditors_btn_neovim.Text = "NeoVim Text Editor";
            this.teditors_btn_neovim.UseVisualStyleBackColor = true;
            this.teditors_btn_neovim.Click += new System.EventHandler(this.teditors_btn_neovim_Click);
            // 
            // teditors_btn_npp
            // 
            this.teditors_btn_npp.Location = new System.Drawing.Point(13, 158);
            this.teditors_btn_npp.Name = "teditors_btn_npp";
            this.teditors_btn_npp.Size = new System.Drawing.Size(132, 23);
            this.teditors_btn_npp.TabIndex = 5;
            this.teditors_btn_npp.Text = "Notepad++ Text Editor";
            this.teditors_btn_npp.UseVisualStyleBackColor = true;
            this.teditors_btn_npp.Click += new System.EventHandler(this.teditors_btn_npp_Click);
            // 
            // teditors_btn_n2
            // 
            this.teditors_btn_n2.Location = new System.Drawing.Point(13, 187);
            this.teditors_btn_n2.Name = "teditors_btn_n2";
            this.teditors_btn_n2.Size = new System.Drawing.Size(121, 23);
            this.teditors_btn_n2.TabIndex = 6;
            this.teditors_btn_n2.Text = "Notepad2 Text Editor";
            this.teditors_btn_n2.UseVisualStyleBackColor = true;
            this.teditors_btn_n2.Click += new System.EventHandler(this.teditors_btn_n2_Click);
            // 
            // teditors_btn_sublimetext
            // 
            this.teditors_btn_sublimetext.Location = new System.Drawing.Point(12, 216);
            this.teditors_btn_sublimetext.Name = "teditors_btn_sublimetext";
            this.teditors_btn_sublimetext.Size = new System.Drawing.Size(111, 23);
            this.teditors_btn_sublimetext.TabIndex = 7;
            this.teditors_btn_sublimetext.Text = "Sublime Text Editor";
            this.teditors_btn_sublimetext.UseVisualStyleBackColor = true;
            this.teditors_btn_sublimetext.Click += new System.EventHandler(this.teditors_btn_sublimetext_Click);
            // 
            // teditors_lbl_atom
            // 
            this.teditors_lbl_atom.AutoSize = true;
            this.teditors_lbl_atom.Location = new System.Drawing.Point(120, 18);
            this.teditors_lbl_atom.Name = "teditors_lbl_atom";
            this.teditors_lbl_atom.Size = new System.Drawing.Size(214, 13);
            this.teditors_lbl_atom.TabIndex = 8;
            this.teditors_lbl_atom.Text = "- A hackable text editor for the 21st Century.";
            // 
            // teditors_lbl_brackets
            // 
            this.teditors_lbl_brackets.AutoSize = true;
            this.teditors_lbl_brackets.Location = new System.Drawing.Point(140, 47);
            this.teditors_lbl_brackets.Name = "teditors_lbl_brackets";
            this.teditors_lbl_brackets.Size = new System.Drawing.Size(314, 13);
            this.teditors_lbl_brackets.TabIndex = 9;
            this.teditors_lbl_brackets.Text = "- A modern, open source text editor that understands web design.";
            // 
            // teditors_lbl_gvim
            // 
            this.teditors_lbl_gvim.AutoSize = true;
            this.teditors_lbl_gvim.Location = new System.Drawing.Point(120, 76);
            this.teditors_lbl_gvim.Name = "teditors_lbl_gvim";
            this.teditors_lbl_gvim.Size = new System.Drawing.Size(369, 13);
            this.teditors_lbl_gvim.TabIndex = 10;
            this.teditors_lbl_gvim.Text = "- (G)Vim is a highly configurable text editor built to enable efficient text edit" +
    "ing.";
            // 
            // teditors_lbl_lighttable
            // 
            this.teditors_lbl_lighttable.AutoSize = true;
            this.teditors_lbl_lighttable.Location = new System.Drawing.Point(151, 105);
            this.teditors_lbl_lighttable.Name = "teditors_lbl_lighttable";
            this.teditors_lbl_lighttable.Size = new System.Drawing.Size(452, 13);
            this.teditors_lbl_lighttable.TabIndex = 11;
            this.teditors_lbl_lighttable.Text = "- A customizable editor with instant feedback and showing data values flow throug" +
    "h your code.";
            // 
            // teditors_lbl_neovim
            // 
            this.teditors_lbl_neovim.AutoSize = true;
            this.teditors_lbl_neovim.Location = new System.Drawing.Point(140, 134);
            this.teditors_lbl_neovim.Name = "teditors_lbl_neovim";
            this.teditors_lbl_neovim.Size = new System.Drawing.Size(123, 13);
            this.teditors_lbl_neovim.TabIndex = 12;
            this.teditors_lbl_neovim.Text = "- literally the future of vim";
            // 
            // teditors_lbl_npp
            // 
            this.teditors_lbl_npp.AutoSize = true;
            this.teditors_lbl_npp.Location = new System.Drawing.Point(151, 163);
            this.teditors_lbl_npp.Name = "teditors_lbl_npp";
            this.teditors_lbl_npp.Size = new System.Drawing.Size(340, 13);
            this.teditors_lbl_npp.TabIndex = 13;
            this.teditors_lbl_npp.Text = "- A source code editor which supports several programming languages.";
            // 
            // teditors_lbl_sublimetext
            // 
            this.teditors_lbl_sublimetext.AutoSize = true;
            this.teditors_lbl_sublimetext.Location = new System.Drawing.Point(129, 221);
            this.teditors_lbl_sublimetext.Name = "teditors_lbl_sublimetext";
            this.teditors_lbl_sublimetext.Size = new System.Drawing.Size(149, 13);
            this.teditors_lbl_sublimetext.TabIndex = 14;
            this.teditors_lbl_sublimetext.Text = "- The sophisticated text editor.";
            // 
            // teditors_lbl_n2
            // 
            this.teditors_lbl_n2.AutoSize = true;
            this.teditors_lbl_n2.Location = new System.Drawing.Point(140, 192);
            this.teditors_lbl_n2.Name = "teditors_lbl_n2";
            this.teditors_lbl_n2.Size = new System.Drawing.Size(304, 13);
            this.teditors_lbl_n2.TabIndex = 15;
            this.teditors_lbl_n2.Text = "- Tiny and fast Notepad replacement with many useful features.";
            // 
            // WDA_TEDITORS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 255);
            this.Controls.Add(this.teditors_lbl_n2);
            this.Controls.Add(this.teditors_lbl_sublimetext);
            this.Controls.Add(this.teditors_lbl_npp);
            this.Controls.Add(this.teditors_lbl_neovim);
            this.Controls.Add(this.teditors_lbl_lighttable);
            this.Controls.Add(this.teditors_lbl_gvim);
            this.Controls.Add(this.teditors_lbl_brackets);
            this.Controls.Add(this.teditors_lbl_atom);
            this.Controls.Add(this.teditors_btn_sublimetext);
            this.Controls.Add(this.teditors_btn_n2);
            this.Controls.Add(this.teditors_btn_npp);
            this.Controls.Add(this.teditors_btn_neovim);
            this.Controls.Add(this.teditors_btn_lighttable);
            this.Controls.Add(this.teditors_btn_gvim);
            this.Controls.Add(this.teditors_btn_brackets);
            this.Controls.Add(this.teditors_btn_atom);
            this.Name = "WDA_TEDITORS";
            this.Text = "Windows Developer Apps - Text Editors";
            this.Load += new System.EventHandler(this.WDA_TEDITORS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teditors_btn_atom;
        private System.Windows.Forms.Button teditors_btn_brackets;
        private System.Windows.Forms.Button teditors_btn_gvim;
        private System.Windows.Forms.Button teditors_btn_lighttable;
        private System.Windows.Forms.Button teditors_btn_neovim;
        private System.Windows.Forms.Button teditors_btn_npp;
        private System.Windows.Forms.Button teditors_btn_n2;
        private System.Windows.Forms.Button teditors_btn_sublimetext;
        private System.Windows.Forms.Label teditors_lbl_atom;
        private System.Windows.Forms.Label teditors_lbl_brackets;
        private System.Windows.Forms.Label teditors_lbl_gvim;
        private System.Windows.Forms.Label teditors_lbl_lighttable;
        private System.Windows.Forms.Label teditors_lbl_neovim;
        private System.Windows.Forms.Label teditors_lbl_npp;
        private System.Windows.Forms.Label teditors_lbl_sublimetext;
        private System.Windows.Forms.Label teditors_lbl_n2;
    }
}