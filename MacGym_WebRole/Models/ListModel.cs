using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MacGym_DB;

namespace MacGym_WebRole.Models
{
    public class WorkoutModel
    {
        private Workout _workout = null;
        public WorkoutModel(Workout workout)
        {
            _workout = workout;
        }

        public string FirstImage
        {
            get
            {
                return _workout.WorkoutImages.Count() > 0 ? _workout.WorkoutImages.FirstOrDefault().image : null;
            }
        }

        public List<string> Images
        {
            get
            {
                return _workout.WorkoutImages.Select(i => i.image).ToList();
            }
        }

        public int WorkoutID
        {
            get
            {
                return _workout.workoutID;
            }
        }

        public string Description
        {
            get
            {
                return _workout.description;
            }
        }
    }

    public class ListModel
    {
        public List<WorkoutModel> Workouts { get; set; }
    }
}