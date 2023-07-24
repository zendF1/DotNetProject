using System;
namespace programmingExercises
{
	public class Exercises14
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn");
			int n = 2;
            double b = 0;
            for (int i = 1;i<=n;i++)
            {
                b = Math.Sqrt(2 + b);
            }
            Console.WriteLine(b);
		}
	}
}

