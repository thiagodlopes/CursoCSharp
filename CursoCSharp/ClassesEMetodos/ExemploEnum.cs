using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ExemploEnum {

        public enum Tipo { 
            Agua, Aço, Dragao, Eletrico, Grama, Fada, Fantasma, Fogo, Gelo, 
            Inseto, Lutador, Normal, Noturno, Pedra, Psiquico, Solo, Veneno, Voador
        }

        public class Pokemon {
            public string Nome;
            public Tipo Tipo1;
            public Tipo Tipo2;

            public void Apresentar() {
                Console.WriteLine("O Pokémon {0} é dos tipos {1} e {2}", Nome, Tipo1, Tipo2);
            }
        }
        public static void Executar() {
            int id = (int)Tipo.Voador;
            Console.WriteLine(id);

            var greninja = new Pokemon();
            greninja.Nome = "Greninja";
            greninja.Tipo1 = Tipo.Agua;
            greninja.Tipo2 = Tipo.Noturno;

            greninja.Apresentar();
        }
    }
}
