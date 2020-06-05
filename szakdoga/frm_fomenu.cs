using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

namespace szakdoga
{
    public partial class frm_fomenu : Form
    {
        SqlConnection azurconn; ResourceManager remeg; CultureInfo culinf;
        public frm_fomenu()
        {
            InitializeComponent();
            btn_bejel.Enabled = false;
            cmb_nyelvek.SelectedItem = "hun";
            azurconn = new SqlConnection("Server = tcp:lm-database.database.windows.net, 1433; Initial Catalog = szakdogadb; Persist Security Info = False; User ID = Matt; Password = Dec19991223Dec; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

        }

        //bejelentkezes
        private void btn_bejel_Click(object sender, EventArgs e)
        {
            azurconn.Open();
            var bejelentez = new SqlDataAdapter();
            bejelentez.SelectCommand = new SqlCommand(
                "Select  felhasznalonev, jelszo From felhasznalo Where +" +
                "felhasznalonev ='" + tb_felhnev.Text+ "' AND jelszo ='" + tb_jelsz.Text + "';", azurconn);
            DataTable bej = new DataTable();
            bejelentez.Fill(bej);
            bejelentez.SelectCommand.ExecuteNonQuery();
            
            if (bej.Rows.Count == 1)
            {
                string id = tb_felhnev.Text;
                var ugrase = new frm_esemeny(remeg, culinf, tb_felhnev.Text);
                ugrase.ShowDialog();
                Close();
            }
            else 
            {
                this.Hide();
                MessageBox.Show("Sikertelen bejelentkezés");
            }
            azurconn.Close();
        }

        //ugrás >> regisztráció
        private void btn_reg_Click(object sender, EventArgs e)
        {
            var ugrasr = new frm_regiszracio(remeg, culinf);
            ugrasr.ShowDialog();
            Close();
        }

        //súgó megnyitás
        private void btn_sos_Click(object sender, EventArgs e)
        {
            Process sug = new Process();
            sug.StartInfo.FileName = @"sugo\sugo.html";
            sug.Start();
        }

        //nyelv választás
        private void cmb_nyelvek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nyelvek = cmb_nyelvek.SelectedItem.ToString();

            culinf = new CultureInfo("en-US");
            Assembly asm = Assembly.Load("szakdoga");
            remeg = new ResourceManager($"szakdoga.languages.{nyelvek}", asm);

            tb_felhnev.Text = remeg.GetString("felhnev", culinf);
            tb_jelsz.Text = remeg.GetString("jelszo", culinf);
            lbl_marvan.Text = remeg.GetString("marvan", culinf);
            btn_bejel.Text = remeg.GetString("bejel", culinf);
            btn_reg.Text = remeg.GetString("reg", culinf);
        }

        //bejelentkezés enged
        private void lbl_marvan_Click(object sender, EventArgs e)
        {
            btn_bejel.Enabled = true;
        }

        //szín változások
        private void tb_felhnev_Click(object sender, EventArgs e)
        {
            tb_felhnev.Clear();
            pnl_felh.BackgroundImage = Properties.Resources.user1;
            tb_felhnev.ForeColor = Color.FromArgb(17, 148, 173);
        }

        private void tb_jelsz_Click(object sender, EventArgs e)
        {
            tb_jelsz.Clear();
            pln_jelsz.BackgroundImage = Properties.Resources.pass1;
            tb_jelsz.ForeColor = Color.FromArgb(17, 148, 173);
        }
    }
}
