using System;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class XlsHandler: DataHandler
    {
        public XlsHandler(DataHandler next) : base(next)
        {
        }

        protected override bool DoHandle(DataFiles dataFiles)
        {
            foreach (var file in dataFiles.Files)
            {
                if (file.EndsWith(".xls"))
                {
                    Console.WriteLine($"handle xls: {file}");
                }
            }

            return false;
        }
    }
}