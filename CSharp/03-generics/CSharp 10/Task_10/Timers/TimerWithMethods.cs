namespace Task_10.Timers
{
    public class TimerWithMethods : ICountDownNotifier
    {
        private readonly Timer _timer;

        private readonly TimerTickHandler _OnCountdownStarted;
        private readonly TimerTickHandler _OnCountdownFinished;

        public TimerWithMethods(Timer timer, TimerTickHandler OnCountdownStared, TimerTickHandler OnCountdownFinished)
        {
            _timer = timer;

            _OnCountdownStarted = OnCountdownStared;
            _OnCountdownFinished = OnCountdownFinished;
        }

        public void Init()
        {
            _timer.CountdownStared += _OnCountdownStarted;
            _timer.NSecondsRemaining += OnNSecondsRemaining;
            _timer.CountdownFinished += _OnCountdownFinished;
        }

        public void Run()
        {
            _timer.Run();
        }

        public void Unsubscribe()
        {
            _timer.CountdownStared -= _OnCountdownStarted;
            _timer.NSecondsRemaining -= OnNSecondsRemaining;
            _timer.CountdownFinished -= _OnCountdownFinished;
        }

        private void OnNSecondsRemaining(object sender, TimerTickEventArgs args)
        {
            Console.WriteLine("[{0}]:Timer: Task {1}: {2} seconds remaining.", DateTime.Now.Second, args.TimerName, args.SecondsRemaining);
        }
    }
}
