using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
	public class ToHGame
	{
		public readonly List<Rod> rods = new();
		private const int NumOfRods = 3;

		public int TowerHeight{ get; }

		public ToHGame(int numOfDisks)
		{
			TowerHeight = numOfDisks;
			InitialiseGame();
		}

		private void InitialiseGame()
		{
			rods.Add(new Rod("A", TowerHeight));
			rods.Add(new Rod("B", TowerHeight));
			rods.Add(new Rod("C", TowerHeight));

			for (var numOfDisks = TowerHeight; numOfDisks > 0; numOfDisks--)
			{
				rods.First().stack.Push(new Disk(numOfDisks, AssignColour()));
			}
		}

		private static string AssignColour() => "White";
	}
}