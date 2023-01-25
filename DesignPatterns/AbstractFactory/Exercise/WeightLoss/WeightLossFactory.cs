namespace DesignPatterns.AbstractFactory.Exercise.WeightLoss
{
    public class WeightLossFactory : IPlanFactory
    {
        public IMealPlan CreateMealPlan()
        {
            return new WeightLossMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new WeightLossWorkoutPlan();
        }
    }
}