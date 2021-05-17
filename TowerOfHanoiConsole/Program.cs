using TowerOfHanoi;

namespace TowerOfHanoiConsole
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var towerOfHanoi1 = new ToHGame(7);
			var drawGame1 = new DrawToH();
			drawGame1.Draw(towerOfHanoi1);
		}
	}
}