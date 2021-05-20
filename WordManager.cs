using System;
using System.IO;
namespace csharpProject3
{
    public class WordManager
    {
        private string subjectVerb;

        public string RndAdverb()
        {
            var Rnd = new Random();
            string[] adverbArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\adv");
            string adverb = adverbArray[Rnd.Next(adverbArray.Length)];
            return adverb;
        }
        //=========================================================================================================================================================================
        public string RndAdjective()
        {
            var Rnd = new Random();
            string[] adjectiveArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\adj");
            string adjective = adjectiveArray[Rnd.Next(adjectiveArray.Length)];
            return adjective;
        }
        //=========================================================================================================================================================================        
        public string RndSubjectVerbObject()
        {
            var Rnd = new Random();
            if (Rnd.Next(2) == 0)
            {
                string[] singularObjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\singlenoun");
                string singularObject = singularObjectArray[Rnd.Next(singularObjectArray.Length)];
                return $"{this.RndSubjectVerb(false, false)} the {singularObject}";
            }
            else
            {
                string[] multipleObjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\pluralnoun");
                string multipleObject = multipleObjectArray[Rnd.Next(multipleObjectArray.Length)];
                return $"{this.RndSubjectVerb(false, false)} {multipleObject}";
            }
        }
        //=========================================================================================================================================================================
        public string RndSubjectVerb(bool beVerb, bool reverseForQuestion)
        {
            var Rnd = new Random();
            int randomNumber = Rnd.Next(15);
            if (0 <= randomNumber && 3 >= randomNumber)
            {
                string[] subjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\pronouns");
                string subject = subjectArray[Rnd.Next(subjectArray.Length)];

                string[] verbArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\verb");
                string verb = verbArray[Rnd.Next(verbArray.Length)];

                if (beVerb == true)
                {
                    if (subject == 'I'.ToString())
                    {
                        verb = "am";
                    }
                    else
                    {
                        verb = "are";
                    }
                }

                this.subjectVerb = $"{subject} {verb}";
                if (reverseForQuestion)
                {
                    this.subjectVerb = $"{verb} {subject}";
                }
            }
            if (4 <= randomNumber && 7 >= randomNumber)
            {
                string[] subjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\shitpronouns");
                string subject = subjectArray[Rnd.Next(subjectArray.Length)];

                string[] verbArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\verb");
                string verb = verbArray[Rnd.Next(verbArray.Length)];

                verb = this.ShitVerbConjugation(verb);

                if (beVerb == true)
                {
                    verb = "is";
                }

                this.subjectVerb = $"{subject} {verb}";
                if (reverseForQuestion)
                {
                    this.subjectVerb = $"{verb} {subject}";
                }
            }
            if (8 <= randomNumber && 9 >= randomNumber)
            {
                string[] subjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\singlenoun");
                string subject = subjectArray[Rnd.Next(subjectArray.Length)];

                string[] verbArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\verb");
                string verb = verbArray[Rnd.Next(verbArray.Length)];

                verb = this.ShitVerbConjugation(verb);

                if (beVerb == true)
                {
                    verb = "is";
                }

                this.subjectVerb = $"the {subject} {verb}";
                if (reverseForQuestion)
                {
                    this.subjectVerb = $"{verb} {subject}";
                }
            }
            if (10 <= randomNumber && 11 >= randomNumber)
            {
                string[] subjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\pluralnoun");
                string subject = subjectArray[Rnd.Next(subjectArray.Length)];

                string[] verbArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\verb");
                string verb = verbArray[Rnd.Next(verbArray.Length)];

                if (beVerb == true)
                {
                    verb = "are";
                }

                this.subjectVerb = $"the {subject} {verb}";
                if (reverseForQuestion)
                {
                    this.subjectVerb = $"{verb} {subject}";
                }
            }
            if (12 <= randomNumber && 14 >= randomNumber)
            {
                string[] subjectArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\names");
                string subject = subjectArray[Rnd.Next(subjectArray.Length)];

                string[] verbArray = File.ReadAllLines(@"C:\Users\mees\Documents\csharpProject3\words\verb");
                string verb = verbArray[Rnd.Next(verbArray.Length)];

                verb = this.ShitVerbConjugation(verb);

                if (beVerb == true)
                {
                    verb = "is";
                }

                this.subjectVerb = $"{subject} {verb}";
                if (reverseForQuestion)
                {
                    this.subjectVerb = $"{verb} {subject}";
                }
            }

            return this.subjectVerb;
        }
        //=========================================================================================================================================================================
        private string ShitVerbConjugation(string verb)
        {
            string verbCheck = $"{verb[verb.Length - 2]}{verb[verb.Length - 1]}";

            if (verbCheck == "ch" || verbCheck == "sh" || verbCheck[1] == 'o' || verbCheck[1] == 's' || verbCheck[1] == 'x')
            {
                verb = verb + "es";
            }
            if (verbCheck[0] == 'a' && verbCheck[1] == 'y' || verbCheck[0] == 'e' && verbCheck[1] == 'y' || verbCheck[0] == 'i' && verbCheck[1] == 'y' || verbCheck[0] == 'o' && verbCheck[1] == 'y' || verbCheck[0] == 'u' && verbCheck[1] == 'y')
            {
                verb = verb + 's';
            }
            if (verb == "have")
            {
                verb = "has";
            }
            else if (verbCheck[1] == 'y')
            {
                verb = verb.Substring(0, verb.Length - 1) + "ies";
            }
            else if (!verb.EndsWith('s'))
            {
                verb = verb + 's';
            }
            return verb;
        }
    }
}
// norm 1234 shit 5678 mult 910 sing 11 12