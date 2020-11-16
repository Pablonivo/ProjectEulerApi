using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Data.Computers.DataFiles
{
    public static class TestDataHelper
    {
        private const string ExpectedWordInTextForProblem59 = "Euler";

        public static long GetNameScoresForProblem22()
        {
            long totalScore = 0;
            var listOfNames = TestData.TestData.FirstNamesProblem22();
            listOfNames.Sort();

            foreach (int i in Enumerable.Range(0, listOfNames.Count))
            {
                totalScore += (i + 1) * GetWordScore(listOfNames[i]);
            }

            return totalScore;
        }

        public static int GetWordScore(string word)
        {
            var wordScore = 0;

            foreach (char letter in word)
            {
                wordScore += MapLetterToAlphabeticalValue(letter);
            }

            return wordScore;
        }

        public static List<byte> DecryptTextProblem59(List<byte> asciiValues)
        {
            var byteArraySolution = new List<byte>();

            for (char firstLetterKey = 'a'; firstLetterKey <= 'z'; firstLetterKey++)
            {
                for (char secondLetterKey = 'a'; secondLetterKey <= 'z'; secondLetterKey++)
                {
                    for (char thirdLetterKey = 'a'; thirdLetterKey <= 'z'; thirdLetterKey++)
                    {
                        var decryptedList = new List<byte>();

                        foreach (int index in Enumerable.Range(0, asciiValues.Count))
                        {
                            decryptedList.Add((byte)(asciiValues[index] ^ (
                                index % 3 == 0 ? firstLetterKey :
                                    index % 3 == 1 ? secondLetterKey : thirdLetterKey)));
                        }

                        var decyptedByteArray = decryptedList.ToArray();
                        var decryptedText = Encoding.ASCII.GetString(decyptedByteArray);
                        var countOfTheInDecryptedText = Regex.Matches(decryptedText, ExpectedWordInTextForProblem59).Count;

                        if (countOfTheInDecryptedText > 0)
                        {
                            return decyptedByteArray.ToList();
                        }
                    }
                }
            }

            return byteArraySolution;
        }

        private static int MapLetterToAlphabeticalValue(char letter)
        {
            return letter % 32;
        }
    }
}
