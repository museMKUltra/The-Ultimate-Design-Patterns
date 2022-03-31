using System;

namespace DesignPatterns.Template
{
    public class TransferMoneyTaskExecutor : TaskExecutor
    {
        public TransferMoneyTaskExecutor(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}