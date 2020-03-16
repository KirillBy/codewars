using System;
using System.Collections.Generic;
using System.Text;

namespace Snakes_and_Ladders
{
    enum GameStatus
    {
        Active, GameOver
    }
    class SnakesLadders
    {
        GameStatus currentGame;
        private List<int>  laddersArray = new List<int>{ 2, 7, 8, 15, 21, 28, 36, 51, 71, 78 ,87 };
        private List<int> snakesArray = new List<int>{ 16, 46, 49, 62, 64, 74, 89, 92, 95, 99 };
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");
        public Player CurrentPlayer { get; private set; }
        public Player PreviousPlayer { get; private set; }
        
        public SnakesLadders()
        {
            CurrentPlayer = player1;
            PreviousPlayer = player2;
            currentGame = GameStatus.Active;
        }
        public string play(int die1, int die2)
        {
            if(currentGame == GameStatus.Active)
            {
            int positionToGo = CurrentPlayer.CurrentPosition + die1 + die2;
             {
                
                CurrentPlayer.CurrentPosition = positionToGo;
                if (laddersArray.Contains(CurrentPlayer.CurrentPosition))
                    LadderUp();
                if (snakesArray.Contains(CurrentPlayer.CurrentPosition))
                    SnakeDowxn();
                if (CurrentPlayer.CurrentPosition > Player.WINPOSITION)
                    StepForward();
                if (CurrentPlayer.CurrentPosition == Player.WINPOSITION)
                {
                    currentGame = GameStatus.GameOver;
                        Console.WriteLine(CurrentPlayer.Name + "Wins!");
                    return CurrentPlayer.Name + "Wins!";
                    
                }
                if(die1 != die2)
                    {
                         ChangeCurrentPlayer();          
                         return DisplayPreviousPosition();
                    }
                else
                       return DisplayCurrenPosition();

                }

            }
            else
            {
                Console.WriteLine("Game over!");
                return "Game over!";
            }
        }

        private void StepForward()
        {
            int overcomeStep = CurrentPlayer.CurrentPosition - Player.WINPOSITION;
            CurrentPlayer.CurrentPosition = Player.WINPOSITION - overcomeStep;
            if (laddersArray.Contains(CurrentPlayer.CurrentPosition))
                LadderUp();
            if (snakesArray.Contains(CurrentPlayer.CurrentPosition))
                SnakeDowxn();
        }



        private void SnakeDowxn()
        {
            switch (CurrentPlayer.CurrentPosition)
            {
                case (16):
                    CurrentPlayer.CurrentPosition = 6; break;
                case (46):
                    CurrentPlayer.CurrentPosition = 25; break;
                case (49):
                    CurrentPlayer.CurrentPosition = 11; break;
                case (62):
                    CurrentPlayer.CurrentPosition = 19; break;
                case (64):
                    CurrentPlayer.CurrentPosition = 60; break;
                case (74):
                    CurrentPlayer.CurrentPosition = 53; break;
                case (89):
                    CurrentPlayer.CurrentPosition = 68; break;
                case (92):
                    CurrentPlayer.CurrentPosition = 88; break;
                case (95):
                    CurrentPlayer.CurrentPosition = 75; break;
                case (99):
                    CurrentPlayer.CurrentPosition = 80; break;

                default:
                    break;
            }
        }

        private void LadderUp()
        {
            switch (CurrentPlayer.CurrentPosition)
            {
                case (2):
                    CurrentPlayer.CurrentPosition = 38; break;
                case (7):
                    CurrentPlayer.CurrentPosition = 14; break;
                case (8):
                    CurrentPlayer.CurrentPosition = 31; break;
                case (15):
                    CurrentPlayer.CurrentPosition = 26; break;
                case (21):
                    CurrentPlayer.CurrentPosition = 42; break;
                case (28):
                    CurrentPlayer.CurrentPosition = 84; break;
                case (36):
                    CurrentPlayer.CurrentPosition = 44; break;
                case (51):
                    CurrentPlayer.CurrentPosition = 67; break;
                case (71):
                    CurrentPlayer.CurrentPosition = 91; break;
                case (78):
                    CurrentPlayer.CurrentPosition = 98; break;
                case (87):
                    CurrentPlayer.CurrentPosition = 94; break;
                default:
                    break;
            }
        }

        private string DisplayCurrenPosition()
        {
            Console.WriteLine(CurrentPlayer.Name + " is on square " + CurrentPlayer.CurrentPosition);
            return CurrentPlayer.Name + " is on square " + CurrentPlayer.CurrentPosition;
        }
        private string DisplayPreviousPosition()
        {
            Console.WriteLine(PreviousPlayer.Name + " is on square " + PreviousPlayer.CurrentPosition);
            return PreviousPlayer.Name + " is on square " + PreviousPlayer.CurrentPosition;
        }
        private void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == player1)
            {
                CurrentPlayer = player2;
                PreviousPlayer = player1;
            }
                
            else
            {
                CurrentPlayer = player1;
                PreviousPlayer = player2;
            }
                
        }
        
    }
}
