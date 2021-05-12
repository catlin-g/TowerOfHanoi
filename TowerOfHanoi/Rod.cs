using System.Collections.Generic;

namespace TowerOfHanoi
{
	public class Rod
	{
		public Stack<Disk> stack;
		private int numOfDisks;
		private int emptySpace;

		public string Name { get; }

		public int NumberOfDisks
		{
			get => numOfDisks;
			set => numOfDisks = stack.Count;
		}

		public int EmptySpace
		{
			get => emptySpace;
			set => emptySpace = RodHeight - stack.Count;
		}

		public int RodHeight { get; }

		public Rod(string name, int rodHeight)
		{
			stack = new Stack<Disk>();
			Name = name;
			RodHeight = rodHeight;
		}
	}
}