using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
	public class Rod
	{
		public Stack<Disk> Stack { get; }

		public Rod(string name, int rodHeight)
		{
			Stack = new Stack<Disk>();
			Name = name;
			RodHeight = rodHeight;
		}

		public int[] RodToArray()
		{
			var arr = new int[RodHeight];
			var stackArray = Stack.ToArray();

			for(var i = 0; i < stackArray.Length; i++)
			{
				arr[EmptySpace + i] = stackArray[i].Size;
			}

			return arr;
		}

		public string Name { get; }

		public int RodHeight { get; }

		public int NumberOfDisks => numOfDisks = Stack.Count;
		private int numOfDisks;

		public int EmptySpace => RodHeight - Stack.Count;

		public void Push(Disk disk) => Stack.Push(disk);

		//public int Count() => NumberOfDisks;

		public int GetDiskSize(int index) => Stack.ElementAt(index).Size;
	}
}