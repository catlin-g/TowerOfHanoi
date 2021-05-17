using System;
using System.Collections.Generic;
using TowerOfHanoi;

namespace TowerOfHanoiConsole
{
	internal class DrawToH
	{
		private readonly List<string[,]> listOfRods = new();

		public void ToArrayOfRods(ToHGame toHGame)
		{
			var towerHeight = toHGame.TowerHeight;
			var rodsPerRow = 1;
			var baseSize = 1;

			foreach (var rod in toHGame.Rods)
			{
				var rodArray = rod.RodToArray();
				var tempArray = new string[towerHeight + baseSize, (towerHeight * 2) + rodsPerRow];

				for (var row = 0; row < towerHeight + baseSize; row++)
				{
					for (var col = 0; col < (towerHeight * 2) + rodsPerRow; col++)
					{
						if (col == towerHeight && row != towerHeight)
						{
							tempArray[row, col] = "|";
						}
						else if (row == towerHeight)
						{
							tempArray[row, col] = col == towerHeight ? rod.Name : "=";
						}
						else
						{
							var colFlag = (col >= towerHeight - rodArray[row]) && (towerHeight + rodArray[row] >= col);
							tempArray[row, col] = colFlag ? Convert.ToString(rodArray[row]) : "-";
						}
					}
				}

				listOfRods.Add(tempArray);
			}
		}

		public void Draw(ToHGame toHGame)
		{
			ToArrayOfRods(toHGame);

			for (var row = 0; row < toHGame.TowerHeight + 1; row++)
			{
				foreach (var rod in listOfRods)
				{
					for (var col = 0; col < rod.GetLength(1); col++)
					{
						Console.Write(rod[row, col]);
					}
					Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}