using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.TextReplace
{
    public class TextReplaceModule
    {
        private string wordToReplace;

        private string replacementWord;


        public TextReplaceModule(string wordToReplace, string replacementWord)
        {
            ArgumentNullException.ThrowIfNull(wordToReplace);
            ArgumentNullException.ThrowIfNull(replacementWord);


            this.replacementWord = replacementWord;
            this.wordToReplace = wordToReplace;
        }
        public bool Execute(string projectFolder)
        {
            if (string.IsNullOrEmpty(replacementWord) == false || string.IsNullOrEmpty(wordToReplace))
            {
                // Get file in directory path
                string[] files = Directory.GetFiles(projectFolder);

                foreach (string file in files)
                {
                    string text = File.ReadAllText(file);
                    string value = text.Replace(wordToReplace, replacementWord);
                    File.WriteAllText(file, value);
                }
                return true;
            }
            return false;

        }
    }
}
