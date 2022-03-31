using System;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class QbwHandler: DataHandler
    {
        public QbwHandler(DataHandler next) : base(next)
        {
        }

        protected override bool DoHandle(DataFiles dataFiles)
        {
            foreach (var file in dataFiles.Files)
            {
                if (file.EndsWith(".qbw"))
                {
                    Console.WriteLine($"handle qbw: {file}");
                }
            }

            return false;
        }
    }
}