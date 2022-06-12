using CodeTranslatorClasses;
using IConvertible = CodeTranslatorInterfaces.IConvertible;
using ICodeChecker = CodeTranslatorInterfaces.ICodeChecker;

namespace CodeTranslatorUI
{
    internal partial class Program
    {
        private static void Main()
        {
            IConvertible[] items = new IConvertible[2] 
            { 
                new ProgramConverter(), 
                new ProgramHelper()
            };

            string codeToCheck = "Some CSharp code";

            foreach (var item in items)
            {
                string outputCode;

                if (item is ICodeChecker)
                {
                    Console.WriteLine($"Current item of type [{item.GetType()}] implements ICodeChecker");

                    var newItem = item as ProgramHelper;

                    if (newItem.CheckCodeSyntax(codeToCheck, "CSharp"))
                    {
                        outputCode = newItem.ConvertToCSharp(codeToCheck);
                    }
                    else
                    {
                        outputCode = newItem.ConvertToVB(codeToCheck);
                    }

                    Console.WriteLine($"Returned: [{outputCode}]");
                    continue;
                }

                Console.WriteLine($"Current item of type [{item.GetType()}] do not implement ICodeChecker");

                outputCode = item.ConvertToCSharp(codeToCheck);
                Console.WriteLine($"Returned: [{outputCode}]");

                outputCode = item.ConvertToVB(codeToCheck);
                Console.WriteLine($"Returned: [{outputCode}]");
            }
        }
    }
}
