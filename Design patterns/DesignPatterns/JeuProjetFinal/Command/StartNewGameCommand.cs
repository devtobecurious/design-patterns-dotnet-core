using JeuProjetFinal.Builder;
using JeuProjetFinal.Singleton;
using JeuProjetFinal.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.Command
{
    internal class StartNewGameCommand : ICommand
    {
        private readonly Application application;

        public StartNewGameCommand(Application application)
        {
            this.application= application;
        }

        public void Execute()
        {
            GameMotor motor = GameMotor.Instance;
            var game = motor.StartNewGame();
            this.application.AddNewGame(game);

            Player player = new();
            player.RequestInput(() =>
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please set the input");
                Input input = new(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;

                return input;
            });
        }
    }
}
