﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {

            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Convert.ToDouble(nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota < 10 && nota > 0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
