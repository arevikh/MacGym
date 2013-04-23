using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacGym_DB
{
    public class ToolsRepository : BaseRepository
    {
        public Tool Add(Tool tool)
        {
            DB.Tools.InsertOnSubmit(tool);
            if (SubmitChanges())
                return tool;

            return null;
        }

        public Tool Update(Tool tool)
        {
            if (SubmitChanges())
                return tool;

            return null;
        }

        public List<Tool> Get()
        {
            return DB.Tools.ToList();
        }

        public List<Tool> GetByWorkout(int workoutID)
        {
            return DB.Tools.Where(t => t.WorkoutTools.Count(w => w.workoutID == workoutID) > 0).ToList();
        }
    }
}
