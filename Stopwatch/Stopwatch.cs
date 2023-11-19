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
}