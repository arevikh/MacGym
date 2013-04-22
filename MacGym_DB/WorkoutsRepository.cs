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
    }
}
