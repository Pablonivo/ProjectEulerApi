using System;
using System.IO;
using System.Reflection;

namespace Data.Computers.TestData
{
    public static class TestData
    {
        public static string Get1000digitNumberProblem8()
        {
            string number = "";

            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DataFiles\1000digitNumberProblem8.txt");
                var streamReader = new StreamReader(path);
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
