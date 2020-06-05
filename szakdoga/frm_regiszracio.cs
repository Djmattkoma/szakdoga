using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Resources;
using System.Globalization;

namespace szakdoga
{
    public partial class frm_regiszracio : Form
    {
        SqlConnection conn; ResourceManager remeg; CultureInfo culinf;
        public frm_regiszracio(ResourceManager remeg, CultureInfo culinf)
        {
            InitializeComponent();
            conn = new SqlConnection("Server = tcp:lm-database.database.windows.net, 1433; Initial Catalog = szakdogadb; Persist Security Info = False; User ID = Matt; Password = Dec19991223Dec; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            //szöveg
            tb_felhnev.Text = remeg.GetString("felhnev", culinf);
            tb_jelszo.Text = remeg.GetString("jelszo", culinf);
            tb_knev.Text = remeg.GetString("knev", culinf);
            tb_vnev.Text = remeg.GetString("vnev", culinf);
            btn_ok.Text = remeg.GetString("reg", culinf);

            this.remeg=remeg; this.culinf=culinf;
        }

        //regisztráció
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tb_felhnev.Text != "Felhasznalónev" && tb_felhnev.Text != "Username")
            {
                conn.Open();
                var regisztracio = new SqlDataAdapter();
                regisztracio.InsertCommand = new SqlCommand(
                    "INSERT INTO felhasznalo(felhasznalonev, jelszo, vezetekn, keresztn) VALUES ('" + tb_felhnev.Text + "','" + tb_jelszo.Text + "','" + tb_vnev.Text + "','" + tb_knev.Text + "');", conn);
                regisztracio.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Sikeres regisztráció");

                var ugrases = new frm_esemeny(remeg, culinf, tb_felhnev.Text);
                ugrases.ShowDialog();
                Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("sikertelen regisztráció");
            }
        }

        //színváltozások
        private void tb_felhnev_Click(object sender, EventArgs e)
        {
            tb_felhnev.Clear();
            pnl_felh.BackgroundImage = Properties.Resources.user1;
            tb_felhnev.ForeColor = Color.FromArgb(17, 148, 173);
        }

        private void tb_jelszo_Click(object sender, EventArgs e)
        {
            tb_jelszo.Clear();
            pln_jelsz.BackgroundImage = Properties.Resources.pass1;
            tb_jelszo.ForeColor = Color.FromArgb(17, 148, 173);
        }

        private void tb_vnev_Click(object sender, EventArgs e)
        {
            tb_vnev.Clear();
            pln_vnev.BackgroundImage = Properties.Resources.name1;
            tb_vnev.ForeColor = Color.FromArgb(17, 148, 173);
        }

        private void tb_knev_Click(object sender, EventArgs e)
        {
            tb_knev.Clear();
            pln_knev.BackgroundImage = Properties.Resources.name1;
            tb_knev.ForeColor = Color.FromArgb(17, 148, 173);
        }
    }
}
