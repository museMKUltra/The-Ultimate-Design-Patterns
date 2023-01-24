using System;
using System.Collections.Generic;

namespace DesignPatterns.singleton.exercise
{
    public class Logger
    {
        private Logger(string fileName)
        {
            _fileName = fileName;
        }

        private static string _fileName;

        private static Dictionary<string, Logger> Instances { get; } = new();


        public void Write()
        {
            Console.WriteLine("Writing a message to the log.");
        }

        public static Logger GetInstance(string fileName)
        {
            if (Instances.ContainsKey(fileName))
            {
                return Instances[fileName];
            }

            var newLogger = new Logger(fileName);
            Instances.Add(fileName, newLogger);

            return newLogger;
        }
    }
}