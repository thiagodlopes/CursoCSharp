using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper();
            var saudacoes = "Olá".Insert(3, " Mundo");
            Console.WriteLine(saudacao);
            Console.WriteLine(saudacoes);
            Console.WriteLine("teste".Length);

            string valor = null;
            Console.WriteLine(valor?.Length);//Sempre usar ? se a variavel puder ser nula
                                             //Não executa as paradas dps do ponto se a var for null
        }
    }
}
