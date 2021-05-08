namespace TowerOfHanoi
{
	internal class Disk
	{
		// Field Data
		private int size;

		private string colour;

		// Properties
		public int Size
		{
			get => size;
			set => size = value;
		}

		public string Colour
		{
			get => colour;
			set => colour = value;
		}

		// Constructors
		public Disk(int size, string colour)
		{
			this.size = size;
			this.colour = colour;
		}

		// Methods
	}
}