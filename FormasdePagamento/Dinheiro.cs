using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD.FormasdePagamento
{
    public class Dinheiro : Pagamento
    {
        public double ValorRecebido { get; set; }
        public Dinheiro(string nomeCliente, double valor, double valorRecebido) : base(nomeCliente, valor)
        {
            ValorRecebido = valorRecebido;
        }
        public override void ProcessarPagamento()
        {
            double troco = ValorRecebido - Valor;
            if (troco < 0)
            {
                Console.WriteLine($"Dinheiro: Valor insuficiente! Faltam R${-troco:F2} para concluir o pagamento de {NomeCliente}");
            }
            else
            {
                Console.WriteLine($"Dinheiro: Pagamento de {Valor:F2} recebido de {NomeCliente}. Troco: R${troco:F2}");
            }
        }
    }
}