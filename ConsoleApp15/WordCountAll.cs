using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class WordCountAll : IWordCountStrategy
    {
        public int Count(string phrase, string word)
        {
            return phrase.Split().Length;
        }
    }
}
