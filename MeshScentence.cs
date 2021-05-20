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
                    this.scentence = WordManager.RndSubjectVerb(false);
                    break;
                case "subject_verb_object":
                    this.scentence = WordManager.RndSubjectVerbObject();
                    break;
                case "subject_verb_adjective":
                    this.scentence = $"{WordManager.RndSubjectVerb(true)} {WordManager.RndAdjective()}";
                    break;
                case "subject_verb_adverb":
                    this.scentence = $"{WordManager.RndSubjectVerb(false)} {WordManager.RndAdverb()}";
                    break;
            }
            return this.scentence;
        }
    }
}
