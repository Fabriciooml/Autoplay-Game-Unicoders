using System;

namespace palpiteDaAlegria
{
    class Program
    {
        static void Main(string[] args)
        {
            string decisaoJogador;

            do{  
                int palpite = 25;
                int auxilioBusca = 16;          
                int numeroSorteado = new Random().Next(0, 50);
                for (int quantidadeDeChutes = 0; quantidadeDeChutes < 5; quantidadeDeChutes += 1)
                { 
                    System.Console.WriteLine(palpite);                   
                    if(palpite == numeroSorteado)
                    {
                        Console.WriteLine("Parabéns, você ganhou!!");
                        break;
                    }
                    else if(palpite > numeroSorteado)
                    {
                        System.Console.WriteLine("Seu palpite é MAIOR que o número sorteado!!");
                        palpite = palpite - auxilioBusca;

                    }
                    else
                    {
                        System.Console.WriteLine("Seu palpite é MENOR que o número sorteado!!");
                        palpite = palpite + auxilioBusca;
                    }
                    if (palpite < 0)
                    {
                        palpite = 0;
                    }
                    else if(palpite > 50)
                    {
                        palpite = 50;
                    }
                    auxilioBusca = auxilioBusca/2;
                }
                System.Console.WriteLine("Acabou o jogo!!");
                System.Console.WriteLine("Quer continuar? [s/n]");
                decisaoJogador = Console.ReadLine();
            }
        while(decisaoJogador == "s");
        }
    }
}
