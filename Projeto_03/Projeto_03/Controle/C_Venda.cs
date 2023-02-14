using Projeto_03.Modelo;
using System;


namespace Projeto_03.Controle
{
    internal class C_Venda
    {
        public Venda calculaVenda(Venda obj)
        {
            obj.Total = obj.Quantidade * obj.Valor;
            return obj;
        }

    }
}
