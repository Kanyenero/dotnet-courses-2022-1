namespace CodeTranslatorClasses
{
    public class ProgramHelper : ProgramConverter, CodeTranslatorInterfaces.ICodeChecker
    {
        public bool CheckCodeSyntax(string toCheck, string programmingLanguage)
        {
            if (programmingLanguage == "CSharp")
            {
                return CheckCodeSyntaxCSharp(toCheck);
            }

            if (programmingLanguage == "VB")
            {
                return CheckCodeSyntaxVB(toCheck);
            }

            return true;
        }

        // Методы-заглушки. Задание тривиальное, никаких преобразований выполнять не нужно

        private bool CheckCodeSyntaxCSharp(string toCheck)
        {
            if (toCheck == "Some CSharp code")
            {
                return true;
            }

            return false;
        }
        private bool CheckCodeSyntaxVB(string toCheck)
        {
            if (toCheck == "Some VB code")
            {
                return true;
            }

            return false;
        }
    }
}