using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    enum WordCountOptions
    {
        ALL,
        START,
        END,
        CLASSCONDITION
    }

    internal class WordCountStrategy
    {
        private delegate int count(string phrase, string word);

        private delegate int count2(WordCountConditions countConditions);

        public WordCountOptions WordCountOptions { get; set; }
        
        private int Implement1(string phrase, string word)
        {
            return phrase.Split().Length;
        }
        
        private  int Implement2(string phrase, string word)
        {
            return phrase.Split().ToList().FindIndex(x => x == word);
        }

        private int Implement3(string phrase, string word)
        {
            return phrase.Split().Length - phrase.Split().ToList().FindIndex(x => x == word);
        }

        private int Implement4(WordCountConditions countConditions)
        {
            WordCountOptions = countConditions.Condition;
            return Implement(countConditions.Phrase, countConditions.Word);
        }

        public int Implement(string phrase, string word)
        {
            count c = null;
            switch(WordCountOptions)
            {
                case WordCountOptions.START:
                    c = Implement1;
                    break;
                case WordCountOptions.END:
                    c = Implement2;
                    break;
                case WordCountOptions.ALL:
                case WordCountOptions.CLASSCONDITION:
                    c = Implement3;
                    break;
            }
            return c(phrase, word);
        }

        public int Implement(WordCountConditions countConditions)
        {
            count2 c2 = Implement4;
            return c2(countConditions);
        }
    }
}
