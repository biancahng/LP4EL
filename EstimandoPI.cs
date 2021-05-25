using System;

class EstimandoPI
{
	static void Main()
	{
		Random aleatorio = new Random();
		double n = 10000;
		double j = 0;
		double pi, x, y;

		// Proporção = área do círculo / área do quadrado
		// P = pi * r^2 / l^2

		for (int i = 0; i < n; i++)
		{
			x = aleatorio.NextDouble() * (1 - (-1)) + (-1);
			y = aleatorio.NextDouble() * (1 - (-1)) + (-1);

			if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
				j++;
		}

		pi = j / n * 4;

		Console.WriteLine("PI vale " + pi);
	}
}
