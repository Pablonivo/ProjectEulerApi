using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Data.Computers.DataFiles
{
    public static class TestDataHelper
    {
        public static long GetNameScoresForProblem22()
        {
            long totalScore = 0;
            var listOfNames = TestData.TestData.FirstNamesProblem22();
            listOfNames.Sort();

            foreach(int i in Enumerable.Range(0, listOfNames.Count))
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
            // Lower case characters have an ASCII value between 97 ('a') and 122 ('z').
            var byteArraySolution = new List<byte>();
            var highestWordCountOfEnglishTheFound = 0;
            var lowerBoundAsciiValueForLettersKey = 97;
            var numberOfLowerCaseLetters = 26;

            foreach (int firstLetterKey in Enumerable.Range(lowerBoundAsciiValueForLettersKey, numberOfLowerCaseLetters))
            {
                foreach (int secondLetterKey in Enumerable.Range(lowerBoundAsciiValueForLettersKey, numberOfLowerCaseLetters))
                {
                    foreach (int thirdLetterKey in Enumerable.Range(lowerBoundAsciiValueForLettersKey, numberOfLowerCaseLetters))
                    {
                        var decryptedList = new List<byte>();

                        foreach (int index in Enumerable.Range(0, asciiValues.Count))
                        {
                            if (index % 3 == 0)
                            {
                                decryptedList.Add((byte)(firstLetterKey ^ asciiValues[index]));
                            }

                            if (index % 3 == 1)
                            {
                                decryptedList.Add((byte)(secondLetterKey ^ asciiValues[index]));
                            }

                            if (index % 3 == 2)
                            {
                                decryptedList.Add((byte)(thirdLetterKey ^ asciiValues[index]));
                            }
                        }

                        var decyptedByteArray = decryptedList.ToArray();
                        var decryptedText = Encoding.ASCII.GetString(decyptedByteArray);
                        var countOfTheInDecryptedText = Regex.Matches(decryptedText, "the").Count;

                        if (countOfTheInDecryptedText > highestWordCountOfEnglishTheFound)
                        {
                            highestWordCountOfEnglishTheFound = countOfTheInDecryptedText;
                            byteArraySolution = decyptedByteArray.ToList();
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
