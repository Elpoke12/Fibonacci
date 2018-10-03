using System;

namespace Fibo2
{
    class Program
	{
		public static int Fibonacci(int n)
		{
			int a = 0;
			int b = 1;
			for (int i = 0; i < n; i++)
			{
				int temp = a;
				a = b;
				b = temp + b;
			}
			return a;
		}

		static void Main()
		{
            int op = 0;
            Console.Write("Ingrese un numero: ");
            for (int i = 0; i < op; i++)
			{
                Console.WriteLine(Fibonacci(op));

			}
			Console.ReadKey();
		}
    }
}
