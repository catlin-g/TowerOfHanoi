using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
	public class ToHGame
	{
		// Field Data
		private readonly int numOfDisks;
		private static readonly List<Rod> rods = new List<Rod>();
		private const int NumOfRods = 3;

		// Constructors
		public ToHGame(int numOfDisks)
		{
			this.numOfDisks = numOfDisks;
			InitialiseGame();
		}

		// Methods
		private void InitialiseGame()
		{
			rods.Add(new Rod("A", numOfDisks));
			rods.Add(new Rod("B", numOfDisks));
			rods.Add(new Rod("C", numOfDisks));

			for (var diskSize = numOfDisks; diskSize > 0; diskSize--)
			{
				rods.ElementAt(0).rod.Push(new Disk(diskSize, AssignColour()));
			}
		}

		private static string AssignColour() => "White";

		public void DrawToH()
		{
			var incre = 0;

			for (var row = numOfDisks; row > 0; row--)
			{
				for (var rod = 0; rod < NumOfRods; rod++)
				{
					var disks = rods[rod].rod.Count;
					var empty = numOfDisks - disks;

					for (var left = numOfDisks - 1; left >= 0; left--)
					{
						if (left < empty)
						{
							Console.Write(".");
						}
						else
						{
							Console.Write(rods[rod].rod.ElementAt(incre).Size > left ? rods[rod].rod.ElementAt(incre).Size : ".");
						}
					}

					Console.Write("|");

					for (var right = 0; right < numOfDisks; right++)
					{
						if (right < empty)
						{
							Console.Write(".");
						}
						else
						{
							Console.Write(rods[rod].rod.ElementAt(incre).Size > right ? rods[rod].rod.ElementAt(incre).Size : ".");
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