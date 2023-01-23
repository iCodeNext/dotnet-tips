using System.Diagnostics.CodeAnalysis;

namespace iCodeNext.Net7;

internal class StringSyntaxHelper
{
    public StringSyntaxHelper()
    {
        GetAllList("");
        GetAllListByDate("yyyy");
    }

    public static void GetAllList([StringSyntax(StringSyntaxAttribute.Regex)] string param)
    {

    }
    public static void GetAllListByDate([StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string date)
    {

    }
}
