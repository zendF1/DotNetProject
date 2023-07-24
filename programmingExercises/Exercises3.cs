using System;
namespace programmingExercises
{
	public class Exercises3
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 22:Tính tích tất cả các ước số của số nguyên dương n");
			int n = 12;
            int b = 1;
            int a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    b = b * i;
                }
            }
            Console.WriteLine(b);
		}
	}
}

