using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab04_TicTacToe.Classes
{
    class Position
    {
		public int Row { get; set; }
		public int Column { get; set; }

		/// <summary>
		/// Position on the gameboard being initialized 
		/// </summary>
		/// <param name="row">row number</param>
		/// <param name="column">column number</param>
		public Position(int row, int column)
		{
			Row = row;
			Column = column;
		}

		//public Position gitPosition(Board board)
		//{
		//	Position p = null;

		//	while (p is null)
		//	{
		//		Console.WriteLine("please select a position...");
		//		Int32.TryParse(Console.ReadLine(), out int position);
		//		p = PositionForNumber(position);
		//	}

		//	return p;
		//}


        



    }
}
