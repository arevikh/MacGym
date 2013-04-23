using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MacGym_DB;

namespace MacGym_WebRole.Models
{
    public class ToolModel
    {
        private Tool _tool = null;
        public ToolModel(Tool tool)
        {
            _tool = tool;
        }

        public bool HasImage
        {
            get
            {
                return _tool.ToolImages.Count() > 0;
            }
        }

        public string FirstImage
        {
            get
            {
                return _tool.ToolImages.Count() > 0 ? _tool.ToolImages.FirstOrDefault().image : null;
            }
        }

        public List<string> Images
        {
            get
            {
                return _tool.ToolImages.Select(i => i.image).ToList();
            }
        }

        public int ToolID
        {
            get
            {
                return _tool.toolID;
            }
        }

        public string Name
        {
            get
            {
                return _tool.name;
            }
        }
    }
}