using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PigGame.Models
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public string CurrentPlayer { get; set; }

        public int Total { get; set; }
        public int DieRoll { get; set; }
        public bool IsGameOver { get; set; }

        public const int WinningNumber = 20;

        Random rand = new Random();

        public Game()
        {
            NewGame();
        }

        public void NewGame()
        {
            Player1 = new Player { Name = "Player 1" };
            Player2 = new Player { Name = "Player 2" };
            CurrentPlayer = Player1.Name;
            DieRoll = 0;
            Total = 0;
            IsGameOver = false;
        }

        public void Roll()
        {
            DieRoll = rand.Next(6) + 1;
            if (DieRoll == 1)
            {
                Total = 0;
                ChangePlayer();
            }
            else
            {
                Total += DieRoll;
            }
        }

        public void Hold()
        {
            Player playersRoll = (CurrentPlayer == Player1.Name) ? Player1 : Player2;

            playersRoll.Points += Total;
            if (playersRoll.Points >= WinningNumber)
            {
                IsGameOver = true;
            }
            else
            {
                Total = 0;
                DieRoll = 0;
                ChangePlayer();
            }
        }

        public void ChangePlayer()
        {
            CurrentPlayer = (CurrentPlayer == Player1.Name) ? Player2.Name : Player1.Name;
        }


    }
}
