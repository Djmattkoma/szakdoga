namespace szakdoga
{
    partial class frm_fomenu
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
            this.btn_bejel = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.cmb_nyelvek = new System.Windows.Forms.ComboBox();
            this.pnl_felh = new System.Windows.Forms.Panel();
            this.pln_jelsz = new System.Windows.Forms.Panel();
            this.tb_felhnev = new System.Windows.Forms.TextBox();
            this.tb_jelsz = new System.Windows.Forms.TextBox();
            this.btn_sos = new System.Windows.Forms.Button();
            this.lbl_marvan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bejel
            // 
            this.btn_bejel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bejel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_bejel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(173)))));
            this.btn_bejel.Location = new System.Drawing.Point(40, 225);
            this.btn_bejel.Name = "btn_bejel";
            this.btn_bejel.Size = new System.Drawing.Size(90, 40);
            this.btn_bejel.TabIndex = 0;
            this.btn_bejel.Text = "###";
            this.btn_bejel.UseVisualStyleBackColor = true;
            this.btn_bejel.Click += new System.EventHandler(this.btn_bejel_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(148)))), ((int)(((byte)(173)))));
            this.btn_reg.Location = new System.Drawing.Point(220, 225);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(90, 40);
            this.btn_reg.TabIndex = 1;
            this.btn_reg.Text = "###";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // cmb_nyelvek
            // 
            this.cmb_nyelvek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_nyelvek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_nyelvek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_nyelvek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(139)))));
            this.cmb_nyelvek.FormattingEnabled = true;
            this.cmb_nyelvek.Items.AddRange(new object[] {
            "eng",
            "hun"});
            this.cmb_nyelvek.Location = new System.Drawing.Point(12, 12);
            this.cmb_nyelvek.Name = "cmb_nyelvek";
            this.cmb_nyelvek.Size = new System.Drawing.Size(80, 24);
            this.cmb_nyelvek.TabIndex = 2;
            this.cmb_nyelvek.SelectedIndexChanged += new System.EventHandler(this.cmb_nyelvek_SelectedIndexChanged);
            // 
            // pnl_felh
            // 
            this.pnl_felh.BackgroundImage = global::szakdoga.Properties.Resources.user;
            this.pnl_felh.Location = new System.Drawing.Point(105, 40);
            this.pnl_felh.Name = "pnl_felh";
            this.pnl_felh.Size = new System.Drawing.Size(30, 30);
            this.pnl_felh.TabIndex = 3;
            // 
            // pln_jelsz
            // 
            this.pln_jelsz.BackgroundImage = global::szakdoga.Properties.Resources.pass;
            this.pln_jelsz.Location = new System.Drawing.Point(105, 104);
            this.pln_jelsz.Name = "pln_jelsz";
            this.pln_jelsz.Size = new System.Drawing.Size(30, 30);
            this.pln_jelsz.TabIndex = 4;
            // 
            // tb_felhnev
            // 
            this.tb_felhnev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_felhnev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_felhnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_felhnev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(139)))));
            this.tb_felhnev.Location = new System.Drawing.Point(140, 40);
            this.tb_felhnev.Multiline = true;
            this.tb_felhnev.Name = "tb_felhnev";
            this.tb_felhnev.Size = new System.Drawing.Size(100, 30);
            this.tb_felhnev.TabIndex = 5;
            this.tb_felhnev.Text = "###";
            this.tb_felhnev.Click += new System.EventHandler(this.tb_felhnev_Click);
            // 
            // tb_jelsz
            // 
            this.tb_jelsz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_jelsz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_jelsz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_jelsz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(139)))));
            this.tb_jelsz.Location = new System.Drawing.Point(140, 104);
            this.tb_jelsz.Multiline = true;
            this.tb_jelsz.Name = "tb_jelsz";
            this.tb_jelsz.Size = new System.Drawing.Size(100, 30);
            this.tb_jelsz.TabIndex = 6;
            this.tb_jelsz.Tag = "";
            this.tb_jelsz.Text = "###";
            this.tb_jelsz.Click += new System.EventHandler(this.tb_jelsz_Click);
            // 
            // btn_sos
            // 
            this.btn_sos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(17)))), ((int)(((byte)(139)))));
            this.btn_sos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.btn_sos.Location = new System.Drawing.Point(105, 166);
            this.btn_sos.Name = "btn_sos";
            this.btn_sos.Size = new System.Drawing.Size(30, 30);
            this.btn_sos.TabIndex = 7;
            this.btn_sos.Text = "?";
            this.btn_sos.UseVisualStyleBackColor = false;
            this.btn_sos.Click += new System.EventHandler(this.btn_sos_Click);
            // 
            // lbl_marvan
            // 
            this.lbl_marvan.AutoSize = true;
            this.lbl_marvan.BackColor = System.Drawing.Color.Gray;
            this.lbl_marvan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_marvan.Location = new System.Drawing.Point(168, 182);
            this.lbl_marvan.Name = "lbl_marvan";
            this.lbl_marvan.Size = new System.Drawing.Size(28, 13);
            this.lbl_marvan.TabIndex = 8;
            this.lbl_marvan.Text = "###";
            this.lbl_marvan.Click += new System.EventHandler(this.lbl_marvan_Click);
            // 
            // frm_fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(354, 321);
            this.Controls.Add(this.lbl_marvan);
            this.Controls.Add(this.btn_sos);
            this.Controls.Add(this.tb_jelsz);
            this.Controls.Add(this.tb_felhnev);
            this.Controls.Add(this.pln_jelsz);
            this.Controls.Add(this.pnl_felh);
            this.Controls.Add(this.cmb_nyelvek);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_bejel);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_fomenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bejel;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.ComboBox cmb_nyelvek;
        private System.Windows.Forms.Panel pnl_felh;
        private System.Windows.Forms.Panel pln_jelsz;
        private System.Windows.Forms.TextBox tb_felhnev;
        private System.Windows.Forms.TextBox tb_jelsz;
        private System.Windows.Forms.Button btn_sos;
        private System.Windows.Forms.Label lbl_marvan;
    }
}

