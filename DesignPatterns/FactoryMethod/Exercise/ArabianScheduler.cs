namespace DesignPatterns.FactoryMethod.Exercise
{
    public class ArabianScheduler : Scheduler
    {
        protected override ICalendar CreateCalendar()
        {
            return new ArabianCalendar();
        }
    }
}