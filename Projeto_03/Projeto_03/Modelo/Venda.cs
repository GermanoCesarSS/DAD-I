using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_03.Modelo
{
    internal class Venda
    {
        public String Nome { get; set; }

        public double Total { get; set; }

        public double Quantidade { get; set; }

        public double Valor { get; set; }

        public Venda(String nome, double total, double quantidade, double valor)
        {
            Nome = nome;
            Total = total;
            Quantidade = quantidade;
            Valor = valor;
        }

        public Venda() { }
    }
}
