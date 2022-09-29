using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityWebApplication.Util
{
    static class ObjectHelper
    {
        // Extension method that allows arbitrary classes to be converted to JSON strings
        public static string ToJsonString<T>(this T x)
        {
            string json = JsonSerializer.Serialize<T>(x, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            return json;
        }
    }
}