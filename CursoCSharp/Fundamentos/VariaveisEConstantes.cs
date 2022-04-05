using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            double area = raio * 2;
            Console.WriteLine($"A área é igual a: {area}");

            //booleano:

            bool eDeManha = true;
            Console.WriteLine($"É de manhã? {eDeManha}");

            //byte: vai de 0 a 255

            byte teste = 255;
                Console.WriteLine(teste);
            
            //sbyte: vai de -128 a 127

            sbyte testezada = 127;
                Console.WriteLine(testezada);
        }
    }
}