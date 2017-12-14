using System;
using System.Collections.Generic;


// Add new class to project
namespace CSharpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long sentence.";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);
        }

    }
}
