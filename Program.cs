using System;
using System.Collections.Generic;

namespace Aula23ListadeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "iPhone 11", 4.999f));
            produtos.Add(new Produto(2, "RTX 2080 SUPER", 5.999f));
            produtos.Add(new Produto(3, "SSD Kingston M.2 NVMe 960gb", 2.499f));
            produtos.Add(new Produto(4, "Intel Core i9-9900k Coffe Lake", 3.699f));
            produtos.Add(new Produto(5, "HyperX Cloud Mix Rose Gold", 1.349f));

            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Lista de produtos e preços:");
            foreach (Produto p in produtos){
                System.Console.WriteLine($"{p.Nome} - R$ {p.Preco}.");
            }

            produtos.RemoveAll(x => x.Nome == "iPhone 11");

            System.Console.WriteLine("\nLista alterada:\n");
            foreach (Produto p in produtos){
                System.Console.WriteLine($"{p.Nome} - R$ {p.Preco}.");
            }
            Console.ResetColor();

            List<Cartao> cartoes = new List<Cartao>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            cartoes.Add(new Cartao("Henrique", "567912363524", "Visa", "06/25", 459 ));
            cartoes.Add(new Cartao("Maria", "164873519875", "MasterCard", "06/26", 564 ));
            cartoes.Add(new Cartao("Jorge", "896749865238", "Elo", "06/24", 126 ));

            foreach (Cartao c in cartoes){
                System.Console.WriteLine($"\nTitular do Cartão: {c.Titular}.\nNumero: {c.Numero}.\nBandeira: {c.Bandeira}.\nVencimento: {c.Vencimento}.\nCódigo de Segurança (CVV): {c.CVV}.");
            }
            Console.ResetColor();
        }
    }
}
