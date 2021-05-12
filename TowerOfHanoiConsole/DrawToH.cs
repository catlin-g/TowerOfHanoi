using System;
using System.Linq;
using TowerOfHanoi;

namespace TowerOfHanoiConsole
{
	class DrawToH
	{
		public static void Draw(ToHGame game)
		{
			var incre = 0;

			for (var row = game.TowerHeight; row > 0; row--)
			{
				for (var rod = 0; rod < game.TowerHeight - 1; rod++)
				{
					var disks = game.rods[rod].stack.Count;
					var empty = game.TowerHeight - disks;

					for (var left = game.TowerHeight - 1; left >= 0; left--)
					{
						if (left < empty)
						{
							Console.Write(".");
						}
						else
						{
							Console.Write(game.rods[rod].stack.ElementAt(incre).Size > left ? game.rods[rod].stack.ElementAt(incre).Size : ".");
						}
					}

					Console.Write("|");

					for (var right = 0; right < game.TowerHeight; right++)
					{
						if (right < empty)
						{
							Console.Write(".");
						}
						else
						{
							Console.Write(game.rods[rod].stack.ElementAt(incre).Size > right ? game.rods[rod].stack.ElementAt(incre).Size : ".");
						}
					}

					Console.Write(" ");
				}

				incre++;
				Console.WriteLine();
			}

			Console.WriteLine("====A=========B=========C====");
		}
	}
}
