using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "The quick brown fox jumps over the lazy dog";
            string word = "brown";
            
            WordCountStrategy countStrategy1 = new WordCountStrategy();
            countStrategy1.WordCountOptions = WordCountOptions.ALL;
            Console.WriteLine(countStrategy1.Implement(phrase, word));

            Console.WriteLine(countStrategy1.Implement(new WordCountConditions(phrase, word, WordCountOptions.CLASSCONDITION)));

            //countStrategy1.SetStrategy(new WordCountAll());
            //Console.WriteLine(countStrategy1.Implement(phrase,word));
            
            //countStrategy1.SetStrategy(new WordCountByWordStart());
            //Console.WriteLine(countStrategy1.Implement(phrase,word));
            
            //countStrategy1.SetStrategy(new WordCountByWordEnd());
            //Console.WriteLine(countStrategy1.Implement(phrase,word));
        }


    }
}
