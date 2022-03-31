namespace DesignPatterns.Template
{
    public interface ITask
    {
        public AuditTrail AuditTrail { get; set; }
        public void Execute();
    }
}