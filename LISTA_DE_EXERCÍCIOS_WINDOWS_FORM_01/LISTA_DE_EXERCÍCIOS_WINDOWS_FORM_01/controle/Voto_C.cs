using LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01.controle
{
    public class Voto_C
    {
        public Voto Votar(Voto obj) 
        {
            if (obj.label1 == "")
            {
                obj.label1 = obj.VotoNumero;
            }
            else if (obj.label1 != "" && obj.label2 == "")
            {
                obj.label2 = obj.VotoNumero;
            }
            return obj;
        }
    }
}
