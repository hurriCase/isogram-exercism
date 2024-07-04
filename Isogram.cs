using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word) =>
        word.Count(symbol => symbol is ('-' or ' ')) 
        + word.ToLower().Distinct().Count(symbol => symbol is not ('-' or ' '))
        == word.Length;
}
