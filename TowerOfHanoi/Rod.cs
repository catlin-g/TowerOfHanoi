using System.Collections.Generic;

namespace TowerOfHanoi
{
	public class Rod
	{
		private Stack<Disk> stack;
		public Rod(string name, int rodHeight)
		{
			stack = new Stack<Disk>();
			Name = name;
			RodHeight = rodHeight;
		}

		public string Name { get; }

		public int RodHeight { get; }

		public int NumberOfDisks => numOfDisks = stack.Count;
		private int numOfDisks;

		public int EmptySpace => RodHeight - stack.Count;

		public void Push(Disk disk) => stack.Push(disk);

		public int Count() => NumberOfDisks;
	}
}