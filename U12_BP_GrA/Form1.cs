using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U12_BP_GrA
{
    public partial class Form1 : Form
    {
        ManipulimiMeTekst obj = new ManipulimiMeTekst();
        string tekst = "";
        public Form1()
        {
            InitializeComponent();
        }

        #region Evenetet
        private void btnNrShkronja_Click(object sender, EventArgs e)
        {
            tekst = txtTeksti.Text;

            //Metoda 1
            MessageBox.Show("Shkronja: " + 
                obj.SaEshteNrShkronjave(tekst));

            //Metoda 2
            //int nrShkronjave = obj.SaEshteNrShkronjave(tekst);
            //MessageBox.Show("Shkronja: " + nrShkronjave);
        }

        private void btnNrNumrave_Click(object sender, EventArgs e)
        {
            tekst = txtTeksti.Text;
            MessageBox.Show("Numra: " + obj.SaEshteNrNumrave(tekst));
        }

        private void btnShkronjatEMedha_Click(object sender, EventArgs e)
        {
            tekst = txtTeksti.Text;
            MessageBox.Show("Shkronja te medha: " +
                    obj.SaEshteNrShkronjaUpper(tekst));
        }

        private void btnShkronjatVogla_Click(object sender, EventArgs e)
        {
            tekst = txtTeksti.Text;
            int numriShkronjave;
            obj.SaEshteNrShkronjaLower(tekst, out numriShkronjave);
            MessageBox.Show("Shkronja te vogla: " + numriShkronjave);
        }

        private void btnCapitalize_Click(object sender, EventArgs e)
        {
            tekst = txtTeksti.Text;
            txtTeksti.Text = obj.CapitalizeFirstWord(tekst);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            tekst = txtTeksti.Text;
            string word = txtFjala.Text;
            if (obj.DoesWordExsist(tekst,word))
            {
                MessageBox.Show("Fjala ekziston!");
            }
            else
            {
                MessageBox.Show("Fjala nuk ekziston!");
            }
        }
        #endregion

        #region Metodat

        #endregion
    }
}
