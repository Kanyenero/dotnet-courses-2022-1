using IConvertible = CodeTranslatorInterfaces.IConvertible;

namespace CodeTranslatorClasses
{
    public class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string input)
        {
            return "Some CSharp code...";
        }

        public string ConvertToVB(string input)
        {
            return "Some VB code...";
        }
    }
}
