using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.WindowHeight = 50;
            bool replay = false;

            GameManager game = new GameManager();

            game.DisplayWelcomeMessage();
            game.RequestPlayerName();

            do
            {
                game.SetUp();
                game.PlayGame();

                Console.Write("Would you like to play again Y or N? ");
                string newGame = Console.ReadLine().ToUpper();
                if (newGame == "Y")
                {
                    Console.Clear();
                    replay = true;                    
                }
                else
                {
                    replay = false;
                    Console.WriteLine("Thank you for playing!");
                }
            } while (replay);

            Console.ReadLine();
        }        
    }
}
