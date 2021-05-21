using System;
using System.IO;
using System.Collections.Generic;

namespace csharpProject3
{
    public class ExportSentences
    {
        private List<string> export = new List<string>();
        public void AddToExport(string sentence)
        {
            export.Add(sentence);
        }
        public void ExecuteExport()
        {
            string fileName = DateTime.Now.ToString();
            fileName = "randomTextExport" + fileName.Split(' ')[0] + '_' + fileName.Split(' ')[1] + '_' + fileName.Split(' ')[2];
            File.WriteAllLines($@"C:\Users\mees\Documents\csharpProject3\output\{fileName}",export.ToArray());
        }

    }
}
