﻿using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            //Board board = new Board();
            //board.DisplayBoard();
            // to let players choose their names:
            Console.WriteLine("please choose a name for player 1...");
            string p1UserInput = Console.ReadLine();

            Console.WriteLine("please choose a name for player 2...");
            string p2UserInput = Console.ReadLine();

            StartGame(p1UserInput, p2UserInput);


            // this is only to keep the app running, so that the players can see game results.
            Console.WriteLine("Enter anything to exit...");
            Console.ReadLine();
        }

        static void StartGame(string p1Name, string p2Name)
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            
            // creating new players (the first thing to do)
            Player p1 = new Player();
            Player p2 = new Player();

            // giving players attributes
            p1.Name = p1Name;
            p2.Name = p2Name;

            p1.Marker = "X";
            p2.Marker = "0";

            // new game
            Game game = new Game(p1 , p2);

            // start the game:
            game.Play();




        }
        

    }
}
