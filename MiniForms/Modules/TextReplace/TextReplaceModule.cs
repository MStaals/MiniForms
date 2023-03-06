using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    var fileExtension = Path.GetExtension(file);
                    if(fileExtension == ".txt")
                    {
                        string text = File.ReadAllText(file);
                        text = Regex.Replace(text, @"(?:(?<=^|\s)(?=\S|$)|(?<=^|\S)(?=\s|$))" + wordToReplace + @"(?:(?<=^|\s)(?=\S|$)|(?<=^|\S)(?=\s|$))", replacementWord);
                        
                        File.WriteAllText(file, text);
                    }
                    
                }
                return true;
            }
            return false;

        }
    }
}
