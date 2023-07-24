using System;
namespace programmingExercises
{
	public class Exercises2
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 21: Tính tổng các ước số của số nguyên dương n");
			int n = 12;
            int b = 0;
            int a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                { 
                    b = b + i;
                }
            }
            Console.WriteLine(b);
		}
	}
}

