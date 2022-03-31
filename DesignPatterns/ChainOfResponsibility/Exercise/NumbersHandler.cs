using System;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class NumbersHandler: DataHandler
    {
        public NumbersHandler(DataHandler next) : base(next)
        {
        }

        protected override bool DoHandle(DataFiles dataFiles)
        {
            foreach (var file in dataFiles.Files)
            {
                if (file.EndsWith(".numbers"))
                {
                    Console.WriteLine($"handle numbers: {file}");
                }
            }

            return false;
        }
    }
}