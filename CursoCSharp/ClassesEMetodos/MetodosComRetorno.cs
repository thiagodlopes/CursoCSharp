using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Calculadora {
        public int Somar(int numeroA, int numeroB) {
            return numeroA + numeroB;
        }

        public int Subtrair(int numeroA, int numeroB) {
            return numeroA - numeroB;
        }

        public int Multiplicar(int numeroA, int numeroB) {
            return numeroA * numeroB;
        }

    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;    
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        
        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria; 
        }
    }

    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(2).Imprimir()
                .Subtrair(4).Imprimir()
                .Limpar().Imprimir();

            string nomeOperacao = "";
            int resultado = 0;
            var calculadora = new Calculadora();
            Console.WriteLine("Qual operação deseja realizar? 1-Somar, 2-Subtrair, 3-Multiplicar");
            string input = Console.ReadLine();
            int.TryParse(input, out int operacao);

            Console.WriteLine("Informe o primeiro número:");
            string inputNumeroA = Console.ReadLine();
            int.TryParse(inputNumeroA, out int numeroA);
            Console.WriteLine("Informe o segundo número:");
            string inputNumeroB = Console.ReadLine();
            int.TryParse(inputNumeroB, out int numeroB);

            switch (operacao) {
                case 1:
                    resultado = calculadora.Somar(numeroA, numeroB);
                    nomeOperacao = "Adição";
                    break;
                case 2: 
                    resultado = calculadora.Subtrair(numeroA, numeroB);
                    nomeOperacao = "Subtração";
                    break;
                case 3:
                    resultado = calculadora.Multiplicar(numeroA, numeroB);
                    nomeOperacao = "Multiplicação";
                    break;
                default:
                    Console.WriteLine("O valor inserido é inválido");
                    break;
            }

            Console.WriteLine($"O resultado da operação de {nomeOperacao} é {resultado}");
        }
    }
}
