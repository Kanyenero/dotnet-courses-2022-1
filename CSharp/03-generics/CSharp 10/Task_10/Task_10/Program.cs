using Task_10.Timers;
using Timer = Task_10.Timers.Timer;

namespace Task_10.TimerUI
{
    internal class Program
    {
        private static void Main()
        {
            var taskReadingTimer = new Timer("Reading", 1);
            var taskCompletionTimer = new Timer("Completion", 2);
            var taskCheckingTimer = new Timer("Checking", 5);

            var countDownNotifiers = new ICountDownNotifier[3];
            countDownNotifiers[0] = new TimerWithMethods(taskReadingTimer, OnCountdownStared, OnCountdownFinished);
            countDownNotifiers[1] = new TimerWithAnonymousDelegates(taskCompletionTimer, OnCountdownStared, OnCountdownFinished);
            countDownNotifiers[2] = new TimerWithLambda(taskCheckingTimer, OnCountdownStared, OnCountdownFinished);

            foreach(var notifier in countDownNotifiers)
            {
                notifier.Init();
                notifier.Run();
                notifier.Unsubscribe();
            }
        }

        private static void OnCountdownStared(object sender, TimerTickEventArgs args)
        {
            Console.WriteLine("[{0}]:Timer: Task {1} has started for {2} seconds.", DateTime.Now.Second, args.TimerName, args.SecondsRemaining);
        }
        private static void OnCountdownFinished(object sender, TimerTickEventArgs args)
        {
            Console.WriteLine("[{0}]:Timer: Task {1} has finished.", DateTime.Now.Second, args.TimerName);
        }
    }
}
