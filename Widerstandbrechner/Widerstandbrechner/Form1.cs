using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Widerstandbrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MAZUNNA RAGAZZI
        }

        private void btn_Berechnen_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Schwarz":
                    Ergebnis.Text = "0";
                    break;
                case "Braun":
                    Ergebnis.Text = "1";
                    break;
                case "Rot":
                    Ergebnis.Text = "2";
                    break;
                case "Orange":
                    Ergebnis.Text = "3";
                    break;
                case "Gelb":
                    Ergebnis.Text = "4";
                    break;
                case "Grün":
                    Ergebnis.Text = "5";
                    break;
                case "Blau":
                    Ergebnis.Text = "6";
                    break;
                case "Violett":
                    Ergebnis.Text = "7";
                    break;
                case "Grau":
                    Ergebnis.Text = "8";
                    break;
                case "Weiß":
                    Ergebnis.Text = "9";
                    break;
            }
            switch (comboBox2.Text)
            {
                case "Schwarz":
                    Ergebnis.Text += "0";
                    break;
                case "Braun":
                    Ergebnis.Text += "1";
                    break;
                case "Rot":
                    Ergebnis.Text += "2";
                    break;
                case "Orange":
                    Ergebnis.Text += "3";
                    break;
                case "Gelb":
                    Ergebnis.Text += "4";
                    break;
                case "Grün":
                    Ergebnis.Text += "5";
                    break;
                case "Blau":
                    Ergebnis.Text += "6";
                    break;
                case "Violett":
                    Ergebnis.Text += "7";
                    break;
                case "Grau":
                    Ergebnis.Text += "8";
                    break;
                case "Weiß":
                    Ergebnis.Text += "9";
                    break;
            }

            switch (comboBox3.Text)
            {
                case "Schwarz":
                    Ergebnis.Text += "";
                    break;
                case "Braun":
                    Ergebnis.Text += "0";
                    break;
                case "Rot":
                    Ergebnis.Text += "00";
                    break;
                case "Orange":
                    Ergebnis.Text += "k";
                    break;
                case "Gelb":
                    Ergebnis.Text += "0k";
                    break;
                case "Grün":
                    Ergebnis.Text += "00k";
                    break;
                case "Blau":
                    Ergebnis.Text += "M";
                    break;
                case "Violett":
                    Ergebnis.Text += "0M";
                    break;
                //case "Grau":
                //    Ergebnis.Text += "00M";
                //    break;
                //case "Weiß":
                //    Ergebnis.Text += "G";
                //    break;
            }

            switch (Toleranz.Text)
            {
                case "Silber":
                    Ergebnis2.Text += " 10%";
                    break;
                case "Gold":
                    Ergebnis2.Text += " 5%";
                    break;
                case "Braun":
                    Ergebnis2.Text += " 1%";
                    break;
                case "Rot":
                    Ergebnis2.Text += " 2%";
                    break;
                case "Grün":
                    Ergebnis2.Text += " 0.5%";
                    break;
                case "Blau":
                    Ergebnis2.Text += " 0.25%";
                    break;
                case "Violett":
                    Ergebnis2.Text += " 0.1%";
                    break;

                    //Git probe
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Ergebnis.Clear();
            Ergebnis2.Clear();
            Toleranz.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

    }
}
    
