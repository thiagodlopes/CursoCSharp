using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.WriteLine("Informe a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de honra");
            } else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine("Não fez mais que a obrigação");
            } else {
                Console.WriteLine("Recuperation...");
            }

            Console.WriteLine("Tchau");
        }
    }
}
