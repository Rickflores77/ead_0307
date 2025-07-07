using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD.FormasdePagamento
{
    public abstract class Pagamento
    {
        public string NomeCliente { get; set; }
        public double Valor { get; set; }
        public Pagamento(string nomeCliente, double valor)
        {
            NomeCliente = nomeCliente;
            Valor = valor;
        }
        public abstract void ProcessarPagamento();
    }
}