namespace DesignPatterns.Template
{
    public abstract class TaskExecutor
    {
        private readonly AuditTrail _auditTrail;

        protected TaskExecutor(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}