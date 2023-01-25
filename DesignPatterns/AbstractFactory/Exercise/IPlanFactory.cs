namespace DesignPatterns.AbstractFactory.Exercise
{
    public interface IPlanFactory
    {
        IMealPlan CreateMealPlan();
        IWorkoutPlan CreateWorkoutPlan();
    }
}