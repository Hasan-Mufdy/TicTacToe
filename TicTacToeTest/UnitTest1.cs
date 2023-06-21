using System.Numerics;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        
        // test 1:

        [Fact]
        public void Check_GameBoard_ReturnsWinner()
        {
            Player playerOne = new Player { Name = "Player 1", Marker = "X" };
            Player playerTwo = new Player { Name = "Player 2", Marker = "O" };
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard = new string[,]
            {
                { "X", "O", "X" },
                { "O", "X", "O" },
                { "X", "O", "X" }
            };

            Player winner = game.Play();

            Assert.NotNull(winner);
            Assert.Equal(playerOne, winner);
        }

        // test 2:

        [Fact]
        public void CheckPlayerTurn_Player1_ReturnsPlayerTwo()
        {
            Player playerOne = new Player { Name = "Player 1", Marker = "X" };
            Player playerTwo = new Player { Name = "Player 2", Marker = "O" };
            Game game = new Game(playerOne, playerTwo);

            Player nextPlayer = game.NextPlayer();

            Assert.Equal(playerTwo, nextPlayer);
        }

        // test 3:

        [Fact]
        public void Check_PositionNumber_ReturnsCorrectPosition()
        {
            Position position = Player.PositionForNumber(5);

            Assert.NotNull(position);
            Assert.Equal(1, position.Row);
            Assert.Equal(1, position.Column);
        }


        [Fact]
        public void BoardIsFull_CheckDraw_ReturnsNull()
        {
            Player playerOne = new Player { Name = "Player 1", Marker = "X" };
            Player playerTwo = new Player { Name = "Player 2", Marker = "O" };
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard = new string[,]
            {
                { "X", "O", "X" },
                { "X", "O", "O" },
                { "O", "X", "X" }
            };

            Player winner = game.Play();

            // Assert.Null(winner);
            Assert.Equal(winner, null);
        }




    }
}