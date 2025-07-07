using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD.FormasdePagamento
{
    public class Pix : Pagamento
    {
        public string ChavePix { get; set; }
        public Pix(string nomeCliente, double valor, string chavePix) : base(nomeCliente, valor)
        {
            ChavePix = chavePix;
        }
        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R$ {Valor:F2} para {NomeCliente} via chave pix {ChavePix}");
            Console.WriteLine("Pagamento via PIX aprovado!");
        }
    }
}