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

        public Workout Get(int workoutID)
        {
            return DB.Workouts.FirstOrDefault(w => w.workoutID == workoutID);
        }

        public List<Workout> Get(string searchText)
        {
            List<string> atoms = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            var query = from w in DB.Workouts
                        select w;
            
            var predicate = PredicateBuilder.False<Workout>();
            foreach (var atom in atoms)
            {
                //Name
                predicate = predicate.Or<Workout>(w => w.name.Contains(atom));

                //Tool
                predicate = predicate.Or<Workout>(w => w.WorkoutTools.Any(wt => wt.Tool.name.Contains(atom)));

                //BodyPart
                predicate = predicate.Or<Workout>(w => w.WorkoutBodyParts.Any(wb => wb.BodyPart.name.Contains(atom)));
            }
            query = query.Where(predicate).Where(predicate).Distinct();

            return query.ToList();
        }
    }
}
