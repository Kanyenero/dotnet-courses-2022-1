using System.Reflection;

namespace UserInterface
{
    internal class Program
    {

        //
        // Разбор консольной команды простейший и не учитывает случаев типа:
        // > sc.exe  -arg1 param1 param2  -arg2 param3 param4 ... и т.д., и т.п.
        //
        // Производится разбор только лишь таких команд:
        // > sc.exe  -arg param1 param2 ... paramN
        //
        //
        // Все-таки здесь задание больше на работу с БД :)
        //


        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No args provided!");
                return;
            }

            bool commandValidated;
            string commandTemplate;
            string command = args[0];

            switch (command)
            {
                case "-init":
                    commandTemplate = "sc -init";

                    commandValidated = TryValidateCommand(
                        command, 
                        args.Skip(1).ToArray(), 
                        null);

                    if (!commandValidated)
                    {
                        Console.WriteLine("Use this template: {0}", commandTemplate);
                        break;
                    }

                    break;


                case "-lecture":
                    commandTemplate = "sc -lecture lecture_date topic_name" +
                        "\nwhere" +
                        "\n\tlecture_date - yyyy.mm.dd" +
                        "\n\ttopic_name - string";

                    commandValidated = TryValidateCommand(
                        command, 
                        args.Skip(1).ToArray(), 
                        new Type[] { typeof(DateTime), typeof(string) });

                    if (!commandValidated)
                    {
                        Console.WriteLine("Use this template: {0}", commandTemplate);
                        break;
                    }

                    break;


                case "-student":
                    commandTemplate = "sc -student student_name" +
                        "\nwhere" +
                        "\n\tstudent_name - string";

                    commandValidated = TryValidateCommand(
                        command, 
                        args.Skip(1).ToArray(), 
                        new Type[] { typeof(string) });

                    if (!commandValidated)
                    {
                        Console.WriteLine("Use this template: {0}", commandTemplate);
                        break;
                    }

                    break;


                case "-attend":
                    commandTemplate = "sc -attend student_name lecture_date mark" +
                        "\nwhere" +
                        "\n\tstudent_name - string" +
                        "\n\tlecture_date = yyyy.mm.dd" +
                        "\n\tmark - integer number";

                    commandValidated = TryValidateCommand(
                        command,
                        args.Skip(1).ToArray(),
                        new Type[] { typeof(string), typeof(DateTime), typeof(int) });

                    if (!commandValidated)
                    {
                        Console.WriteLine("Use this template: {0}", commandTemplate);
                        break;
                    }

                    break;


                case "-report":
                    commandTemplate = "sc -report";

                    commandValidated = TryValidateCommand(
                        command,
                        args.Skip(1).ToArray(),
                        null);

                    if (!commandValidated)
                    {
                        Console.WriteLine("Use this template: {0}", commandTemplate);
                        break;
                    }

                    break;


                default:
                    Console.WriteLine("Unknown command!\nAvailable commands: -init, -lecture, -student, -attend, -report");
                    break;
            }
        }

        private static bool TryValidateCommand(string name, string[] parameters, Type[]? expectedParameters)
        {
            bool parametersValidated;

            parametersValidated = TryValidateCount(expectedParameters, parameters);
            
            if (!parametersValidated)
            {
                Console.WriteLine("There is no '{0}' command with the given number of arguments!", name);
                return false;
            }

            if (expectedParameters == null)
                return true;

            parametersValidated = TryValidateTypes(expectedParameters, parameters);

            if (!parametersValidated)
            {
                Console.WriteLine("Arguments provided to the command '{0}' were incorrect!", name);
                return false;
            }

            return true;
        }

        private static bool TryValidateCount(Type[]? expected, string[] actual)
        {
            int expectedCount = (expected == null) 
                ? 0 
                : expected.Length;

            int actualCount = (actual == null)
                ? 0 
                : actual.Length;

            return actualCount == expectedCount;
        }

        private static bool TryValidateTypes(Type[]? expected, string[] actual)
        {
            if (actual == null || expected == null)
                return false;

            var actualAndExpected = expected.Zip(actual, (e, a) => new { Expected = e, Actual = a });

            foreach (var ea in actualAndExpected)
            {
                if (ea.Expected is string)
                    continue;

                bool invokedWithSuccess = InvokeTryParse(ea.Expected, ea.Actual);

                if (!invokedWithSuccess)
                    return false;
            }

            return true;
        }

        private static bool InvokeTryParse(Type onType, string withArgument)
        {
            var method = onType.GetMethod(
                "TryParse",
                BindingFlags.Static | BindingFlags.Public,
                null,
                new Type[] { typeof(string), onType.MakeByRefType() },
                null);

            if (method == null)
                return false;

            return (bool)method.Invoke(null, new object[] { withArgument, null });
        }
    }
}
