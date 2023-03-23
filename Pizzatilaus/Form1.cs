using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Pizzatilaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tilaaBT_Click(object sender, EventArgs e)
        // Pizzan koko ja pohja valinta
        {
            if (pieniRB.Checked == true)
            {
                if (vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Pieni pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("5,0");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Pieni pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("5,0");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Pieni pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("5,0");
                    listView1.Items.Add(tuote);
                }
            }
            else if (normaaliRB.Checked == true)
            {
                if (vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Normaali pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("8,00");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Normaali pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("8,00");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Normaali pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("8,00");
                    listView1.Items.Add(tuote);
                }
            }
            else if (suuriRB.Checked == true)
            {
                if(vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Suuri pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("14,00");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Suuri pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("14,00");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Suuri pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("14,00");
                    listView1.Items.Add(tuote);
                }
            }
            else if (perheRB.Checked == true)
            {
                if(vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Perhe pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("20,00");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Perhe pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("20,00");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Perhe pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("20,00");
                    listView1.Items.Add(tuote);
                }
            }
            // Täytteiden valinta
            if(aurajuustoCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Aurajuusto");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(bbqCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("BBQ-soosi");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(fetaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Fetajuusto");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(herkkusieniCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Herkkusieni");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(jalapenoCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Jalapeno");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(jauhelihaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Jauheliha");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(kanaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Kana");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(kaprisCB.Checked == true) 
            {
                ListViewItem tayte = new ListViewItem("Kapris");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(KatkarapuCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Katkarapu");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(kebabCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Kebab");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(kinkkuCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Kinkku");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(maustekurkkuCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Maustekurkku");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(mozzarellaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Mozzarella");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(oliiviCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Oliivi");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(paprikaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Paprika");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(pekoniCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Pekoni");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(pepperoniCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Pepperoni");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(punasipuliCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Punasipuli");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(salamiCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Salami");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(smetanaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Smetana");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(tomaattiCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Tomaati");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(tonnikalaCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Tonnikala");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(tuplajuustoCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Tuplajuusto");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            if(valkosipuliCB.Checked == true)
            {
                ListViewItem tayte = new ListViewItem("Valkosipuli");
                tayte.SubItems.Add("");
                tayte.SubItems.Add("1,0");
                listView1.Items.Add(tayte);
            }
            //Juomien valinta
            if(cocacolaCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Coca-Cola");
                juoma.SubItems.Add(cocacolaTB.Text);
                int kpl = Convert.ToInt32(cocacolaTB.Text);
                double hinta = kpl * 2.0;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                cocacolaTB.Text = "";
            }
            if (cocacolazeroCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Coca-Cola Zero");
                juoma.SubItems.Add(cocacolazeroTB.Text);
                int kpl = Convert.ToInt32(cocacolazeroTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                cocacolazeroTB.Text = "";
            }
            if (drpepperCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Dr.Pepper");
                juoma.SubItems.Add(drpepperTB.Text);
                int kpl = Convert.ToInt32(drpepperTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                drpepperTB.Text = "";
            }
            if (drpepperzeroCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Dr.Pepper Zero");
                juoma.SubItems.Add(drpepperzeroTB.Text);
                int kpl = Convert.ToInt32(drpepperzeroTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                drpepperzeroTB.Text = "";
            }
            if (fantaCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Fanta");
                juoma.SubItems.Add(fantaTB.Text);
                int kpl = Convert.ToInt32(fantaTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                fantaTB.Text = "";
            }
            if (fantazeroCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Fanta Zero");
                juoma.SubItems.Add(fantazeroTB.Text);
                int kpl = Convert.ToInt32(fantazeroTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                fantazeroTB.Text = "";
            }
            if (spriteCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Sprite");
                juoma.SubItems.Add(spriteTB.Text);
                int kpl = Convert.ToInt32(spriteTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                spriteTB.Text = "";
            }
            if (spritezeroCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Sprite Zero");
                juoma.SubItems.Add(spritezeroTB.Text);
                int kpl = Convert.ToInt32(spritezeroTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                spritezeroTB.Text = "";
            }
            if (vichyCB.Checked == true)
            {
                ListViewItem juoma = new ListViewItem("Vichy");
                juoma.SubItems.Add(vichyTB.Text);
                int kpl = Convert.ToInt32(vichyTB.Text);
                double hinta = kpl * 2.00;
                string kokohinta = hinta.ToString();
                juoma.SubItems.Add(kokohinta);
                listView1.Items.Add(juoma);

            }
            else
            {
                vichyTB.Text = "";
            }

            //Lisukkeiden valinta
            if(hotwingsCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("Hot Wings");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
            if (sipulirenkaatCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("Sipulirenkaat");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
            if (ranskalaisetCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("Ranskalaiset");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
            if(chiliranskalaisetCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("Chili Ranskalaiset");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
            if (yrttivoipatonkiCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("Yrttivoi Patonki");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
            if (valkosipulidippiCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("Valkosipuli Dippi");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
            if (bbqdippiCB.Checked == true)
            {
                ListViewItem lisuke = new ListViewItem("BBQ Dippi");
                lisuke.SubItems.Add("");
                lisuke.SubItems.Add("2,50");
                listView1.Items.Add(lisuke);
            }
        }


    }
}
