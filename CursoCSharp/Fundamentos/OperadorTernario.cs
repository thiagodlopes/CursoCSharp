using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
