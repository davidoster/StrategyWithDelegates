using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class WordCountConditions
    {
        public string Phrase { get; set; }

        public string Word { get; set; }

        public WordCountOptions Condition { get; set; }

        public WordCountConditions(string phrase, string word, WordCountOptions countOptions)
        {
            Phrase = phrase ?? throw new ArgumentNullException(nameof(phrase));
            Word = word ?? throw new ArgumentNullException(nameof(word));
            Condition = countOptions;
        }
    }
}
