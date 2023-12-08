using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm
{
    internal class MainPageViewModel 
    {
        public string Sumar1 { get; set; }
        public string Sumar2 { get; set; }
        public string Resultado { get; set; }

        public void Sumar()
        {
            int Sumar1, Sumar2, resultado;
            int.TryParse(Sumar1, out Sumar1);
            int.TryParse(Sumar2, out Sumar2);
            resultado = Sumar1 + Sumar2;
            Resultado = resultado.ToString();
        }

        public void Limpiar()
        {
            Sumar1 = "";
            Sumar2 = "";
            Resultado = "";
        }
    }
}

