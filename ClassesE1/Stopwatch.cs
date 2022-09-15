namespace ClassesE1
{
    public class Stopwatch
    {
        // Properties and Fields
        private static bool _timerOn = false;
        private static DateTime _startTime;
        private static DateTime _stopTime;


        public static void Start()
        {
            if(_timerOn)
            {
                throw new InvalidOperationException("Stopwatch has already started");
            }

            _timerOn = true;
            _startTime = DateTime.Now;
        }

        public static TimeSpan Stop()
        {
            if(_timerOn == false)
            {
                throw new InvalidOperationException("Stopwatch has not started");
            }

            _timerOn = false;
            _stopTime = DateTime.Now;

            return _stopTime - _startTime;
        }

    }
}