using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class DataFiles
    {
        public List<string> Files { get; } = new()
        {
            "file1.xls", "file2.numbers", "file3.qbw", "file4.xls"
        };
    }
}