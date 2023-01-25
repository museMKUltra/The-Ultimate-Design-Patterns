namespace DesignPatterns.AbstractFactory.Exercise.StrengthTraining
{
    public class StrengthTrainingFactory : IPlanFactory
    {
        public IMealPlan CreateMealPlan()
        {
            return new StrengthTrainingMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new StrengthTrainingWorkoutPlan();
        }
    }
}