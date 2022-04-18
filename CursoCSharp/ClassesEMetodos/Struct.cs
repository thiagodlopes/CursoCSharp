using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }

        public void Exibir() {
            Console.WriteLine("Coordenada:");
            Console.WriteLine("X = {0}", X);
            Console.WriteLine("Y = {0}", Y);
        }
    }

    class Struct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            coordenadaInicial.Exibir();

            var coordenadaFinal = new Coordenada(x: 2, y: 2);
            coordenadaFinal.Exibir();
            coordenadaFinal.MoverNaDiagonal(5);
            coordenadaFinal.Exibir();
        }
    }
}
