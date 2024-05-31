using System.Collections.Generic;

namespace ScriptGrabber
{
    public class ProjectData
    {
        public List<string> ScriptFolders { get; set; } = new List<string>();
        public string ProjectDescription { get; set; } = string.Empty;
    }
}
