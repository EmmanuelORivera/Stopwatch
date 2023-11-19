using System;
namespace Stopwatch
{
	public static class Stopwatch
	{
		static private DateTime _startTime;
		static private bool _started = false;
		static public void Start()
		{
			if (_started) throw new InvalidOperationException("Stopwatch started twice");

			if (_startTime == DateTime.MinValue)
			{
				_startTime = DateTime.Now;
                Console.WriteLine("Stopwatch Started At: {0}",TimeSpan.Zero);
            }
			else
			{
                Console.WriteLine("Stopwatch Resumed At: {0}", GetElapsedTime());
            }
				
			_started = true;
		}

		public static TimeSpan GetElapsedTime()
		{
			return DateTime.Now - _startTime;
		}

		static public TimeSpan Stop()
		{
			_started = false;

			return GetElapsedTime();
		}
	}
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