using System;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Thiago";
            pessoa.Idade = 22;

            Console.WriteLine($"Olá, sou o {pessoa.Nome} e tenho {pessoa.Idade} anos");

            pessoa.ApresentarNoConsole();
        }
        
    }
}
