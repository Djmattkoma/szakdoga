namespace szakdoga
{
    partial class frm_esemeny
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
            this.tb_cim = new System.Windows.Forms.TextBox();
            this.cmb_kateg = new System.Windows.Forms.ComboBox();
            this.dtp_kezd = new System.Windows.Forms.DateTimePicker();
            this.cmb_kezd_o = new System.Windows.Forms.ComboBox();
            this.gb_kezd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_kezd_p = new System.Windows.Forms.ComboBox();
            this.gb_veg = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_veg_p = new System.Windows.Forms.ComboBox();
            this.cmb_veg_o = new System.Windows.Forms.ComboBox();
            this.dtp_veg = new System.Windows.Forms.DateTimePicker();
            this.btn_ment = new System.Windows.Forms.Button();
            this.btn_modosit = new System.Windows.Forms.Button();
            this.btn_toroles = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.dgv_esemenyek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tb_sorsz = new System.Windows.Forms.TextBox();
            this.gb_kezd.SuspendLayout();
            this.gb_veg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_esemenyek)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_cim
            // 
            this.tb_cim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_cim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_cim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.tb_cim.Location = new System.Drawing.Point(560, 30);
            this.tb_cim.Multiline = true;
            this.tb_cim.Name = "tb_cim";
            this.tb_cim.Size = new System.Drawing.Size(100, 25);
            this.tb_cim.TabIndex = 0;
            this.tb_cim.Text = "###";
            // 
            // cmb_kateg
            // 
            this.cmb_kateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_kateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_kateg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.cmb_kateg.FormattingEnabled = true;
            this.cmb_kateg.Items.AddRange(new object[] {
            "Műszak",
            "Tárgyalás",
            "Szünet",
            "Szabadság"});
            this.cmb_kateg.Location = new System.Drawing.Point(690, 30);
            this.cmb_kateg.Name = "cmb_kateg";
            this.cmb_kateg.Size = new System.Drawing.Size(90, 24);
            this.cmb_kateg.TabIndex = 1;
            this.cmb_kateg.Text = "###";
            // 
            // dtp_kezd
            // 
            this.dtp_kezd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_kezd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kezd.Location = new System.Drawing.Point(6, 19);
            this.dtp_kezd.Name = "dtp_kezd";
            this.dtp_kezd.Size = new System.Drawing.Size(200, 23);
            this.dtp_kezd.TabIndex = 0;
            // 
            // cmb_kezd_o
            // 
            this.cmb_kezd_o.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_kezd_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_kezd_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_kezd_o.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.cmb_kezd_o.FormattingEnabled = true;
            this.cmb_kezd_o.Location = new System.Drawing.Point(6, 50);
            this.cmb_kezd_o.Name = "cmb_kezd_o";
            this.cmb_kezd_o.Size = new System.Drawing.Size(45, 24);
            this.cmb_kezd_o.TabIndex = 1;
            // 
            // gb_kezd
            // 
            this.gb_kezd.Controls.Add(this.label1);
            this.gb_kezd.Controls.Add(this.cmb_kezd_p);
            this.gb_kezd.Controls.Add(this.cmb_kezd_o);
            this.gb_kezd.Controls.Add(this.dtp_kezd);
            this.gb_kezd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.gb_kezd.Location = new System.Drawing.Point(545, 60);
            this.gb_kezd.Name = "gb_kezd";
            this.gb_kezd.Size = new System.Drawing.Size(250, 85);
            this.gb_kezd.TabIndex = 2;
            this.gb_kezd.TabStop = false;
            this.gb_kezd.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(238)), true);
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // cmb_kezd_p
            // 
            this.cmb_kezd_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_kezd_p.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_kezd_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_kezd_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.cmb_kezd_p.FormattingEnabled = true;
            this.cmb_kezd_p.Location = new System.Drawing.Point(80, 50);
            this.cmb_kezd_p.Name = "cmb_kezd_p";
            this.cmb_kezd_p.Size = new System.Drawing.Size(45, 24);
            this.cmb_kezd_p.TabIndex = 2;
            // 
            // gb_veg
            // 
            this.gb_veg.Controls.Add(this.label2);
            this.gb_veg.Controls.Add(this.cmb_veg_p);
            this.gb_veg.Controls.Add(this.cmb_veg_o);
            this.gb_veg.Controls.Add(this.dtp_veg);
            this.gb_veg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.gb_veg.Location = new System.Drawing.Point(545, 171);
            this.gb_veg.Name = "gb_veg";
            this.gb_veg.Size = new System.Drawing.Size(250, 85);
            this.gb_veg.TabIndex = 3;
            this.gb_veg.TabStop = false;
            this.gb_veg.Text = "###";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(238)), true);
            this.label2.Location = new System.Drawing.Point(55, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // cmb_veg_p
            // 
            this.cmb_veg_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_veg_p.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_veg_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_veg_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.cmb_veg_p.FormattingEnabled = true;
            this.cmb_veg_p.Location = new System.Drawing.Point(80, 50);
            this.cmb_veg_p.Name = "cmb_veg_p";
            this.cmb_veg_p.Size = new System.Drawing.Size(45, 24);
            this.cmb_veg_p.TabIndex = 2;
            // 
            // cmb_veg_o
            // 
            this.cmb_veg_o.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_veg_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_veg_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_veg_o.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.cmb_veg_o.FormattingEnabled = true;
            this.cmb_veg_o.Location = new System.Drawing.Point(6, 50);
            this.cmb_veg_o.Name = "cmb_veg_o";
            this.cmb_veg_o.Size = new System.Drawing.Size(45, 24);
            this.cmb_veg_o.TabIndex = 1;
            // 
            // dtp_veg
            // 
            this.dtp_veg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_veg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_veg.Location = new System.Drawing.Point(6, 19);
            this.dtp_veg.Name = "dtp_veg";
            this.dtp_veg.Size = new System.Drawing.Size(200, 23);
            this.dtp_veg.TabIndex = 0;
            // 
            // btn_ment
            // 
            this.btn_ment.BackgroundImage = global::szakdoga.Properties.Resources.save;
            this.btn_ment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ment.Location = new System.Drawing.Point(550, 265);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(50, 50);
            this.btn_ment.TabIndex = 4;
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.btn_ment_Click);
            // 
            // btn_modosit
            // 
            this.btn_modosit.BackgroundImage = global::szakdoga.Properties.Resources.edi;
            this.btn_modosit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modosit.Location = new System.Drawing.Point(620, 265);
            this.btn_modosit.Name = "btn_modosit";
            this.btn_modosit.Size = new System.Drawing.Size(50, 50);
            this.btn_modosit.TabIndex = 5;
            this.btn_modosit.UseVisualStyleBackColor = true;
            this.btn_modosit.Click += new System.EventHandler(this.btn_modosit_Click);
            // 
            // btn_toroles
            // 
            this.btn_toroles.BackgroundImage = global::szakdoga.Properties.Resources.delet;
            this.btn_toroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toroles.Location = new System.Drawing.Point(690, 262);
            this.btn_toroles.Name = "btn_toroles";
            this.btn_toroles.Size = new System.Drawing.Size(50, 50);
            this.btn_toroles.TabIndex = 6;
            this.btn_toroles.UseVisualStyleBackColor = true;
            this.btn_toroles.Click += new System.EventHandler(this.btn_toroles_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(139)))));
            this.btn_kilep.Location = new System.Drawing.Point(550, 335);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(190, 75);
            this.btn_kilep.TabIndex = 7;
            this.btn_kilep.Text = "###";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // dgv_esemenyek
            // 
            this.dgv_esemenyek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(139)))));
            this.dgv_esemenyek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_esemenyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_esemenyek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_esemenyek.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_esemenyek.Location = new System.Drawing.Point(9, 60);
            this.dgv_esemenyek.Name = "dgv_esemenyek";
            this.dgv_esemenyek.RowHeadersVisible = false;
            this.dgv_esemenyek.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_esemenyek.Size = new System.Drawing.Size(530, 225);
            this.dgv_esemenyek.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "sor szám";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "esemény";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "kategoria";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "kezd";
            this.Column4.Name = "Column4";
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ora";
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "perc";
            this.Column6.Name = "Column6";
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "veg";
            this.Column7.Name = "Column7";
            this.Column7.Width = 65;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ora";
            this.Column8.Name = "Column8";
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "perc";
            this.Column9.Name = "Column9";
            this.Column9.Width = 40;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.Color.Gray;
            this.lbl_id.Location = new System.Drawing.Point(42, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 13);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "00";
            // 
            // tb_sorsz
            // 
            this.tb_sorsz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_sorsz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_sorsz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            this.tb_sorsz.Location = new System.Drawing.Point(746, 265);
            this.tb_sorsz.Multiline = true;
            this.tb_sorsz.Name = "tb_sorsz";
            this.tb_sorsz.Size = new System.Drawing.Size(33, 34);
            this.tb_sorsz.TabIndex = 10;
            // 
            // frm_esemeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.tb_sorsz);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dgv_esemenyek);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_toroles);
            this.Controls.Add(this.btn_modosit);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.gb_veg);
            this.Controls.Add(this.gb_kezd);
            this.Controls.Add(this.cmb_kateg);
            this.Controls.Add(this.tb_cim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_esemeny";
            this.gb_kezd.ResumeLayout(false);
            this.gb_kezd.PerformLayout();
            this.gb_veg.ResumeLayout(false);
            this.gb_veg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_esemenyek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cim;
        private System.Windows.Forms.ComboBox cmb_kateg;
        private System.Windows.Forms.DateTimePicker dtp_kezd;
        private System.Windows.Forms.ComboBox cmb_kezd_o;
        private System.Windows.Forms.GroupBox gb_kezd;
        private System.Windows.Forms.ComboBox cmb_kezd_p;
        private System.Windows.Forms.GroupBox gb_veg;
        private System.Windows.Forms.ComboBox cmb_veg_p;
        private System.Windows.Forms.ComboBox cmb_veg_o;
        private System.Windows.Forms.DateTimePicker dtp_veg;
        private System.Windows.Forms.Button btn_ment;
        private System.Windows.Forms.Button btn_modosit;
        private System.Windows.Forms.Button btn_toroles;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.DataGridView dgv_esemenyek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tb_sorsz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}