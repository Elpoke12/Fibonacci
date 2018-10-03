# Fibonacci
<3

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
			TimeSpan stop;
			TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            int op = 0;
            Console.Write("Ingrese un numero: ");
            op = int.Parse(Console.ReadLine());
            for (int i = 0; i < op; i++)
			{
                Console.WriteLine(Fibonacci(i));

			}
			Console.Write("Se completo en: ");
			stop = new TimeSpan(DateTime.Now.Ticks);
			Console.WriteLine(stop.Subtract(start).TotalSeconds);
			Console.ReadKey();
		}
    }
