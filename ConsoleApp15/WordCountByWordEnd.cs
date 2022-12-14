using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    internal class WordCountByWordEnd : IWordCountStrategy
    {
        public int Count(string phrase, string word)
        {
            return phrase.Split().Length - phrase.Split().ToList().FindIndex(x => x == word);
        }
    }
}
