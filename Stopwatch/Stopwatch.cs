namespace Stopwatch
{
	public static class Stopwatch
	{
		static private DateTime _startTime;
		static private bool _isRunning = false;
		static public void Start()
		{
			if (_isRunning) throw new InvalidOperationException("Stopwatch is already running");

			_startTime = DateTime.Now;
			_isRunning = true;

			Console.WriteLine("Stopwatch started at: "+ _startTime);
        }

		static public TimeSpan Stop()
		{
			if(!_isRunning) throw new InvalidOperationException("Stopwatch is not running");

			var endTime = DateTime.Now;
			_isRunning = false;
			var duration = endTime - _startTime;

            Console.WriteLine("Stopwatch stopped at: "+ endTime);
            Console.WriteLine("Duration: " + duration);
			return duration;
		}
	}
}