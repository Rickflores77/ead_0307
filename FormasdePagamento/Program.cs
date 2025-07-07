using System;
using EAD.FormasdePagamento;


Console.WriteLine("Bem-vindo ao sistema de pagamento!");

Console.Write("Digite o nome do cliente: ");
string nome = Console.ReadLine();

Console.Write("Digite o valor da compra: ");
double valor = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a forma de pagamento:");
Console.WriteLine("1 - Cartão");
Console.WriteLine("2 - Pix");
Console.WriteLine("3 - Dinheiro");
Console.Write("Opção: ");
int opcao = int.Parse(Console.ReadLine());

Pagamento pagamento = null;

switch (opcao)
{
    case 1:
        Console.Write("Digite o número do cartão: ");
        string numeroCartao = Console.ReadLine();

        Console.Write("Pagamento será em: 1 - Débito 2 - Crédito  Opção: ");
        int tipoOpcao = int.Parse(Console.ReadLine());

        string tipo = tipoOpcao == 1 ? "Débito" : "Crédito";

        int parcelas = 1;
        if (tipo == "Crédito")
        {
            Console.Write("Digite o número de parcelas: ");
            parcelas = int.Parse(Console.ReadLine());
            double valorParcela = valor / parcelas;
            Console.WriteLine($"Valor de cada parcela: R${valorParcela:F2}");
        }

        Console.Write("Digite a senha do cartão (apenas números): ");
        int senha = int.Parse(Console.ReadLine());

        pagamento = new Cartao(nome, valor, numeroCartao, tipo, parcelas, senha);
        break;

    case 2:
        Console.Write("Digite a chave Pix: ");
        string chavePix = Console.ReadLine();
        pagamento = new Pix(nome, valor, chavePix);
        break;

    case 3:
        Console.Write("Digite o valor recebido: ");
        double valorRecebido = double.Parse(Console.ReadLine());
        pagamento = new Dinheiro(nome, valor, valorRecebido);
        break;

    default:
        Console.WriteLine("Opção inválida!");
        return;
}

Console.WriteLine();
pagamento.ProcessarPagamento();
Console.WriteLine("Pagamento finalizado!");

