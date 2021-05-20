using System;

namespace csharpProject3
{
    public class MeshScentence
    {
        private string scentence;
        public string GenerateScentence(string scentenceType)
        {
            var WordManager = new WordManager();
            switch (scentenceType)
            {
                case "subject_verb":
                    this.scentence = $"{WordManager.RndSubjectVerb(false, false)}";
                    break;
                case "subject_verb_object":
                    this.scentence = $"{WordManager.RndSubjectVerbObject()}";
                    break;
                case "subject_verb_adjective":
                    this.scentence = $"{WordManager.RndSubjectVerb(true, false)} {WordManager.RndAdjective()}";
                    break;
                case "subject_verb_adverb":
                    this.scentence = $"{WordManager.RndSubjectVerb(false, false)} {WordManager.RndAdverb()}";
                    break;
                case "question":
                    this.scentence = $"{WordManager.RndSubjectVerb(true, true)} {WordManager.RndAdjective()}?";
                    break;
            }
            return this.AddPunctuation(this.scentence);
        }
        private string AddPunctuation(string inputScentence)
        {
            char endChar;
            if (inputScentence.EndsWith('?')) { endChar = '\0'; }
            else { endChar = '.'; }
            return inputScentence[0].ToString().ToUpper() + inputScentence.Substring(1, inputScentence.Length - 1) + endChar;
        }
    }
}
