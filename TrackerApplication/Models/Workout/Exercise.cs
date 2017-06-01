using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackerApplication.Models.Workout
{
    public enum BodyPart
    {
        Abs, Arms, Back, Chest, Legs, Shoulders
    }

    public class Exercise
    {
        public int ExerciseID { get; set; }
        public String ExerciseName { get; set; }

        public BodyPart bodyPart { get; set; }

        public int WorkoutID { get; set; }
        public virtual ICollection<Workout> Workout { get; set; }

    }
}