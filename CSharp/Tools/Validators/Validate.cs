namespace Tools.Validation
{
    public static class Validate<T> where T : class
    {
        /// <summary>
        /// If input is null, throws an exception.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T NotNull(T? input, string inputName)
        {
            if (input == null)
            {
                throw new ArgumentNullException($"'{inputName}' was null");
            }

            return input;
        }

        /// <summary>
        /// If input is null or one of the elements is null, throws an exception.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T[] NotNull(T[] input, string inputName)
        {
            if (input == null)
            {
                throw new ArgumentNullException($"'{inputName}' was null");
            }

            for (int i = 0; i < input.Length; i++)
            {
                NotNull(input[i], $"{inputName}[{i}]");
            }
            
            return input;
        }
    }
}
