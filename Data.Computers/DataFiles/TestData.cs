using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Data.Computers.TestData
{
    public static class TestData
    {
        private static string GetDataFromTextFile(string path)
        {
            var assembly = typeof(TestData).Assembly;
            Stream textFile = assembly.GetManifestResourceStream(path);

            var streamReader = new StreamReader(textFile);
            var content = streamReader.ReadToEnd();
            streamReader.Close();

            return content;
        }

        public static string Get1000digitNumberProblem8()
        {
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.1000DigitNumberProblem8.txt");
            return Regex.Replace(dataFromTextFile, @"\s+", "");
        }

        public static int[,] Get20By20GridProblem11()
        {
            var dataGrid = new int[20, 20];
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.20By20GridProblem11.txt");
            var stringOfGrid = Regex.Replace(dataFromTextFile, @"\s+", "");

            for (int i = 0; i < stringOfGrid.Length - 1; i += 2)
            {
                dataGrid[i / 40, (i % 40) / 2] = int.Parse(stringOfGrid.Substring(i, 2));
            }

            return dataGrid;
        }

        public static List<BigInteger> Get100NumbersWith50DigitsProblem13()
        {
            var numberOfIntegers = 100;
            var numberOfDigits = 50;
            var listOfNumbers = new List<BigInteger>();
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.100NumbersWith50DigitsProblem13.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", "");

            for (int i = 0; i < numberOfIntegers; i++)
            {
                var number = BigInteger.Parse(stringOfTextFile.Substring(i * numberOfDigits, numberOfDigits));
                listOfNumbers.Add(number);
            }

            return listOfNumbers;
        }

        public static int[,] ExampleTriangleProblem18()
        {
            var numberOfDigitsPerNumber = 1;
            var numberOfRows = 4;
            var triangleGrid = new int[numberOfRows, numberOfRows];

            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.ExampleTriangleProblem18.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", "");

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangleGrid[i, j] = int.Parse(stringOfTextFile.Substring(0, numberOfDigitsPerNumber));
                    stringOfTextFile = stringOfTextFile.Substring(numberOfDigitsPerNumber);
                }
            }

            return triangleGrid;
        }

        public static int[,] TriangleProblem18()
        {
            var numberOfDigitsPerNumber = 2;
            var numberOfRows = 15;
            var triangleGrid = new int[numberOfRows, numberOfRows];

            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.TriangleProblem18.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", "");

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangleGrid[i, j] = int.Parse(stringOfTextFile.Substring(0, numberOfDigitsPerNumber));
                    stringOfTextFile = stringOfTextFile.Substring(numberOfDigitsPerNumber);
                }
            }

            return triangleGrid;
        }

        public static int[,] TriangleProblem67()
        {
            var numberOfDigitsPerNumber = 2;
            var numberOfRows = 100;
            var triangleGrid = new int[numberOfRows, numberOfRows];

            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.TriangleProblem67.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", "");

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangleGrid[i, j] = int.Parse(stringOfTextFile.Substring(0, numberOfDigitsPerNumber));
                    stringOfTextFile = stringOfTextFile.Substring(numberOfDigitsPerNumber);
                }
            }

            return triangleGrid;
        }

        public static List<string> FirstNamesProblem22()
        {
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.FirstNamesProblem22.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", string.Empty)
                .Replace("\"", string.Empty).Trim();

            return stringOfTextFile.Split(",").ToList();
        }

        public static List<string> EnglishWordsProblem42()
        {
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.EnglishWordsProblem42.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", string.Empty)
                .Replace("\"", string.Empty).Trim();

            return stringOfTextFile.Split(",").ToList();
        }

        public static (List<List<string>>, List<List<string>>) PokerHandsProblem54()
        {
            return PokerHandsProblem54("Data.Computers.DataFiles.1000PokerHandsProblem54.txt");
        }

        public static (List<List<string>>, List<List<string>>) ExamplePokerHandsProblem54()
        {
            return PokerHandsProblem54("Data.Computers.DataFiles.ExamplePokerHandsProblem54.txt");
        }

        private static (List<List<string>>, List<List<string>>) PokerHandsProblem54(string textFilePokerHands)
        {
            var numberOfCardsPerHand = 5;

            var handsOfFirstPlayer = new List<List<string>>();
            var handsOfSecondPlayer = new List<List<string>>();

            var dataFromTextFile = GetDataFromTextFile(textFilePokerHands);
            var numberOfPokerHands = Regex.Matches(dataFromTextFile, "\r\n").Count + 1;
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", string.Empty)
                .Replace("\"", string.Empty).Trim();

            foreach (int numberOfPokerHand in Enumerable.Range(1, numberOfPokerHands))
            {
                var pokerHandFirstPlayer = new List<string>();
                var pokerHandSecondPlayer = new List<string>();

                foreach (int numberOfCards in Enumerable.Range(1, numberOfCardsPerHand))
                {
                    pokerHandFirstPlayer.Add(stringOfTextFile.Substring(0, 2));
                    stringOfTextFile = stringOfTextFile.Substring(2);
                }

                foreach (int numberOfCards in Enumerable.Range(1, numberOfCardsPerHand))
                {
                    pokerHandSecondPlayer.Add(stringOfTextFile.Substring(0, 2));
                    stringOfTextFile = stringOfTextFile.Substring(2);
                }

                handsOfFirstPlayer.Add(pokerHandFirstPlayer);
                handsOfSecondPlayer.Add(pokerHandSecondPlayer);
            }

            return (handsOfFirstPlayer, handsOfSecondPlayer);
        }

        public static List<byte> CipherTextProblem59()
        {
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.CipherTextProblem59.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", string.Empty)
                .Replace("\"", string.Empty).Trim();

            return stringOfTextFile.Split(",").Select(asciiValue => (byte)int.Parse(asciiValue)).ToList();
        }

        public static List<string> KeylogsProblem79()
        {
            var listOfKeylogs = new List<string>();
            var sizeOfKeylogs = 3;
            var numberOfKeyLogs = 50;
            var dataFromTextFile = GetDataFromTextFile("Data.Computers.DataFiles.KeylogProblem79.txt");
            var stringOfTextFile = Regex.Replace(dataFromTextFile, @"\s+", string.Empty)
                .Replace("\"", string.Empty).Trim();

            for (int i = 0; i < numberOfKeyLogs; i++)
            {
                listOfKeylogs.Add(stringOfTextFile.Substring(sizeOfKeylogs * i, sizeOfKeylogs));
            }

            return listOfKeylogs;
        }
    }
}
