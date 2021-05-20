using System;

namespace csharpProject3
{
    public class MeshSentence
    {
        private string sentence;
        public string GenerateSentence(bool includeCompound)
        {
            var WordManager = new WordManager();
            var Rnd = new Random();
            int randomness;
            if (includeCompound){
                randomness = 6;
            }
            else {
                randomness = 5;
            }
            switch (Rnd.Next(randomness))
            {
                case 0:
                    this.sentence = $"{WordManager.RndSubjectVerb(false, false)}";
                    break;
                case 1:
                    this.sentence = $"{WordManager.RndSubjectVerbObject()}";
                    break;
                case 2:
                    this.sentence = $"{WordManager.RndSubjectVerb(true, false)} {WordManager.RndAdjective()}";
                    break;
                case 3:
                    this.sentence = $"{WordManager.RndSubjectVerb(false, false)} {WordManager.RndAdverb()}";
                    break;
                case 4:
                    this.sentence = $"{WordManager.RndSubjectVerb(true, true)} {WordManager.RndAdjective()}?";
                    break;
                    case 5:
                    this.sentence = $"{this.GenerateSentence(false)}, {this.GenerateSentence(false)}";
                    break;
            }
            return this.AddPunctuation(this.sentence);
        }
        private string AddPunctuation(string inputSentence)
        {
            char endChar;
            if (inputSentence.EndsWith('?')) { endChar = '\0'; }
            else { endChar = '.'; }
            return inputSentence[0].ToString().ToUpper() + inputSentence.Substring(1, inputSentence.Length - 1) + endChar;
        }
    }
}
