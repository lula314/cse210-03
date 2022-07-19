using System;
using System.Linq;
using System.Collections.Generic;

namespace cse210_03
{
    public class Words
    {
        private List<string> wordsList = new List<string>();
        List<char> wordLettersList = new List<char>();

        public string word;
        private int num;

        // adds words to list of words
        public Words()
        {
            this.wordsList.Add("sphynx");
            this.wordsList.Add("rhythm");
            this.wordsList.Add("pickle");
            this.wordsList.Add("narwhal");
            this.wordsList.Add("notion");
        }

        // chooses random word from word list
        public string ChooseWord()
        {
            Random random = new Random();
            num = random.Next(0, this.wordsList.Count);
            word = this.wordsList[num];
            return word;
        }
        
        public string GetWordLetters(string word, string letter, string wordLetters)
        {
            wordLettersList = wordLetters.ToList();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter[0])
                {
                    this.wordLettersList[i] = letter[0];
                }
                // else if (word[i] != letter[0] && word[i] == '_')
                // {
                //     this.wordLettersList[i] = '_';
                // }
            }
            wordLetters = string.Join("", wordLettersList);
            return wordLetters;
        }
    }
}
