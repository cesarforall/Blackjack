// Blackjack
// El jugador juega contra la banca
// Se gana el juego con 21

using System.Numerics;

namespace Blackjack
{
    class Program
    {
        static int getRandom()
        {
            var random = new Random();
            return random.Next(1, 12);
        }
        static void printInterface(int dealer, int player, string message)
        {
            Console.Clear();
            Console.WriteLine("\r\n  ____   _         _     ____  _  __    _    _     ____  _  __\r\n | __ ) | |       / \\   / ___|| |/ /   | |  / \\   / ___|| |/ /\r\n |  _ \\ | |      / _ \\ | |    | ' / _  | | / _ \\ | |    | ' / \r\n | |_) || |___  / ___ \\| |___ | . \\| |_| |/ ___ \\| |___ | . \\ \r\n |____/ |_____|/_/   \\_\\\\____||_|\\_\\\\___//_/   \\_\\\\____||_|\\_\\\r\n                                                              \r\n");
            Console.WriteLine($"Dealer hand: {dealer}");
            Console.WriteLine($"Player hand: {player}");
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }
        static void Main()
        {
            int player = 0;
            int dealer = 0;
            int blackjack = 21;
            string playerInput = "y";
            var random = new Random();
            string isPlaying = "y";

            while (isPlaying == "y")
            {
                dealer += getRandom();
                dealer += getRandom();
                player += getRandom();
                player += getRandom();
                printInterface(dealer, player, "");                
                
                while (playerInput == "y" && player < 21)
                {
                    while (true)
                    {
                        Console.WriteLine("¿Hit? [y/n]");
                        playerInput = Console.ReadLine();
                        if (playerInput == "y")
                        {
                            player += getRandom();
                            printInterface(dealer, player, "");
                            break;
                        }
                        else if (playerInput == "n") break;
                        else printInterface(dealer, player, "Invalid!"); ;
                    }
                }
                if (player == blackjack)
                {
                    printInterface(dealer, player, "Blackjack!");
                }
                else if (player < blackjack)
                {
                    if (player > dealer)
                    {
                        printInterface(dealer, player, "Player won!");
                    } else if (player == dealer)
                    {
                        printInterface(dealer, player, "Tie!");
                    } else
                    {
                        printInterface(dealer, player, "Player lose!");
                    }
                }
                else
                {
                    Console.WriteLine("Player lose!");
                }
                while (true)
                {
                    Console.WriteLine("Play again? [y/n]");
                    isPlaying = Console.ReadLine();
                    if (isPlaying == "n") break;
                    else if (isPlaying == "y")
                    {
                        player = 0;
                        dealer = 0;
                        playerInput = "y";
                        break;
                    }
                    else
                    {
                        printInterface(dealer, player, "Invalid!"); ;
                    }
                }
            }

        }
    }
}