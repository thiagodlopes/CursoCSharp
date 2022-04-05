using System;
//using System.Globalization
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());
            //,CultureInfo.InvariantCulture
            /*Para dividir casas deciamais com . é só descomentar 
             * as linhas acima. A 2ª tem q ser inserida antes do parenteses
             * do Console.
             */
                         
            Console.WriteLine($"Nome   : {nome}");
            Console.WriteLine($"Idade  : {idade} anos");
            Console.WriteLine($"Salário: R$ {salario}");

        }
    }
}
