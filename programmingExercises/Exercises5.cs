using System;
namespace programmingExercises
{
	public class Exercises5
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 24: Liệt kê tất cả các ước số lẻ của số nguyên dương n");
			int n = 12;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if (i % 2 != 0)
                    {
                       Console.WriteLine(i);
                    }
                }
            }        
		}
	}
}

