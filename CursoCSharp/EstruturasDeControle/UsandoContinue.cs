using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoContinue {
        public static void Executar() {
            Console.WriteLine("Vamos listar os números pares de 1 até quanto?");
            string input = Console.ReadLine();

            int.TryParse(input, out int intervalo);
            Console.WriteLine("Números pares entre 1 e {0}", intervalo);

            for (int i = 1; i < intervalo; i++) {
                if (i % 2 == 1) {
                    continue;

                }

                Console.Write(i + " ");
            }
        }
    }
}
