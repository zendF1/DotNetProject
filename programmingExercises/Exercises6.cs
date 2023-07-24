using System;
namespace programmingExercises
{
	public class Exercises6
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n");
			int n = 12;
            int b = 0;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if (i % 2 == 0)
                    {
                        b = b + i;
                    }
                }
            }
            Console.WriteLine(b);
		}
	}
}

