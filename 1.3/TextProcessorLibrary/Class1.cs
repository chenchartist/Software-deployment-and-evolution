using System;

namespace TextProcessorLib
{
    public class WordCounter
    {
        public int CountWords(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;
            return text.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}