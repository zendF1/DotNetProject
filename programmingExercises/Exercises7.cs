using System;
namespace programmingExercises
{
	public class Exercises7
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 26: Tính tích tất cả các “ước số lẻ” của số nguyên dương n");
			int n = 12;
            int b = 1;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if (i % 2 != 0)
                    {
                        b = b * i;
                    }
                }
            }
            Console.WriteLine(b);
		}
	}
}

