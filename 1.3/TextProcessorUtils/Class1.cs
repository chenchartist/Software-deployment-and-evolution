using System;

namespace TextProcessorUtils
{
    public class TextValidator
    {
        public bool IsValidText(string text)
        {
            return !string.IsNullOrEmpty(text) && text != "Paste your text here...";
        }
    }
}