namespace CodeTranslatorInterfaces
{
    public interface ICodeChecker
    {
        bool CheckCodeSyntax(string toCheck, string programmingLanguage);
    }
}
