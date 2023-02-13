using System.Diagnostics.CodeAnalysis;
using static System.Console;

namespace iCodeNext.Net7;

internal class StringSyntaxHelper
{
    public StringSyntaxHelper()
    {
        GetAllList("");
        GetAllListByDate("yy-MM-dd");
    }





    public static void GetAllList([StringSyntax(StringSyntaxAttribute.Regex)] string param)
       => WriteLine(param);
    public static void GetAllListByDate([StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string date)
     => WriteLine(date);
}
