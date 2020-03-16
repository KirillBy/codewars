using System;

namespace Snakes_and_Ladders
{
    class Program
    {
        static void Main(string[] args)
        {

            SnakesLadders game = new SnakesLadders();
            game.play(1, 1);
            game.play(2, 1);
            game.play(3, 5);
            game.play(6, 6);
            game.play(2, 3);
            game.play(4, 5);
            game.play(6, 4);
            game.play(6, 4);
            game.play(5, 6);
            game.play(6, 5);
            game.play(6, 5);
            game.play(6, 5);
            game.play(1, 5);
            game.play(6, 5);
            game.play(1, 2);
            game.play(0, 2);
            game.play(0, 2);
            game.play(0, 2);

        
        }

    }
}
