namespace IAmAJavaScriptFan;

public static class Extensions
{
    extension(object?)
    {
        public static bool operator true(object? value)
        {
            return value is not null;
        }
        
        public static bool operator false(object? value)
        {
            return value is null;
        }
    }
}