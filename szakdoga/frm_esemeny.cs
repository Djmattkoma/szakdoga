using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szakdoga
{
    public partial class frm_esemeny : Form
    {
        SqlConnection azurconn; ResourceManager remeg; CultureInfo culinf; 
        
        public frm_esemeny(ResourceManager remeg, CultureInfo culinf, string azon)
        {
            InitializeComponent();
            azurconn = new SqlConnection("Server = tcp:lm-database.database.windows.net, 1433; Initial Catalog = szakdogadb; Persist Security Info = False; User ID = Matt; Password = Dec19991223Dec; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            orafell();
            tablafel();

            lbl_id.Text = azon;

            //óra kezdő értékei
            cmb_kezd_o.SelectedItem = "08";
            cmb_kezd_p.SelectedItem = "00";
            cmb_veg_o.SelectedItem = "09";
            cmb_veg_p.SelectedItem = "05";

            //szöveg
            tb_cim.Text = remeg.GetString("cim", culinf);
            cmb_kateg.Text = remeg.GetString("kat", culinf);
            gb_kezd.Text = remeg.GetString("kezd", culinf);
            gb_veg.Text = remeg.GetString("befe", culinf);
            dgv_esemenyek.Columns[0].Name = remeg.GetString("sorsz", culinf);
            dgv_esemenyek.Columns[1].Name = remeg.GetString("esemeny", culinf);
            btn_kilep.Text = remeg.GetString("kilep", culinf);
            this.remeg = remeg; this.culinf = culinf;
            this.Azon = azon;
        }
        public string Azon { get; set; }

        //adat tábla
        private void tablafel()
        {
            dgv_esemenyek.Rows.Clear();
            azurconn.Open();
            var cmd = new SqlCommand(
                "Select esemenyid, cim, kategoria, kezdet, kora, kperc, veg, vora, vperc FROM esemeny WHERE felhasznaloid='"+lbl_id.Text+"';", azurconn);;
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgv_esemenyek.Rows.Add(r[0], r[1], r[2], r.GetDateTime(3).ToString("yyyy.MM.dd"), r[4], r[5], r.GetDateTime(6).ToString("yyyy.MM.dd"),r[7],r[8]);
            }
            azurconn.Close();
        }

        //órák
        private void orafell()
        {
            for (int o = 0; o < 24; o++)
            {
                if (o % 1 == 0)
                {
                    if (o < 10)
                    {
                        cmb_kezd_o.Items.Add("0" + o); cmb_veg_o.Items.Add("0" + o);
                    }

                    if (o >= 10)
                    {
                        cmb_kezd_o.Items.Add(o); cmb_veg_o.Items.Add(o);
                    }
                }
            }

            for (int p = 0; p < 60; p++)
            {
                if (p % 5 == 0)
                {
                    if (p <= 5)
                    {
                        cmb_kezd_p.Items.Add("0" + p); cmb_veg_p.Items.Add("0" + p);
                    }

                    if (p > 5)
                    {
                        cmb_kezd_p.Items.Add(p); cmb_veg_p.Items.Add(p);
                    }
                }
            }
        }

        //mentés
        private void btn_ment_Click(object sender, EventArgs e)
        {
            azurconn.Open();
            var ment = new SqlDataAdapter();
            ment.InsertCommand = new SqlCommand(
                "INSERT INTO esemeny (cim, felhasznaloid, kategoria, kezdet, kora, kperc, veg, vora, vperc) VALUES ('" + tb_cim.Text + "','" + lbl_id.Text + "','" + cmb_kateg.SelectedItem + "','" + dtp_kezd.Value.ToString("yyyy-MM-dd") + "','" + cmb_kezd_o.SelectedItem + "','" + cmb_kezd_p.SelectedItem + "','" + dtp_veg.Value.ToString("yyyy-MM-dd") + "','" + cmb_veg_o.SelectedItem + "','" + cmb_veg_p.SelectedItem + "');", azurconn);
            ment.InsertCommand.ExecuteNonQuery();
            azurconn.Close();

            tablafel();
        }

        //módosítás
        private void btn_modosit_Click(object sender, EventArgs e)
        {
            azurconn.Open();
            var modsit = new SqlDataAdapter();
            modsit.UpdateCommand = new SqlCommand(
                "UPDATE esemeny SET cim = '" + tb_cim.Text+"', kategoria='"+cmb_kateg.SelectedItem+"',kezdet='"+dtp_kezd.Value.ToString("yyyy-MM-dd")+"', kora='"+cmb_kezd_o.SelectedItem+"', kperc='"+cmb_kezd_p.SelectedItem+"',veg='"+dtp_veg.Value.ToString("yyyy-MM-dd")+"', vora ='"+cmb_veg_o.SelectedItem+"', vperc='"+cmb_veg_p.SelectedItem+"' WHERE esemenyid='"+tb_sorsz.Text+"';", azurconn);
            modsit.UpdateCommand.ExecuteNonQuery();
            azurconn.Close();

            tablafel();
        }

        //törlés
        private void btn_toroles_Click(object sender, EventArgs e)
        {
            azurconn.Open();
            var torles = new SqlDataAdapter();
            torles.DeleteCommand = new SqlCommand(
                "DELETE FROM esemeny  WHERE esemenyid='" + tb_sorsz.Text + "'", azurconn);
            torles.DeleteCommand.ExecuteNonQuery();
            azurconn.Close();

            tablafel();
        }

        //kilépés
        private void btn_kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
