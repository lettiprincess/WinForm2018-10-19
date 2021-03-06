﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2018_10_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mentesButton.Click += (sender, e) =>
            {
                Mentes();
            };

            betoltButton.Click += (sender, e) =>
            {
                Betolt();
            };
        }
        
        private void noRB_CheckedChanged(object sender, EventArgs e)
        {
            if (noRB.Checked == true)
            {
                ferfiRB.Checked = false;
            }
            if(ferfiRB.Checked == true)
            {
                noRB.Checked = false;
            }
        }

        private void Mentes() {
            List<string> adatok = new List<string>();
            string tartalom = "";
            if (noRB.Checked == true)
            {
                tartalom += nevTB.Text + "\n" + DTP.Text + "\nNő\n" + kedvencekLB.Text;
            }
            if (ferfiRB.Checked == true)
            {
                tartalom += nevTB.Text + "\n" + DTP.Text + "\nFérfi\n " + kedvencekLB.Text;
            }
            adatok.Add(tartalom);
            var eredmeny = saveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string fajlnev = saveFileDialog.FileName;
                using (var file = File.CreateText(fajlnev))
                {
                    file.Write(tartalom);
                }
            }
        }

        private void Betolt() {
            
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                String [] vissza_adatok = File.ReadAllLines(openFileDialog.FileName);
                nevTB.Text = vissza_adatok[0];
                DTP.Text = vissza_adatok[1];
                if (vissza_adatok[2] == "Nő")
                {
                    noRB.Checked = true;
                }
                if (vissza_adatok[2] == "Férfi")
                {
                    ferfiRB.Checked = true;
                }
                kedvencekLB.SelectedItem = vissza_adatok[3];
            }
        }

        private void hozzaadButton_Click(object sender, EventArgs e)
        {
            if (ujakTB != null)
            {
                kedvencekLB.Items.Add(ujakTB.Text);
            }
        }
    }
}
