using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 1;
            Console.WriteLine("1 = " + num1);
            num1 = 7;
            Console.WriteLine("7 = " + num1);
            num1 += 1;
            Console.WriteLine("7 + 1 = " + num1);
            num1 -= 2;
            Console.WriteLine("7 + 1 - 2 = " + num1);
            num1 *= 3;
            Console.WriteLine("(7 + 1 - 2)*3 = " + num1);
            num1 /= 2;

            Console.WriteLine("((7 + 1 - 2)*3)/2 = " + num1);

        }
    }
}
