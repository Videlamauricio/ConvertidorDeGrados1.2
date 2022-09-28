using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Conversiones
    {
        double celsius { get; set; }
        double kelvin { get; set; }
        double fahrenheit { get; set; }
       
        public double ConvertirCaK(string valor) 
        {
            double res;

            res = Convert.ToDouble(valor) + 274;

            return res;
        }
        public double ConvertirCaF(string valor)
        {
            double res;

            res = Convert.ToDouble(valor) * 1.8 + 32;

            return res;
        }
        public double ConvertirKaC(string valor)
        {
            double res;

            res = Convert.ToDouble(valor) - 274;

            return res;
        }
        public double ConvertirKaF(string valor)
        {
            double res;
            res = Convert.ToDouble(valor) * (5 / 9) - 459.67; 
            return res;
        }
        public double  ConvertirFaC(string valor)
        {
            double res;
            res = (Convert.ToDouble(valor) - 32) * 5/9;
            return res;
        }
        public double ConvertirFaK(string valor)
        {
            double res;
            res = (Convert.ToDouble(valor) + 459.67) * (9 / 5);
            return res;
        }

    }
}
