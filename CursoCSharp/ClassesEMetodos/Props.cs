using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class PokemonOpcional {
        string nome;
        public string Nome {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }
        string tipo2;
        public string Tipo2 {
            get { return tipo2; }
            set {
                if (tipo2 != null) { tipo2 = value; } else {
                    tipo2 = Tipo1;
                } 
            }
        }

        //Propriedade autoimplementada
        public string Tipo1 { get; set; }

        public string Evolucao { get; set; }

        public string[] Movimentos { get; set; }

        /*Somente Leitura
        public string Evolucao {
            //get => Evolucao; Lambda
            get { return Evolucao; }
        }*/

        public PokemonOpcional(string nome, string tipo1, string tipo2, string evolucao, string movimento0, string movimento1, string movimento2, string movimento3) {
            Nome = nome;
            Tipo1 = tipo1;
            Tipo2 = tipo2;
            Evolucao = evolucao;
            string[] movimentos = { movimento0, movimento1, movimento2, movimento3 };
            Movimentos = movimentos;
        }

        public void MostrarPokemon() {
            Console.WriteLine(Nome);
            Console.WriteLine(Tipo1);
            Console.WriteLine(Tipo2);
            Console.WriteLine(Evolucao);
            foreach (var movimento in Movimentos) {
                Console.WriteLine(movimento);
            }
            Console.WriteLine("---");
        }
    }
    class Props {
        public static void Executar() {
            var pikachu = new PokemonOpcional("Pikachu", "Elétrico", null, "Raichu", "Soco do Trovão", "Cauda de Ferro", "Ataque Rápido", "Onda de Trovão");
            pikachu.MostrarPokemon();
        }
    }
}
