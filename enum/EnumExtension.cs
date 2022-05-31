using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Acme.Utils
{
    public static class EnumExtensions
    {
        // Note that we never need to expire these cache items, so we just use ConcurrentDictionary rather than MemoryCache
       public static string ToDescriptionString(this Enum val)
    {
        if (val == null)
        {
            return string.Empty;
        }

        var tt = val.GetType();
        var ty = tt.GetField(val.ToString());
        var da = ty?.GetCustomAttribute<DescriptionAttribute>();

        return da?.Description ?? val.ToString();
    }
    }
}