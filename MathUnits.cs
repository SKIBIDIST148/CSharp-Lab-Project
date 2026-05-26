namespace CSharpLab
{
	class Program
	{
		static void Main()
		{
			MathUnits mathUnits(0, 2);
			global::System.Console.WriteLine(mathUnits.Plus());
		}
	}

	public class MathUnits
	{
		public int x;
		public int y;

		MathUnits(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public void Plus()
		{
			return x + y;
		}
	}	
}