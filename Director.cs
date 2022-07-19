using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Director
    {
        // instantiate classes
        Words words = new Words();

        static Parachute parachute = new Parachute();

        TerminalService terminal = new TerminalService();

        // initialize variables
        bool isPlaying = true;
        string word;
        string letter = "0";
        string wordLetters;
        int guessCount = 0;
        List<string> parachuteList = parachute.parachuteList;

        // chooses word and loops main game as long as game check returns true
        public void StartGame()
        {
            word = words.ChooseWord();
            // fill wordLetters with _s
            for (int i = 0; i < word.Length; i++)
            {
                wordLetters += '_';
            }
            while (isPlaying)
            {
                mainGame();
                gameCheck();
            }
        }

        // holds main game program
        public void mainGame()
        {
            printParachute();

            // print the chosen word with _ for unguessed letters
            wordLetters = words.GetWordLetters(word, letter, wordLetters);
            terminal.WriteText(wordLetters);

            // ask user for a letter
            if (wordLetters != word)
            {
                letter = terminal.ReadGuess("Guess a letter [a-z]: ");
            }

            // if letter is not in word increase guessCount
            if (!word.Contains(letter[0]))
            {
                guessCount += 1;
            }

        }

        // checks for win or loss
        public void gameCheck()
        {
            if (guessCount == 4)
            {
                isPlaying = false;
                printParachute();
                terminal.WriteText("You have run out of tries. The parachute is gone and the jumper has fallen!");
                return;
            }

            if (wordLetters == word)
            {
                isPlaying = false;
                terminal.WriteText("You got the word! The jumper has survived!");
                return;
            }
        }

        // print parachute pic thing, omitting first lines for incorrect guesses
        public void printParachute()
        {
            for (int i = guessCount; i < parachuteList.Count; i++)
            {
                terminal.WriteText(parachuteList[i]);
            }
        }
    }
}
