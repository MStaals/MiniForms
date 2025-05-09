﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniForms.Modules.TextReplace
{
    public class TextReplaceModule
    {
        private string  _wordToReplace;

        private string _replacementWord;


        public TextReplaceModule(string wordToReplace, string replacementWord)
        {
            ArgumentNullException.ThrowIfNull(wordToReplace);
            ArgumentNullException.ThrowIfNull(replacementWord);


            this._replacementWord = replacementWord;
            this._wordToReplace = wordToReplace;
        }
        public bool Execute(string projectFolder)
        {
            if (string.IsNullOrEmpty(_replacementWord) == false || string.IsNullOrEmpty(_wordToReplace))
            {
                // Get file in directory path
                string[] files = Directory.GetFiles(projectFolder);

                foreach (string file in files)
                {
                    var fileExtension = Path.GetExtension(file);
                    if(fileExtension == ".txt")
                    {
                        string text = File.ReadAllText(file);
                        text = Regex.Replace(text, @"(?:(?<=^|\s)(?=\S|$)|(?<=^|\S)(?=\s|$))" + _wordToReplace + @"(?:(?<=^|\s)(?=\S|$)|(?<=^|\S)(?=\s|$))", _replacementWord);
                        
                        File.WriteAllText(file, text);
                    }
                    
                }
                return true;
            }
            return false;

        }
    }
}
