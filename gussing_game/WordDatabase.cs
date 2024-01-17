using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gussing_game
{
    internal class WordDatabase
    {
        private List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" }; // Example words

        public string GetRandomWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(words.Count);
            return words[index];
        }
    }
}
