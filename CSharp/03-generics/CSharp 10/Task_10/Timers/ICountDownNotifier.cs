namespace Task_10.Timers
{
    public interface ICountDownNotifier
    {
        /// <summary>
        /// Подписывается на события таймера
        /// </summary>
        void Init();

        /// <summary>
        /// Запускает таймер
        /// </summary>
        void Run();

        /// <summary>
        /// Отписывается от событий таймера
        /// </summary>
        void Unsubscribe();
    }
}
