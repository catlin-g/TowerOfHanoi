namespace TowerOfHanoi
{
	public class Disk
	{
		public int Size { get; set; }

		public string Colour { get; set; }

		public Disk(int size, string colour)
		{
			Size = size;
			Colour = colour;
		}
	}
}