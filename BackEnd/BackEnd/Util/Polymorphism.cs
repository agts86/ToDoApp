using System.Reflection;

namespace BackEnd.Util;

public class Polymorphism
{
    public static T[] CreatePolymorphismArray<T>(object obj = null)
    {
        return Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => typeof(T).IsAssignableFrom(x) && !x.IsAbstract && !x.IsInterface)
            .Select(x => obj is null ? (T)Activator.CreateInstance(x) : (T)Activator.CreateInstance(x, obj))
            .ToArray();
    }
}
