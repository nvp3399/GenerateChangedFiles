﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateChangedFiles
{
    public static class StringExtensionMethods
    {
        public static string EnsureEndsWith(this string str, string endWith) => str.EndsWith(endWith) ?  str: str + endWith;
        
    }
}
