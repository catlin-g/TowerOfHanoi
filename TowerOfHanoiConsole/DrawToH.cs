using System;
using System.Linq;
using TowerOfHanoi;

namespace TowerOfHanoiConsole
{
	internal class DrawToH
	{
		public static void Draw(ToHGame game)
		{
			var incre = 0;

			for (var row = game.TowerHeight; row > 0; row--)
			{
				for (var rod = 0; rod < game.NumberOfRods; rod++)
				{
					var numOfDisks = game.rods[rod].stack.Count;
					var empty = game.TowerHeight - numOfDisks;

					for (var left = game.NumberOfRods; left >= 0; left--)
					{
						//var test = (row == numOfDisks) && (numOfDisks < game.TowerHeight);
						var test2 = row > (game.TowerHeight - empty);


						if (left < empty)
						{
							Console.Write(".");
						}
						else if (test2)
						{
							Console.Write("/");
						}
						else
						{
							var diskSize = game.rods[rod].stack.ElementAt(incre).Size;
							Console.Write(diskSize > left ? diskSize : ".");
						}
					}

					Console.Write("|");

					/*for (var right = 0; right < game.TowerHeight; right++)
					{
						if (right < empty)
						{
							Console.Write(".");
						}
						else
						{
							var diskSize = game.rods[rod].stack.ElementAt(incre).Size;
							Console.Write(diskSize > right ? diskSize : ".");
						}
					}*/

					Console.Write(" ");
				}
				Console.WriteLine();
				incre++;
			}

			Console.WriteLine("====A=========B=========C====");
		}
	}
}