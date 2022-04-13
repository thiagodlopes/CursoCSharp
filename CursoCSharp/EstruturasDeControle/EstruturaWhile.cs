using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); //1..15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativasAtuais = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira o palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasRestantes--;
                tentativasAtuais++;

                if (numeroSecreto == palpite) {
                    var corAnterior = Console.BackgroundColor;
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativasAtuais);
                    Console.BackgroundColor = corAnterior;
                    Console.WriteLine("Continuar jogando? (s/n)");
                    string continuar = Console.ReadLine();
                    if (continuar.ToLower() == "s") {
                        Console.WriteLine("Aguardando a aula de métodos kkkkk");
                        tentativasRestantes = 0;
                        /*tentativasRestantes = 5;
                        numeroEncontrado = false;*/
                        //Colocar o sorteio do número dentro de um método e chamar aqui
                    } else {
                        tentativasRestantes = 0;
                    }
                    
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente.");
                    Console.Write("Tentativas Restantes: {0} ", tentativasRestantes);
                } else {
                    Console.WriteLine("Maior... Tente novamente.");
                    Console.WriteLine("Tentativas restantes {0} ", tentativasRestantes);
                }
            }

        }
    }
}
