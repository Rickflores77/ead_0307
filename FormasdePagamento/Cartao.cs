using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD.FormasdePagamento
{
    public class Cartao : Pagamento
    {
        public string NumeroCartao { get; set; }
        public string Tipo { get; set; }
        public int Parcelas { get; set; }
        public int Senha { get; set; }
        public Cartao(string nomeCliente, double valor, string numeroCartao, string tipo, int parcelas, int senha) : base(nomeCliente, valor)
        {
            NumeroCartao = numeroCartao;
            Tipo = tipo;
            Parcelas = parcelas;
            Senha = senha;
        }
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R$ {Valor:F2} para {NomeCliente} usando o cartão {NumeroCartao}");
            Console.WriteLine("Pagamento com cartão aprovado!");
        }
    }
}