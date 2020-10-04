using System;
using System.IO;

namespace Data.Computers.TestData
{
    public static class TestData
    {
        public static string Get1000digitNumberProblem8()
        {
            string number = string.Empty;

            try
            {
                var assembly = typeof(TestData).Assembly;
                Stream textFileForProblem8 = assembly.GetManifestResourceStream("Data.Computers.DataFiles.1000digitNumberProblem8.txt");

                var streamReader = new StreamReader(textFileForProblem8);
                var line = streamReader.ReadLine();

                while (line != null)
                {
                    number += line;
                    line = streamReader.ReadLine();
                }

                streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return number;
        }
    }
}
