using System;

namespace DesignPatterns.Template
{
    public class GenerateReportTaskExecutor : TaskExecutor
    {
        public GenerateReportTaskExecutor(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}