using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {

            Progetocelular celular = new Progetocelular();

            Console.WriteLine("Qual a cor do Celular");
            celular.cor = Console.ReadLine();

            Console.WriteLine("Qual o modelo do celular");
            celular.modelo = Console.ReadLine();

            Console.WriteLine("Qual o tamanho do celular");
            celular.tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("Ligar celular sim ou nao");
            celular.ligardesligar = Console.ReadLine();

      

            int opcao = 0;
            do 
            {
                Console.WriteLine("Selecione uma opcao");
                Console.WriteLine("[1] - Ligar celular para iniciar funçoes");
                Console.WriteLine("[2] - Fazer uma ligaçao");
                Console.WriteLine("[3] - enviar uma mensagen");
                Console.WriteLine("[4] - Desligar celular ");
                Console.WriteLine("[0] - opcao invalida");
                opcao = int.Parse(Console.ReadLine());

               switch (opcao)
               {
                   case 1: 
                        if (celular.ligardesligar == "nao")
                        {
                            celular.ligardesligar = "sim";
                            Console.WriteLine("Voce ligou o celular");
                        }else if(celular.ligardesligar == "sim"){
                            Console.WriteLine("O celular ja esta ligado");
                        }

                         Console.WriteLine("iniciar funçoes");

                       break;
                    case 2:
                        
                        if (celular.ligardesligar == "sim")
                           
                        {
                             Console.WriteLine("realizar ligaçao");
                        }else if(celular.ligardesligar == "nao"){
                            Console.WriteLine("voce precisa ligar o celular");
                        }
                        break;
                    case 3:
                        Console.WriteLine("enviando uma mensagem");
                        break;
                    case 4:
                        Console.WriteLine("desligando o celular");
                        break;
                    case 0:
                        Console.WriteLine("o celular nao pode realizar nenhuma funçao");
                        break;

                    
                    default:
                    Console.WriteLine("ola");
                       break;
               }
               


                 

                 
            } while (true!);
             
        }
    }
}