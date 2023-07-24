using System;
namespace programmingExercises
{
	public class Exercises15
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn");
			int n = 12;
            double b = 0;
            for (int i = 1;i<=n;i++)
            {
                b = Math.Sqrt(i + Math.Sqrt(b));
            }
            Console.WriteLine(b);
		}
	}
}

