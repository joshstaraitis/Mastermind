using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Game
    {
        private static Random random = new Random();
        private Attempt analyze;
        private List<Turn> turn = new List<Turn>();
        public string Code
        {
            get;
            set;
        }
        public bool Finished
        { 
            get;
            private set;
        }

        public Game() : this(GenerateAnswer()) { }

        public Game(string code)
        {
            Code = code;
            analyze = new Attempt(Code);
        }

        private static string GenerateAnswer(int length = 4)
        {
            var builder = new StringBuilder(length);
            for (var index = 0; index < length; index++)
                builder.Append(random.Next(1, 6));
            return builder.ToString();
        }

        public string Attempt(string guess)
        {
            var turn = new Turn
            {
                number = this.turn.Count + 1,
                guess = guess,
                information = analyze.Analyze(guess)
            };
            this.turn.Add(turn);

            if (turn.information == "++++")
            {
                Finished = true;
                return $"You win!";
            }

            if (turn.number > 9)
            {
                Finished = true;
                return $"Sorry, you lost.\nThe answer is: {Code}";
            }
            return turn.information;
        }     
    }
}