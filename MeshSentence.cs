using System;

namespace csharpProject3
{
    public class MeshSentence
    {
        private string sentence;
        public string GenerateSentence(bool includeCompound, bool includePunctuation = true, int chooseCase = 69)
        {
            var WordManager = new WordManager();
            var Rnd = new Random();
            int randomness;
            if (includeCompound)
            {
                randomness = Rnd.Next(6);
            }
            else
            {
                randomness = Rnd.Next(4);
            }
            if (chooseCase <= 6)
            {
                randomness = chooseCase;
            }
            switch (randomness)
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
                    this.sentence = $"{this.GenerateSentence(false, false)}, {WordManager.RndLinkingWord()} {this.GenerateSentence(false, false)}";
                    break;
            }
            return this.AddPunctuation(this.sentence, includePunctuation);
        }
        private string AddPunctuation(string inputSentence, bool includePunctuation)
        {
            if (includePunctuation)
            {
                char endChar;
                if (inputSentence.EndsWith('?') || inputSentence.EndsWith('.')) { endChar = '\0'; }
                else { endChar = '.'; }
                return inputSentence[0].ToString().ToUpper() + inputSentence.Substring(1, inputSentence.Length - 1) + endChar;
            }
            else return inputSentence;
        }
    }
}
