using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Pokemon {
        private string Nome;
        private string Tipo1;
        private string Tipo2;
        private string Evolucao;
        private string[] Movimentos;

        public Pokemon(string nome, string tipo1, string tipo2, string evolucao, string[] movimentos) {
            Nome = nome;
            Tipo1 = tipo1;
            Tipo2 = tipo2;
            Evolucao = evolucao;
            Movimentos = movimentos;
        }

        public Pokemon(string nome, string tipo1, string tipo2, string evolucao, string movimento0, string movimento1, string movimento2, string movimento3) {
            SetNome(nome);
            SetTipo1(tipo1);
            SetTipo2(tipo2);
            SetEvolucao(evolucao);
            string[] movimentos = { movimento0, movimento1, movimento2, movimento3 };
            SetMovimentos(movimentos);
        }

        //Get
        public string GetNome() {
            return Nome;
        }
        public string GetTipo1() {
            return Tipo1;
        }
        public string GetTipo2() {
            return Tipo2;
        }
        public string GetEvolucao() {
            return Evolucao;
        }
        public string[] GetMovimentos() {
            return Movimentos;
        }

        //Set
        public void SetNome(string nome) {
            Nome = nome;
        }
        public void SetTipo1(string tipo1) {
            Tipo1 = tipo1;
        }
        public void SetTipo2(string tipo2) {
            if (Tipo2 != null) {
                Tipo2 = tipo2;
            } else {
                Tipo2 = GetTipo1();
            }
        }
        public void SetEvolucao(string evolucao) {
            Evolucao = evolucao;
        }
        public void SetMovimentos(string[] movimentos) {
            Movimentos = movimentos;
        }

        //Outros Métodos

        public void MostrarPokemon() {
            Console.WriteLine(GetNome());
            Console.WriteLine(GetTipo1());
            Console.WriteLine(GetTipo2());
            Console.WriteLine(GetEvolucao());
            foreach (var movimento in GetMovimentos()) {
                Console.WriteLine(movimento);
            }
            Console.WriteLine("---");
        }
    }

    class GetESet {
        public static void Executar() {
            string[] bulbasaurMovimentos = { "Folha Navalha", "Chicote de Cipó", "Investida", "Pó Venenoso" };
            Pokemon bulbasaur = new Pokemon("Bulbasaur", "Grama", "Veneno", "Ivysaur", bulbasaurMovimentos);
            Pokemon ivysaur = new Pokemon("Ivysaur", "Grama", "Veneno", "Venusaur", "Folha Navalha", "Terremoto", "Raio Solar", "Pó Venenoso");
            Pokemon charmander = new Pokemon("Charmander", "Fogo", null, "Charmeleon", "Brasa", "Arranhar", "Mordida", "Dança do Dragão");

            bulbasaur.MostrarPokemon();
            ivysaur.MostrarPokemon();
            charmander.MostrarPokemon();
        }
    }
}
