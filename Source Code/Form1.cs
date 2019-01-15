using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad_2
{
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        int sirka_skladu, vyska_skladu, sirka_police, vyska_police, pocet_polic, hloubka_polic = 30, sirka_krabice, vyska_krabice, hloubka_krabice = 30, pocet_krabic_horizontal, pocet_krabic_vertical;

        double objem_polic, pocet_krabic, celkova_plocha_skladu, pocet_krabic_v_jednotlive_polici;

        string objem_polic_string, pocet_krabic_string, celkova_plocha_skladu_string, pocet_krabic_v_jednotlive_polici_string, pocet_krabic_horizontal_string, pocet_krabic_vertical_string;



        private void vypocet_poctu_krabic_Click(object sender, EventArgs e)
        {
            //vypocet vysledku

            pocet_krabic_horizontal = sirka_police / sirka_krabice;
            pocet_krabic_vertical = vyska_police / vyska_krabice;

            pocet_krabic_v_jednotlive_polici = pocet_krabic_horizontal * pocet_krabic_vertical;
            pocet_krabic = pocet_krabic_v_jednotlive_polici * pocet_polic;
         // objem_polic = hloubka_polic * pocet_polic * vyska_police * sirka_police;
            celkova_plocha_skladu = sirka_skladu * vyska_skladu;

            

            //parse int vysledku  do string
         // objem_polic_string = objem_polic.ToString();
            pocet_krabic_string = pocet_krabic.ToString();
            celkova_plocha_skladu_string = celkova_plocha_skladu.ToString();
            pocet_krabic_v_jednotlive_polici_string = pocet_krabic_v_jednotlive_polici.ToString();
            pocet_krabic_horizontal_string = pocet_krabic_horizontal.ToString();
            pocet_krabic_vertical_string = pocet_krabic_vertical.ToString();

            //zapsani vysledku do labelu
         // objem_polic_label.Text = objem_polic_string;
            pocet_krabic_celkem_label.Text = pocet_krabic_string;
            celkova_plocha_skladu_label.Text = celkova_plocha_skladu_string;
            pocet_krabic_v_jednotlive_polici_label.Text = pocet_krabic_v_jednotlive_polici_string;
            pocet_krabic_horizontalne_label.Text = pocet_krabic_horizontal_string;
            pocet_krabic_vertikalne_label.Text = pocet_krabic_vertical_string;
        }

        

        //ZADAVANI DAT OD UZIVATELE


            //vyska krabice
        private void vyska_krabice_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            vyska_krabice = Convert.ToInt32(vyska_krabice_numeric_updown.Value);
        }
            
            //sirka krabice
        private void sirka_krabice_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            sirka_krabice = Convert.ToInt32(sirka_krabice_numeric_updown.Value);
        }
                
            //pocet polic
        private void pocet_polic_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            pocet_polic = Convert.ToInt32(pocet_polic_numeric_updown.Value);
        }

            //vyska police
        private void vyska_police_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            vyska_police = Convert.ToInt32(vyska_police_numeric_updown.Value);
        }

            //sirka police
        private void sirka_police_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            sirka_police = Convert.ToInt32(sirka_police_numeric_updown.Value);
        }

            //sirka skladu
        private void sirka_skladu_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            sirka_skladu = Convert.ToInt32(sirka_skladu_numeric_updown.Value);
        }

            //vyska_skladu
        private void vyska_skladu_numeric_updown_ValueChanged(object sender, EventArgs e)
        {
            vyska_skladu = Convert.ToInt32(vyska_skladu_numeric_updown.Value);
        }

        


    }
}
