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

            Produto iphone = new Produto();
            iphone.Codigo  = 1;
            iphone.Nome    = "iPhone 12";
            iphone.Preco   = 9.999f;

            foreach (Produto p in produtos){
                System.Console.WriteLine($"{p.Nome} - R$ {p.Preco}.");
            }

            produtos.RemoveAt(3);

            produtos.RemoveAll(x => x.Nome == "iPhone 11");

            System.Console.WriteLine("\nLista alterada");
            foreach (Produto p in produtos){
                System.Console.WriteLine($"{p.Nome} - R$ {p.Preco}.");
            }
        }
    }
}
