using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            /*usando "var" o compilador infere 
             * um tipo pra ela, caso tenha sido 
             * incializada na msm linha
             */
            var meuNome = "Thiago"; //funciona
            /*var naoFunciona;
            naoFunciona = 123;
            */
            var grettings = "Hello";
            var name = "Inigo Montoya";
            var  dead = "my father";
            Console.WriteLine($"{grettings}, my name is {name}. You killed {dead}. Prepare to die.");
        }
    }
}
