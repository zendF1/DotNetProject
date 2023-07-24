using System;
namespace programmingExercises
{
	public class Exercises10
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n.");
			int n = 12;
            int b = 0;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                if (i % 2 != 0)
                    {
                        if (i > b)
                        {
                            b = i;
                        }
                        
                    }
                }
            }
            Console.WriteLine(b);
		}
	}
}

