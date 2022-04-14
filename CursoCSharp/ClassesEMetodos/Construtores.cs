using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano; 
        }

        public Carro() { //Habilita os construtores que não passam parâmetro direto

        }
    }
    class Construtores {
        public static void Executar() {
            var carro = new Carro(); //Construtor padrão (Só pode ser usado quando não há construtor ou quando é definido de forma explícita)
            carro.Fabricante = "FIAT";
            carro.Modelo = "Uno";
            carro.Ano = 2015;
                Console.WriteLine($"{carro.Fabricante} {carro.Modelo} {carro.Ano}");

            var carroConstrutor = new Carro("FIAT", "Marea", 2000);
            Console.WriteLine($"{carroConstrutor.Modelo} {carroConstrutor.Fabricante} {carroConstrutor.Ano}");

            //Outro jeito de criar
            var carroOutroJeito = new Carro() {
                Modelo = "Strada",
                Fabricante = "FIAT",
                Ano = 2002
            };
            Console.WriteLine($"{carroOutroJeito.Fabricante} {carroOutroJeito.Modelo} {carroOutroJeito.Ano}");

        }
    }
}
