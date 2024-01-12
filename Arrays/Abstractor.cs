using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace csharpinterviewprep.Arrays;

public abstract class Abstractor
{
    public static T? FindFirst<T>(T[] item, Expression<Func<T, bool>> match){
        if (item == null || match == null)
            return default(T);
        return item.FirstOrDefault(match.Compile());
    }

    public static T[] FindAll<T>(T[]? item, Func<T, bool> match)
    {
        if (item == null || match == null)
            return Array.Empty<T>();
        return item.Where(match).ToArray();
    }

    public abstract string GetName([CallerMemberName] string name ="");
}


public class AbstractImpl : Abstractor
{
    public override string GetName([CallerMemberName] string name = "")
    {
        if (string.IsNullOrWhiteSpace(name))
            return name;
        return name;
    }
}