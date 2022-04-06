using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); //Operador antes da varíavel tem prioridade e foi realizado antes da comparação, ao contrário do ++
            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}
