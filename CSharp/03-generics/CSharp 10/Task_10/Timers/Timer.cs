namespace Task_10.Timers
{
    public delegate void TimerTickHandler(object sender, TimerTickEventArgs args);

    public class Timer
    {
        private readonly string _timerName;
        private readonly int _timerInitialValue;

        public event TimerTickHandler CountdownStared;
        public event TimerTickHandler CountdownFinished;
        public event TimerTickHandler NSecondsRemaining;

        public string Name
        {
            get { return _timerName; }
        }

        public Timer(string timerName, int timerInitialValue)
        {
            CheckForNull(timerName, timerName.GetType(), nameof(timerName));
            CheckForNegativeOrZero(timerInitialValue, nameof(timerInitialValue));

            _timerName = timerName;
            _timerInitialValue = timerInitialValue;
        }


        public void Run()
        {
            CountdownStared?.Invoke(this, new TimerTickEventArgs(_timerName, _timerInitialValue));

            int timerValue = _timerInitialValue;

            while (timerValue != 0)
            {
                NSecondsRemaining?.Invoke(this, new TimerTickEventArgs(_timerName, timerValue));

                Thread.Sleep(1000);

                timerValue -= 1;
            }

            NSecondsRemaining?.Invoke(this, new TimerTickEventArgs(_timerName, 0));
            CountdownFinished?.Invoke(this, new TimerTickEventArgs(_timerName));
        }


        private static void CheckForNull(object obj, Type type, string name)
        {
            if (obj == null) throw new NullReferenceException($"Object '{name}' [{type}] was null.");
        }
        private static void CheckForNegativeOrZero(double number, string name)
        {
            if (number <= 0) throw new ArgumentOutOfRangeException($"Parameter {name} cannot be less or equal Zero.");
        }
    }


    public class TimerTickEventArgs : EventArgs
    {
        private readonly string _timerName;
        private readonly int _secondsRemaining;

        public string TimerName => _timerName;
        public int SecondsRemaining => _secondsRemaining;

        public TimerTickEventArgs(string timerName)
        {
            _timerName = timerName;
        }
        public TimerTickEventArgs(string timerName, int secondsRemaining) : this(timerName)
        {
            _secondsRemaining = secondsRemaining;
        }
    }
}
