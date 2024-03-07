namespace BackEnd.Extensions;

public static class DateTimeExtensions
{
    public static bool Equal (this DateTime actual, DateTime? excepted)
    {
        return excepted.HasValue && Equal(actual, excepted.Value);
    }

    public static bool Equal (this DateTime actual, DateTime excepted)
    {
        return actual == excepted;
    }
}
