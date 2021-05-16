using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
	public class ToHGame
	{
		private readonly List<Rod> rods = new();
		public List<Rod> Rods => rods;
		public int TowerHeight { get; }

		private const int NumOfRods = 3;
		public static int NumberOfRods => NumOfRods;

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

			for (var numOfDisks = 0; numOfDisks < TowerHeight; numOfDisks++)
			{
				rods.First().Push(new Disk(TowerHeight - numOfDisks, AssignColour()));
			}
		}

		private string AssignColour() => "White";




	}
}