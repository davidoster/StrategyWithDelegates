using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal interface IWordCountStrategy
    {
        int Count(string phrase, string word); 
    }
}
