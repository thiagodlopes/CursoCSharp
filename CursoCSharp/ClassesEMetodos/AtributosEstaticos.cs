using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; //Transforma em atributo da classe, sendo o mesmo para todos os objetos dessa classe

        public Produto() { 
        }
        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;    
        }
    }

    class AtributosEstaticos {

        public static void Executar() {
            var produtoA = new Produto("Nome", 2.4, 0.2);

            var produtoB = new Produto() {
                Nome = "Borracha",
                Preco = 1.6
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com Original: {0}", produtoA.Preco);
            Console.WriteLine($"Desconto concedido: {Produto.Desconto}|| Equivalente a: {produtoA.Preco * Produto.Desconto}");
            Console.WriteLine("Preço com Desconto: {0}", produtoA.CalcularDesconto());

        }
    }
}
