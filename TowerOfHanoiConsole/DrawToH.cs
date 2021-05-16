using System;
using System.Collections.Generic;
using TowerOfHanoi;

namespace TowerOfHanoiConsole
{
	internal class DrawToH
	{
		private List<string[,]> rodArrays = new();

		public void GetRodsArray(ToHGame toHGame)
		{
			var towerHeight = toHGame.TowerHeight;
			var rodPerRow = 1;

			foreach (var rod in toHGame.Rods)
			{
				var rodArray = rod.RodToArray();
				var temp = new string[towerHeight, (towerHeight * 2) + rodPerRow];

				for (var row = 0; row < towerHeight; row++)
				{
					for (var col = 0; col < (towerHeight * 2) + rodPerRow; col++)
					{
						if (col == towerHeight)
						{
							temp[row, col] = "|";
						}
						else
						{
							temp[row, col] = (col >= towerHeight - rodArray[row]) && (towerHeight + rodArray[row] >= col) ? Convert.ToString(rodArray[row]) : "-";
						}
					}
				}

				rodArrays.Add(temp);
			}
		}

		public void Draw(ToHGame toHGame)
		{
			GetRodsArray(toHGame);

			for (var row = 0; row < toHGame.TowerHeight; row++)
			{
				foreach (var rod in rodArrays)
				{
					for (var col = 0; col < rod.GetLength(1); col++)
					{
						Console.Write(rod[row, col]);
					}
					Console.Write(" ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("====A=========B=========C====");
		}
	}
}