namespace DotNetCourse.Utils.Validation
{
    public static class NullHandler
    {
        #region Extensions

        public static void ThrowOnNull<T>(this T parameter, string parameterName)
            where T : class
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName);
        }

        public static void ThrowOnNull<T>(this T parameter, string parameterName, string message)
            where T : class
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName, message);
        }

        public static void ThrowOnNull<T>(this T? parameter, string parameterName)
            where T : struct
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName);
        }

        public static void ThrowOnNull<T>(this T? parameter, string parameterName, string message)
            where T : struct
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName, message);
        }

        public static void ThrowOnNullOrWhiteSpace(this string parameter, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameter))
                throw new ArgumentNullException(parameterName);
        }

        public static void ThrowOnNullOrWhiteSpace(this string parameter, string parameterName, string message)
        {
            if (string.IsNullOrWhiteSpace(parameter))
                throw new ArgumentNullException(parameterName, message);
        }

        public static bool IsNull<T>(this T argument)
            where T : class
        {
            if (argument == null)
                return true;

            return false;
        }

        public static bool IsNull<T>(this T? argument)
            where T : struct
        {
            if (argument == null)
                return true;

            return false;
        }

        public static void OnNull<T>(this T argument, Action action)
            where T : class
        {
            if (argument == null)
                action.Invoke();
        }

        public static void OnNull<T>(this T? argument, Action action)
            where T : struct
        {
            if (argument == null)
                action.Invoke();
        }

        #endregion



        #region Arguments

        public static void ThrowOnArgumentNull<T>(T argument, string argumentName)
            where T : class
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void ThrowOnArgumentNull<T>(T argument, string argumentName, string message)
            where T : class
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName, message);
        }

        public static void ThrowOnArgumentNull<T>(T? argument, string argumentName)
            where T : struct
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void ThrowOnArgumentNull<T>(T? argument, string argumentName, string message)
            where T : struct
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName, message);
        }

        public static void ThrowOnArgumentNullOrWhiteSpace(string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentNullException(argumentName);
        }

        public static void ThrowOnArgumentNullOrWhiteSpace(string argument, string argumentName, string message)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentNullException(argumentName, message);
        }

        public static bool IsArgumentNull<T>(T argument)
            where T : class
        {
            if (argument == null)
                return true;

            return false;
        }

        public static bool IsArgumentNull<T>(T? argument)
            where T : struct
        {
            if (argument == null)
                return true;

            return false;
        }

        public static void OnArgumentNull<T>(T argument, Action action)
            where T : class
        {
            if (argument == null)
                action.Invoke();
        }

        public static void OnArgumentNull<T>(T? argument, Action action)
            where T : struct
        {
            if (argument == null)
                action.Invoke();
        }

        #endregion
    }
}