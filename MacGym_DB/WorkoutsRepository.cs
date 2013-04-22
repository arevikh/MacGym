using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacGym_DB
{
    public class WorkoutsRepository : BaseRepository
    {
        public Workout Add(Workout workout)
        {
            DB.Workouts.InsertOnSubmit(workout);
            if (SubmitChanges())
                return workout;

            return null;
        }

        public Workout Update(Workout workout)
        {
            if (SubmitChanges())
                return workout;

            return null;
        }

        public List<Workout> Get()
        {
            return DB.Workouts.ToList();
        }

        public List<Workout> Get(int toolID, int bodyPartID)
        {
            return DB.Workouts.Where(w => (toolID == 0 || w.WorkoutTools.Count(t => t.toolID == toolID) > 0) &&
                                          (bodyPartID == 0 || w.WorkoutBodyParts.Count(b => b.bodyPartID == bodyPartID) > 0)).ToList();
        }
    }
}
