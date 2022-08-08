namespace Steroids.Strings;

public static class StringExtensions
{
    public static string WithUppercaseFirstChar(this string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;

        if (!char.IsUpper(s[0]))
            return s;
        return char.ToLower(s[0]) + s.Substring(1);
    } 
    
    public static string ToCamelCase(this string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;
        var parts = s.Split(' ');
        var result = "";
        foreach (var part in parts)
        {
            result += part.WithUppercaseFirstChar() + " ";
        }
        return result.Trim();
    } 
    
    public static string ToPascalCase(this string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;
        var parts = s.Split(' ');
        var result = "";
        foreach (var part in parts)
        {
            result += part.WithUppercaseFirstChar() + " ";
        }
        return result.Trim();
    }
}