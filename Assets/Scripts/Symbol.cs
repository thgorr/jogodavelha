using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Symbol
{
    None,
    Cross,
    Circle
}
public static class SymbolExtensions
{
    public static Symbol GetOther(this Symbol symbol)
    {
        switch (symbol)
        {
            case Symbol.Cross: return Symbol.Circle;
            case Symbol.Circle: return Symbol.Cross;
            default: return Symbol.None;

        }
    }
    static void Example()
    {
        Symbol x = Symbol.Cross;

        // same as SymbolExtensions.GetOther(x)
        Symbol other1 = x.GetOther();
    }
}

