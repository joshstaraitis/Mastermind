using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class Attempt
    {
         private readonly string AnswerCode;

        public Attempt(string code)
        {
            AnswerCode = code;
        }

        public string Analyze(string attempt)
        {
            var builder = new StringBuilder(attempt.Length);

            for (var index = 0; index < attempt.Length; index++)
            {
                var digit = attempt[index];
                var information = ' ';

                if (AnswerCode.Contains(digit))
                    information = AnswerCode[index] == digit
                        ? '+'
                        : '-';

                builder.Append(information);
            }
            return builder.ToString();
        }
    }
}
