﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Computers.Solutions
{
    public class Problem0017 : IProblem
    {
        private readonly int UPPER_BOUND = 1000;

        public Problem0017(int upperBound)
        {
            UPPER_BOUND = upperBound;
        }

        public Problem0017()
        {

        }

        public long ComputeSolution()
        {
            var numbersToWriteOut = Enumerable.Range(1, UPPER_BOUND).ToList();
            return SumOfLengthOfNumbersAsWordsWrittenOut(numbersToWriteOut);
        }

        private int SumOfLengthOfNumbersAsWordsWrittenOut(IEnumerable<int> numbers)
        {
            var sum = 0;
            foreach (int number in numbers)
            {
                sum += ToEnglishWord(number).Length;
            }
            return sum;
        }

        private string ToEnglishWord(int number)
        {
            if (0 <= number && number <= 20)
            {
                return ToWord(number);
            }
            if (21 <= number && number <= 99)
            {
                if (number % 10 == 0)
                {
                    return ToWord(number);
                }
                var multipleOf10 = number - (number % 10);
                var unit = number - multipleOf10;
                return ToWord(multipleOf10) + ToWord(unit);
            }
            if (100 <= number && number <= 999)
            {
                var multipleOf100 = number / 100;
                if (number % 100 == 0)
                {
                    return ToWord(multipleOf100) + "hundred";
                }
                var numberFrom1to99 = number - multipleOf100 * 100;
                return ToWord(multipleOf100) + "hundred" + "and" + ToEnglishWord(numberFrom1to99);
            }
            if (number == 1000)
            {
                return "onethousand";
            }
            throw new ArgumentException("Not yet implemented");
        }

        private string ToWord(int number)
        {
            var numberInWords = number switch
            {
                0 => "zero",
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                10 => "ten",
                11 => "eleven",
                12 => "twelve",
                13 => "thirteen",
                14 => "fourteen",
                15 => "fifteen",
                16 => "sixteen",
                17 => "seventeen",
                18 => "eighteen",
                19 => "nineteen",
                20 => "twenty",
                30 => "thirty",
                40 => "forty",
                50 => "fifty",
                60 => "sixty",
                70 => "seventy",
                80 => "eighty",
                90 => "ninety",
                100 => "hundred",
                _ => string.Empty
            };
            return numberInWords;
        }
    }
}