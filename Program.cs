using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            var MeshSentence = new MeshSentence();
            int lineAmount = GetLineAmount();
            for (int i = 0; i < lineAmount; i++)
            {
                string sentence = MeshSentence.GenerateSentence(true);
                Console.WriteLine(sentence);
            //    this.output.????(sentence);
            }
            
        }

        static int GetLineAmount()
        {
            Console.WriteLine("How many sentences do you want? (must be an integer)");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
