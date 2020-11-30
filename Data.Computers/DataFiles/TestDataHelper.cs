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

        public static int GetWordScore(string word)
        {
            var wordScore = 0;
            foreach (char letter in word)
            {
                wordScore += MapLetterToAlphabeticalValue(letter);
            }
            return wordScore;
        }

        private static int MapLetterToAlphabeticalValue(char letter)
        {
            return letter % 32;
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

        public static string GetPasswordProblem79(List<string> keylogs)
        {
            var charactersToTheRight = new Dictionary<char, List<char>>();

            foreach (string keylog in keylogs)
            {
                var keylogSize = keylog.Length;

                for (int index = 0; index < keylogSize - 1; index++)
                {
                    for (int indexOfNumberToTheRight = index + 1; indexOfNumberToTheRight < keylog.Length; indexOfNumberToTheRight++)
                    {
                        if (!charactersToTheRight.ContainsKey(keylog[index]))
                        {
                            charactersToTheRight.Add(keylog[index], new List<char> { keylog[indexOfNumberToTheRight] });
                        }

                        else
                        {
                            if (!charactersToTheRight[keylog[index]].Contains(keylog[indexOfNumberToTheRight]))
                            {
                                charactersToTheRight[keylog[index]].Add(keylog[indexOfNumberToTheRight]);
                            }
                        }
                    }

                    if (!charactersToTheRight.ContainsKey(keylog[keylogSize - 1]))
                    {
                        charactersToTheRight.Add(keylog[keylogSize - 1], new List<char> { });
                    }
                }
            }

            string password = string.Empty;
            var sizeOfPassword = charactersToTheRight.Keys.Count;
            for (int i = 0; i < sizeOfPassword; i++)
            {
                var sizeOfHighestCountOfValuesToTheRight = charactersToTheRight.Values.Select(listOfChar => listOfChar.Count).Max();
                var keyOfMostLeftCharacter = charactersToTheRight.Keys.First(key => charactersToTheRight[key].Count == sizeOfHighestCountOfValuesToTheRight);
                password += keyOfMostLeftCharacter.ToString();
                charactersToTheRight.Remove(keyOfMostLeftCharacter);
            }

            return password;
        }

        public static long MinimalPathMatrixOnlyMovingRightAndDown(int[,] matrix)
        {
            var lengthOfMatrix = (int)Math.Sqrt(matrix.Length);
            var highestIndex = lengthOfMatrix - 1;

            for (int i = 1; i <= highestIndex; i++)
            {
                matrix[0, i] += matrix[0, i - 1];
                matrix[i, 0] += matrix[i - 1, 0];
            }

            for (int i = 1; i <= highestIndex; i++)
            {
                for (int j = 1; j <= highestIndex; j++)
                {
                    matrix[i, j] += Math.Min(matrix[i, j - 1], matrix[i - 1, j]);
                }
            }

            return matrix[highestIndex, highestIndex];
        }
    }
}
