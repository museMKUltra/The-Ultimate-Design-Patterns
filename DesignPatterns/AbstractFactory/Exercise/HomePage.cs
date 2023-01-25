using System;

namespace DesignPatterns.AbstractFactory.Exercise
{
    public class HomePage
    {
        public void SetGoal(IPlanFactory factory)
        {
            var mealPlan = factory.CreateMealPlan();
            var workoutPlan = factory.CreateWorkoutPlan();
            
            Console.WriteLine(mealPlan);
            Console.WriteLine(workoutPlan);
        }
    }
}