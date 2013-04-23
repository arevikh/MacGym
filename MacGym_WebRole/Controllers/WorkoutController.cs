using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MacGym_DB;
using MacGym_WebRole.Models;

namespace MacGym_WebRole.Controllers
{
    public class WorkoutController : Controller
    {
        public ActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.Tools = new ToolsRepository().Get();
            model.BodyParts = new BodyPartsRepository().Get();
            model.LastViewed = new WorkoutsRepository().GetLastViewed(10);
            return View(model);
        }

        public ActionResult Details(int id)
        {
            new WorkoutsRepository().AddView(id);

            WorkoutModel model = new WorkoutModel(new WorkoutsRepository().Get(id));
            model.BodyParts = new BodyPartsRepository().GetByWorkout(id);
            model.Tools = new ToolsRepository().GetByWorkout(id);
            return View(model);
        }

        public ActionResult List(int? tool, int? bodyPart, string search)
        {
            ListModel model =  new ListModel();
            if (!string.IsNullOrWhiteSpace(search))
            {
                model.Workouts = new WorkoutsRepository().Get(search).Select(w => new WorkoutModel(w)).ToList();
            }
            else
            {
                model.Workouts = new WorkoutsRepository().Get(tool.HasValue ? tool.Value : 0, bodyPart.HasValue ? bodyPart.Value : 0).Select(w => new WorkoutModel(w)).ToList();
            }
            return View(model);
        }

        public ActionResult Search(string searchText)
        {
            return RedirectToActionPermanent("List", new { search = searchText });
        }
    }
}
