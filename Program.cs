using System;

namespace csharpProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineAmount = GetLineAmount();
            for (int i = 0; i < lineAmount; i++)
            {
                ChooseScentenceType();

            }
        }

        static int GetLineAmount()
        {
            Console.WriteLine("How many scentences do you want? (must be an integer)");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void ChooseScentenceType()
        {
            var Rnd = new Random();
            var MeshScentence = new MeshScentence();
            switch (Rnd.Next(5))
            {
                case 0:
                    Console.WriteLine(MeshScentence.GenerateScentence("subject_verb"));
                    break;
                case 1:
                    Console.WriteLine(MeshScentence.GenerateScentence("subject_verb_object"));
                    break;
                case 2:
                    Console.WriteLine(MeshScentence.GenerateScentence("subject_verb_adjective"));
                    break;
                case 3:
                    Console.WriteLine(MeshScentence.GenerateScentence("subject_verb_adverb"));
                    break;
                    case 4: 
                    Console.WriteLine(MeshScentence.GenerateScentence("question"));
                    break;
            }
            /* can be:
            subject_verb
            subject_verb_object
            subject_verb_adjective
            subject_verb_adverb
            subject_verb_noun */
        }
    }
}
