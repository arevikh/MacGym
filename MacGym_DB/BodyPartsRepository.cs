using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacGym_DB
{
    public class BodyPartsRepository : BaseRepository
    {
        public BodyPart Add(BodyPart bodyPart)
        {
            DB.BodyParts.InsertOnSubmit(bodyPart);
            if (SubmitChanges())
                return bodyPart;

            return null;
        }

        public BodyPart Update(BodyPart bodyPart)
        {
            if (SubmitChanges())
                return bodyPart;

            return null;
        }

        public List<BodyPart> Get()
        {
            return DB.BodyParts.ToList();
        }

        public List<BodyPart> GetByWorkout(int workoutID)
        {
            return DB.BodyParts.Where(b => b.WorkoutBodyParts.Count(w => w.workoutID == workoutID) > 0).ToList();
        }
    }
}
