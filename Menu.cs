using System;
using System.Linq;
using System.Collections.Generic;

namespace projectCSharp
{
    class Menu {        
        public static int menu() {
            Console.WriteLine("Bem vindo ao jogo de texto");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Novo jogo");
            Console.WriteLine("2 - Carregar jogo");
            Console.WriteLine("3 - Sair");
            Console.Write("opção: ");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
