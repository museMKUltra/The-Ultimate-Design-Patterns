namespace DesignPatterns.AbstractFactory.Exercise.BuildMuscle
{
    public class BuildMuscleFactory : IPlanFactory
    {
        public IMealPlan CreateMealPlan()
        {
            return new BuildMuscleMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new BuildMuscleWorkoutPlan();
        }
    }
}