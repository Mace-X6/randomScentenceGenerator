using System;

namespace csharpProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            var MeshScentence = new MeshSentence();
            int lineAmount = GetLineAmount();
            for (int i = 0; i < lineAmount; i++)
            {
                MeshScentence.GenerateSentence(true);
            }
        }

        static int GetLineAmount()
        {
            Console.WriteLine("How many sentences do you want? (must be an integer)");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
