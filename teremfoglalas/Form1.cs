using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace teremfoglalas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<EloadoTerem> eloadoTermek = new List<EloadoTerem>();
        List<GepTerem> gepTermek = new List<GepTerem>();
        List<SzeminariumTerem> szeminariumTermek = new List<SzeminariumTerem>();
        private int osszkap = 0;
        private double valoskap = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader("termek.txt");
            while (!sr.EndOfStream)
            {
                var sorDb = sr.ReadLine().Split(';');
                switch (sorDb[0])
                {
                    case "0":
                        var el = new EloadoTerem(sorDb[1], int.Parse(sorDb[2]), bool.Parse(sorDb[3]));
                        eloadoTermek.Add(el);
                        osszkap = osszkap + int.Parse(sorDb[2]);
                        valoskap = valoskap + el.ValosKapacitas();
                        break;
                    case "1":
                        var gep = new GepTerem(sorDb[1], int.Parse(sorDb[2]), int.Parse(sorDb[3]));
                        gepTermek.Add(gep);
                        osszkap = osszkap + int.Parse(sorDb[2]);
                        valoskap = valoskap + gep.ValosKapacitas();
                        break;
                    case "2":
                        var sze = new SzeminariumTerem(sorDb[1], int.Parse(sorDb[2]), bool.Parse(sorDb[3]));
                        szeminariumTermek.Add(sze);
                        osszkap = osszkap + int.Parse(sorDb[2]);
                        valoskap = valoskap + sze.ValosKapacitas();
                        break;
                }
            }
            sr.Close();

            lbTeremOsszKapacitas.Text = osszkap.ToString();
            lbTeremValosOsszKapacitas.Text = valoskap.ToString();

        }

        private void teremtipus_valtozas(object sender, EventArgs e)
        {
            if (rbEloado.Checked)
            {
                chProjektor.Enabled = true;
                lbSzgepSzam.Enabled = false;
                numSzgepSzam.Enabled = false;
                groupBox2.Enabled = false;
                rbKretas.Checked = true;
                rbFilces.Checked = false;
            }
            else if (rbGep.Checked)
            {
                chProjektor.Enabled = false;
                chProjektor.Checked = true;
                lbSzgepSzam.Enabled = true;
                numSzgepSzam.Enabled = true;
                groupBox2.Enabled = false;
                rbKretas.Checked = false;
                rbFilces.Checked = true;
            }
            else
            {
                chProjektor.Enabled = false;
                chProjektor.Checked = false;
                lbSzgepSzam.Enabled = false;
                numSzgepSzam.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void btKeres_Click(object sender, EventArgs e)
        {
            lbTalalat.Items.Clear();

            if (rbEloado.Checked)
            {
                if (chProjektor.Checked)
                {
                    foreach (var el in eloadoTermek.Where(el => el.Projektor && el.TeremKapacitas == numKapacitas.Value))
                    {
                        lbTalalat.Items.Add(el.ToString());
                    }
                }
                else
                {
                    foreach (var el in eloadoTermek.Where(el => !el.Projektor && el.TeremKapacitas == numKapacitas.Value))
                    {
                        lbTalalat.Items.Add(el.ToString());
                    }
                }             
            }

            if (rbGep.Checked)
            {
                foreach (var gep in gepTermek.Where(gep => gep.GepSzam == numSzgepSzam.Value))
                {
                    lbTalalat.Items.Add(gep.ToString());
                }
            }

            if (rbSzeminarium.Checked)
            {
                if (rbKretas.Checked)
                {
                    foreach (var sze in szeminariumTermek.Where(sze => sze.KretasTabla && sze.TeremKapacitas == numKapacitas.Value))
                    {
                        lbTalalat.Items.Add(sze.ToString());
                    }
                }

                if (rbFilces.Checked)
                {
                    foreach (var sze in szeminariumTermek.Where(sze => !sze.KretasTabla && sze.TeremKapacitas == numKapacitas.Value))
                    {
                        lbTalalat.Items.Add(sze.ToString());
                    }
                }
            }

            if (lbTalalat.Items.Count == 0)
            {
                lbTalalat.Items.Add("Nincs talalat!");
            }
        }
    }
}
