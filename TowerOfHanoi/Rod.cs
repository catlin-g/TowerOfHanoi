using System.Collections.Generic;

namespace TowerOfHanoi
{
	internal class Rod
	{
		// Field Data
		private readonly string name;

		private readonly int rodSize;
		private int emptySpace;

		//private bool isEmpty;
		private int numOfDisks;
		public Stack<Disk> rod;

		// Properties
		public int EmptySpace
		{
			get => emptySpace;
			set => emptySpace = rodSize - rod.Count;
		}

		public int NumberOfDisks
		{
			get => numOfDisks;
			set => numOfDisks = rod.Count;
		}

		// Constructors
		public Rod(string name, int numOfDisks)
		{
			rod = new Stack<Disk>();
			this.name = name;
			rodSize = numOfDisks;
		}

		// Methods
	}
}