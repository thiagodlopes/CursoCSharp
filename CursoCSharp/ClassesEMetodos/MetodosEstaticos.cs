using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraEstatica {

        public static int Multiplicar(int a, int b) { //Acessível através da Classe || Método de Classe
            return a * b;
        }

        public int Somar(int a, int b) { //Acessível somente através de instância || Método de Objeto
            return a + b;
        }
    }
    class MetodosEstaticos {

        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(1, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine(calculadoraEstatica.Somar(5,6));

        }
    }
}
