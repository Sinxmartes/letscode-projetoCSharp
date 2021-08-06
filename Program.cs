using System;
using System.Linq;
using System.Collections.Generic;

namespace projectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Random randomica = new Random();
            string nomePersonagem;
            nomePersonagem = "Loki";
            int idade = 3000;
            char sexo = 'M';
            bool variante;
            double temperaturaEspecie = 36.2;
            var especie = "Asgardiano"; */
            
            /* variante = true;
            if (variante) { //condição
                Console.WriteLine("É UMA VARIANTE");
                sexo = 'M';
                especie = "Jacaré";
                idade = 20;
                temperaturaEspecie = 25.0;
            } else {
                Console.WriteLine("NÃO É UMA VARIANTE");
            } */

            // operador igualdade ==
            // operador igual ou maior que >=
            // operador igual ou menor que <=
            // operador desigualdade !=

            // = -> atribuição
            // == -> comparação
            
            /* Console.WriteLine($"Seu nome é: {nomePersonagem}");
            Console.WriteLine(string.Concat("Sua espécie é: ", especie)); */

            // temperaturaCorporal = 37.5
            //if (temperaturaCorporal >= 37.0 && temperaturaCorporal <= 37.9) Console.Write("Está Febril")

            /* if(especie == "Asgardiano")
                Console.WriteLine($"O sexo do personagem é {sexo}");
            else if (especie == "Jacaré")
                switch (sexo)
                {
                    case 'M':
                        Console.WriteLine("O Jacaré é Macho");
                        break;
                    case 'F': 
                        Console.WriteLine("O Jacaré é Fêmea");
                        break;
                    default:
                        Console.WriteLine("Sexo Inválido");
                        break;
                }
            else
                Console.WriteLine("Algo está incorreto na nomenclatura da espécie");

            Console.Write("Sua temperatura é: ");
            Console.WriteLine(temperaturaEspecie);
            Console.Write("Sua idade é: ");
            Console.WriteLine(idade); */

            
            /* int i = 0;
            
            while(i != 5) {
                Console.WriteLine("O valor é diferente de 5");
                Console.WriteLine($"O valor atual é de {i}");
                i = randomica.Next(15);
            }

            int j;

            do {
                Console.WriteLine("Por favor, digite um valor de 0 a 10: ");
                j = Int32.Parse(Console.ReadLine());
                if (j >= 0 && j<= 10) {
                    Console.WriteLine("O valor é diferente de 5");
                    Console.WriteLine($"O valor atual é de {j}");
                } else 
                    Console.WriteLine("O valor digitado é menor que 0 ou maior que 10");                
            } while(j != 5);

            do {
                Console.WriteLine("Por favor, digite um valor de 10 a 20: ");
                string entrada = Console.ReadLine(); 
                j = Int32.Parse(entrada);
                if (j >= 10 && j<= 20) {
                    Console.WriteLine("O valor é diferente de 15");
                    Console.WriteLine($"O valor atual é de {j}");
                } else 
                    Console.WriteLine("O valor digitado é menor que 10 ou maior que 20");                
            } while(j != 15); */

            // Estrutura de Repetição PARA/FOR

            // k++ == k = k + 1
            // k-- == k = k - 1

            /* for(int k = 10; k > 0; k--) {
                Console.Write($"{k}, ");
            } */

            // Estrutura Condicional Ternária
            // var x = condicao ? condVerd : condFalsa

            /* int mensagem = ("true" != "true") ? 1 : (2 != 2) ? 1 : 0;
            Console.WriteLine(mensagem); */

            /**
                VETORES E MATRIZES
                int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };
            **/

            /* int[] numerosInteiros = new int[100]; // 0 ao 99

            for(int i = 0; i < 100; i++) {
                numerosInteiros[i] = (i + 1) * 2;
            }

            for(int i = 0; i < numerosInteiros.Length; i++) {
                numerosInteiros[i] = (i + 1) * 2;
            }

            foreach (int item in numerosInteiros) {
                Console.Write($"{item}, ");
            }

            int [,] arrayMulti2 = {
                {10, 30, 50}, //linha 0
                {15, 35, 55}, //linha 1
                {20, 40, 60}  //linha 2
            }; 

            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    Console.WriteLine($"Está na linha {i}, Na coluna {j}, tendo o valor {arrayMulti2[i,j]}");
                }
            } */

            /* List<string> comida = new List<string>();

            comida.Add("arroz");
            comida.Add("feijão");
            comida.Add("batata");
            comida.Add("macarrão");


            foreach(var item in comida) {
                Console.WriteLine(item);
            }*/

            /* int y = comida.FindIndex(x => x.Contains("batata"));

            Console.WriteLine(y); */

            /*comida.Remove("arroz");

            foreach(var item in comida) {
                Console.WriteLine(item);
            }*/

            /**
                Collections
            **/

             // List<string> listaMercado = new List<string>() { "Requeijão" };

            // listaMercado.Add("Leite");

            // // Console.WriteLine($"Quantidade itens na lista é {listaMercado.Count()}");//1

            // listaMercado.Add("Pão");

            // // Console.WriteLine($"Quantidade itens na lista é {listaMercado.Count()}");//2
            
            // listaMercado.Add("Ovos");

            // // Console.WriteLine($"Quantidade itens na lista é {listaMercado.Count()}");//3

            // listaMercado.Add("Pão");

            // foreach(string i in listaMercado)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine($"O indice do Pão é {listaMercado.LastIndexOf("Pão")}");

            // //listaMercado.RemoveAt(listaMercado.IndexOf("Pão"));
            
            // foreach(string i in listaMercado)
            // {
            //     Console.WriteLine(i);
            // }

            // foreach(string i in listaMercado)
            // {
            //     if(i == "Ovos")
            //     {
            //         listaMercado.Remove(i);
            //         break;
            //     }
            // }

            // listaMercado.RemoveAt(2);

            // Console.WriteLine("------------");

            // foreach(string i in listaMercado)
            // {
            //     Console.WriteLine(i);
            // }

            // listaMercado.RemoveAt(0);

            // Console.WriteLine("------------");

            // foreach(string i in listaMercado)
            // {
            //     Console.WriteLine(i);
            // }

            /* Dictionary<string, float> listaMercadoAprimorada = new Dictionary<string, float>();
            Dictionary<int, string> listaCodigoDeBarras = new Dictionary<int, string>();
            int indiceContador = 1; */

            // listaMercadoAprimorada.Add("Leite", 4.99f);
            // listaMercadoAprimorada.Add("Pão", 1.00f);

            /* Console.WriteLine($"adicionando chave {indiceContador}");
            listaCodigoDeBarras.Add(indiceContador++, "Leite"); */

            //listaMercadoAprimorada["Leite"] = 3;

            // foreach(KeyValuePair<string, float> i in listaMercadoAprimorada)
            // {
            //     Console.WriteLine($"o valor do {i.Key} é {i.Value}");
            // }

            // foreach(KeyValuePair<int, string> i in listaCodigoDeBarras)
            // {
            //     Console.WriteLine($"o código de barras {i.Key} é o item {i.Value}");
            // }

            /* Console.WriteLine($"adicionando chave {indiceContador}");
            listaCodigoDeBarras.Add(indiceContador, "Pão"); */

            // listaCodigoDeBarras[12] = "Manteiga";
            // Console.WriteLine("atualiando código de barras");

            // listaCodigoDeBarras.Add(20, "Leite");
            // Console.WriteLine("adicionando novo item na lista");

            /* Console.WriteLine($"Confere se a chave {indiceContador} já existe");
            if(listaCodigoDeBarras.ContainsKey(indiceContador))
            {
                Console.WriteLine($"chave {indiceContador} já existe, adicionando chave {++indiceContador}");
                listaCodigoDeBarras.Add(indiceContador++, "Queijo");
            }
            else
            {
                Console.WriteLine($"a chave {indiceContador} não existe, adiconando chave {indiceContador}");
                listaCodigoDeBarras.Add(indiceContador++, "Ovo");
            }

            Console.WriteLine($"proximo código disponível {indiceContador}");

            foreach(KeyValuePair<int, string> i in listaCodigoDeBarras)
            {
                Console.WriteLine($"o código de barras {i.Key} é o item {i.Value}");
            }

            listaCodigoDeBarras.Remove(1);
            Console.WriteLine("Removendo item");

            foreach(KeyValuePair<int, string> i in listaCodigoDeBarras)
            {
                Console.WriteLine($"o código de barras {i.Key} é o item {i.Value}");
            } */
          
            //int opcao = Int32.Parse(Console.ReadLine());
            
            /* menu(); */

            /* menuLinq();      */       
            
            var retornoMenu = projectCSharp.Menu.menu();
            Console.WriteLine(retornoMenu);

            /*
                switch (opcao)
                {
                    case 1:
                    case 2:
                    case 3:
                        // dados para opcao 1, 2 e 3 
                        Console.WriteLine($"Opção {opcao} escolhida");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            */
        }

        static void opcaoUm() {
            Console.WriteLine("Vamos iniciar um novo jogo");
            Console.WriteLine("Era uma vez, um carro chamado Relampago Marquinho");            
        }

        static void opcaoDois() {
            Console.WriteLine("Escolha o jogo a ser carregado:");            
        }

        static void opcaoTres() {
            Console.WriteLine("Saindo.."); 
        }

        static void menu() {
            Console.WriteLine("Bem vindo ao jogo de texto");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Novo jogo");
            Console.WriteLine("2 - Carregar jogo");
            Console.WriteLine("3 - Sair");
            opcoes();
        }

        static void menuLinq() {
            Console.WriteLine("Bem vindo a consulta de dados");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Raça");
            Console.WriteLine("3 - Planeta");
            opcoesLinq();
        }

        static void opcoesLinq() {
            int opcao;            
            do {
                Console.Write("Escolha uma das opções: ");
                opcao = Convert.ToInt32(Console.ReadLine());                
                if(opcao != 1 && opcao != 2 && opcao != 3) Console.WriteLine("Opção Invalida, tente novamente");                
            } while(opcao != 1 && opcao != 2 && opcao != 3);
            switch (opcao) {
                case 1:
                    Console.Write("Por favor, digite o nome do personagem desejado: ");
                    linqNome(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Por favor, digite a raça do personagem desejado: ");
                    linqRaca(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Por favor, digite o planeta do personagem desejado: ");
                    linqPlaneta(Console.ReadLine());
                    break;
            }
        }

        static void opcoes() {
            int opcao;
            
            do {
                Console.Write("Escolha uma das opções: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                
                if(opcao != 1 && opcao != 2 && opcao != 3) Console.WriteLine("Opção Invalida, tente novamente");
                // vamos transformar em um if ternário

            } while(opcao != 1 && opcao != 2 && opcao != 3);

            switch (opcao) {
                case 1:
                    // dados para opcao 1
                    opcaoUm();
                    break;
                case 2:
                    // dados para opcao 2
                    opcaoDois();
                    break;
                case 3:
                    // dados para opcao 3 
                    opcaoTres();
                    break;
            }
        }

        static void aulaLinq(string planeta) {
            /* int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var numQuery =
                from num in numeros
                where (num % 2) == 0
                select num;
                
            foreach(int num in numQuery) {
                Console.Write($"{num}, ");
            }
  
            Console.WriteLine("\n"); */

            //Personagens personagem = new Personagens("marco", "ser humano", "terra");
            
            IList<Personagens> fontePersonagens = cadastrarDados();

            IEnumerable<Personagens> retorno =
                    from d in fontePersonagens
                    where d.Planeta == planeta
                    select d;

            foreach(Personagens personagem in retorno) {
                Console.WriteLine($"Nome: {personagem.Nome} \nRaça: {personagem.Raca} \nPlaneta: Casa {personagem.Planeta}");
            }
        }

        static void linqPlaneta(string planeta) {
            IList<Personagens> fontePersonagens = cadastrarDados();

            IEnumerable<Personagens> retorno =
                    from d in fontePersonagens
                    where d.Planeta == planeta
                    select d;

            foreach(Personagens personagem in retorno) {
                Console.WriteLine($"Nome: {personagem.Nome} \nRaça: {personagem.Raca} \nPlaneta: Casa {personagem.Planeta}");
            }
        }

        static void linqNome(string nome) {
            IList<Personagens> fontePersonagens = cadastrarDados();

            IEnumerable<Personagens> retorno =
                    from d in fontePersonagens
                    where d.Nome == nome
                    select d;

            foreach(Personagens personagem in retorno) {
                Console.WriteLine($"Nome: {personagem.Nome} \nRaça: {personagem.Raca} \nPlaneta: Casa {personagem.Planeta}");
            }
        }

        static void linqRaca(string raca) {
            IList<Personagens> fontePersonagens = cadastrarDados();

            IEnumerable<Personagens> retorno =
                    from d in fontePersonagens
                    where d.Raca == raca
                    select d;

            foreach(Personagens personagem in retorno) {
                Console.WriteLine($"Nome: {personagem.Nome} \nRaça: {personagem.Raca} \nPlaneta: Casa {personagem.Planeta}");
            }
        }

        static IList<Personagens> cadastrarDados() {
            return new List<Personagens>() {
                new Personagens("Chaves", "barril", "8"),
                new Personagens("Chiquinha", "anã", "14"),
                new Personagens("Bruxa do 71", "bruxas", "71"),
                new Personagens("Seu Madruga", "caloteiro", "14"),
            };
        }
    }

    class Personagens {
        public Personagens(string _nome, string _raca, string _planeta) {
            Nome = _nome;
            Raca = _raca; 
            Planeta = _planeta;
        }

        public string Nome { get; set; }

        public string Raca { get; set; }

        public string Planeta { get; set; }
    }
}