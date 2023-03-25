using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01.modelo
{
    public class Voto
    {
        public Voto(string VotoNumero, string label1, string label2)
        {
            this.VotoNumero = VotoNumero;
            this.label1 = label1;
            this.label2 = label2;
        }

        public string VotoNumero { get; set; }
        public string label1 { get; set;}
        public string label2 { get; set;}
    }
}
