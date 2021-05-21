using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace csharpProject3
{
    class Program
    {
        string[] output;
        static void Main(string[] args)
        {
            var MeshSentence = new MeshSentence();
            int lineAmount = GetLineAmount();
            var ExportSentences = new ExportSentences();
            for (int i = 0; i < lineAmount; i++)
            {
                string sentence = MeshSentence.GenerateSentence(true);
                Console.WriteLine(sentence);
                if (args[0] == "true")
                {
                    ExportSentences.AddToExport(sentence);
                }
            }
            if (args[0] == "true")
            {
                ExportSentences.ExecuteExport();
            }
        }

        static int GetLineAmount()
        {
            Console.WriteLine("How many sentences do you want? (must be an integer)");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
