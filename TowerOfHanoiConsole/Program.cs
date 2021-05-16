using TowerOfHanoi;

namespace TowerOfHanoiConsole
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var towerOfHanoi = new ToHGame(4);

			var drawToH = new DrawToH();
			drawToH.Draw(towerOfHanoi);
		}
	}
}