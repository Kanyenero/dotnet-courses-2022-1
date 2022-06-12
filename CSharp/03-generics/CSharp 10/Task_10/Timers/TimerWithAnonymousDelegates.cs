namespace Task_10.Timers
{
    public class TimerWithAnonymousDelegates : ICountDownNotifier
    {
        private readonly Timer _timer;

        private readonly TimerTickHandler _OnCountdownStared;
        private readonly TimerTickHandler _NSecondsRemaining;
        private readonly TimerTickHandler _CountdownFinished;

        public TimerWithAnonymousDelegates(Timer timer, TimerTickHandler OnCountdownStared, TimerTickHandler OnCountdownFinished)
        {
            _timer = timer;

            _OnCountdownStared = OnCountdownStared;
            _CountdownFinished = OnCountdownFinished;

            _NSecondsRemaining = delegate (object sender, TimerTickEventArgs args)
            {
                Console.WriteLine("[{0}]:Timer: Task {1}: {2} seconds remaining.", DateTime.Now.Second, args.TimerName, args.SecondsRemaining);
            };
        }

        public void Init()
        {
            _timer.CountdownStared += _OnCountdownStared;
            _timer.NSecondsRemaining += _NSecondsRemaining;
            _timer.CountdownFinished += _CountdownFinished;
        }

        public void Run()
        {
            _timer.Run();
        }

        public void Unsubscribe()
        {
            _timer.CountdownStared -= _OnCountdownStared;
            _timer.NSecondsRemaining -= _NSecondsRemaining;
            _timer.CountdownFinished -= _CountdownFinished;
        }
    }
}
