using System.Collections.Generic;

namespace TowerOfHanoi
{
	internal class Rod
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

		public int EmptySpace => RodHeight - stack.Count;

		public void Push(Disk disk) => stack.Push(disk);

		public int Count => stack.Count;
	}
}