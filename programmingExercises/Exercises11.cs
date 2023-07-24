using System;
namespace programmingExercises
{
	public class Exercises11
	{
		// do something
		public void Test()
		{
            Console.WriteLine("Bài 30: Cho số nguyên dương n. Kiểm tra xem n có phải là số hoàn thiện hay không");
			int n = 12;
            int b = 0;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if ( i != n) {
                        b = b + i;
                    }
                }
            }
            if (b == n)
            {
                Console.WriteLine(n + " là số hoàn thiện");
            }
            else {
                Console.WriteLine(n + " không phải là số hoàn thiện");
            }
		}
	}
}

