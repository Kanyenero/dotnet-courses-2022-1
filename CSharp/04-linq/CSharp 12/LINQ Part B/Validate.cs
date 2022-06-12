using System;

namespace LinqTasksReinvent
{
    public static class Validate<T>
    {
        public static void NotNull(T input, string inputName)
        {
            if (input == null)
            {
                throw new ArgumentNullException($"'{inputName}' was null.");
            }
        }
    }
}
