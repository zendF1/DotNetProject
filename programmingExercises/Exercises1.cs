using System;
namespace programmingExercises
{
	public class Exercises1
	{
		// do something
		
		public void Test()
		{
			Console.WriteLine("Bài 20: Liệt kê tất cả các ước số của số nguyên dương n");
			int n = 12;
            for (int i = 1; i <= n; i++)
            {
                int a = n % i;
                if (a == 0)
                {
                    Console.WriteLine(i);
                }
            }
		}
	}
}

