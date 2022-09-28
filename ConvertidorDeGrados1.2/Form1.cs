using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorDeGrados1._2
{
    public partial class Form1 : Form
    {
        Conversiones conversion = new Conversiones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblKelvin.Text = txtGrados.Text + "ºK";
            lblCelsius.Text = conversion.ConvertirKaC(txtGrados.Text).ToString() + "ºC";

            lblFahrenheit.Text = conversion.ConvertirKaF(txtGrados.Text).ToString() + "ºF";
        }

        private void btncelcius_Click(object sender, EventArgs e)
        {

            lblCelsius.Text = txtGrados.Text + "ºC;";

            lblKelvin.Text = conversion.ConvertirCaK(txtGrados.Text).ToString() +"ºK";

            lblFahrenheit.Text = conversion.ConvertirCaF(txtGrados.Text).ToString() + "ºF";
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            lblFahrenheit.Text = txtGrados.Text + "ºF";
            lblCelsius.Text = conversion.ConvertirFaC(txtGrados.Text).ToString() + "ºC";
           lblKelvin.Text=conversion.ConvertirFaK(txtGrados.Text).ToString ()+ "ºK";

        }
    }
}
