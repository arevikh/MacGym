using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MacGym_DB;

namespace MacGym_WebRole.Models
{
    public class IndexModel
    {
        public List<Tool> Tools { get; set; }
        public List<BodyPart> BodyParts { get; set; }
        public List<Workout> LastViewed { get; set; }
    }
}