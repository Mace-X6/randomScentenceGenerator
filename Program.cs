using System;

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
                Console.WriteLine(MeshSentence.GenerateSentence(true));
            }
        }

        static int GetLineAmount()
        {
            Console.WriteLine("How many sentences do you want? (must be an integer)");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
