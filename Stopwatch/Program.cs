using System;
namespace Stopwatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				UseStopwatch();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}


		}

		static void UseStopwatch()
		{
			Console.WriteLine("Starting stopwatch");
			Stopwatch.Start();

			Thread.Sleep(5000);
			Console.WriteLine(Stopwatch.Stop());
			Stopwatch.Start();
			Thread.Sleep(2000);
			Console.WriteLine(Stopwatch.Stop());
		}
	}
}