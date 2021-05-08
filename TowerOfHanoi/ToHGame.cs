using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
	public class ToHGame
	{
		// Field Data
		private Rod rodA;

		private Rod rodB;
		private Rod rodC;
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
			rodA = new Rod("A", numOfDisks);
			rodB = new Rod("B", numOfDisks);
			rodC = new Rod("C", numOfDisks);

			for (var diskSize = numOfDisks; diskSize > 0; diskSize--)
			{
				rodA.Push(new Disk(diskSize, AssignColour()));
			}

			rods.Add(rodA);
			rods.Add(rodB);
			rods.Add(rodC);
		}

		private static string AssignColour() => "White";

		public void DrawToH()
		{
			var incre = 0;

			for (var row = numOfDisks; row > 0; row--)
			{
				for (var rod = 0; rod < NumOfRods; rod++)
				{
					var disks = rods[rod].Count;
					var empty = numOfDisks - disks;

					for (var left = numOfDisks - 1; left >= 0; left--)
					{
						if (left < empty)
						{
							Console.Write(".");
						}
						else
						{
							Console.Write(rods[rod].ElementAt(incre).Size > left ? rods[rod].ElementAt(incre).Size : ".");
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
							Console.Write(rods[rod].ElementAt(incre).Size > right ? rods[rod].ElementAt(incre).Size : ".");
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