using System.Collections.Generic;

namespace TowerOfHanoi
{
	internal class Rod : Stack<Disk>
	{
		// Field Data
		private readonly string name;

		private readonly int rodSize;
		private int emptySpace;

		//private bool isEmpty;
		private int numOfDisks;

		// Properties
		public int EmptySpace
		{
			get => emptySpace;
			set => emptySpace = rodSize - Count;
		}

		public int NumberOfDisks
		{
			get => numOfDisks;
			set => numOfDisks = Count;
		}

		// Constructors
		public Rod(string name, int numOfDisks)
		{
			this.name = name;
			rodSize = numOfDisks;
		}

		// Methods
	}
}