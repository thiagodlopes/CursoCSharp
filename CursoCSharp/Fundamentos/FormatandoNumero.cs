using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); /*Uma casa decimal*/
            Console.WriteLine(valor.ToString("C")); /*Valor Monetário*/
            Console.WriteLine(valor.ToString("P")); /*Valor Percentual*/
            Console.WriteLine(valor.ToString("#.##")); /*Dizer exatamente o número de casas decimais*/

            CultureInfo portugues = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", portugues));

            CultureInfo ingles = new CultureInfo("eb-US");
            Console.WriteLine(valor.ToString("C2", ingles));
        }
    }
}
