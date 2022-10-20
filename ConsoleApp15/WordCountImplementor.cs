using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    internal class WordCountImplementor
    {
        public int CountWords(string phrase)
        {
            return phrase.Split().Length;
        }

        public int CountWordsFindWordFromStart(string phrase, string wordToFind)
        {
            return phrase.Split().ToList().FindIndex(x => x == wordToFind);
        }

        public int CountWordsFindWordFromEnd(string phrase, string wordToFind)
        {
            return phrase.Split().Length - phrase.Split().ToList().FindIndex(x => x == wordToFind);
        }
    }
}
