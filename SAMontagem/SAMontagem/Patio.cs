using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMontagem
{
    class Patio
    {
        
        public string Tipo { get; set; }
        public int Motor { get; set; }
        public int Rodas { get; set; }
        public int Farol { get; set; }
        public string Portas { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }

        public Patio()
        {

        }

        public override string ToString()
        {
            return Tipo + " - " + Modelo + ", Ano " + Ano + ", Placa ";
        }


    }
}
