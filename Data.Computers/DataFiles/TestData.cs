using System.Collections.Generic;
using System.IO;
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
    }
}
