using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace demotest.Models
{
    public class presonGenreViewModel
    {
        public List<preson> presons { get; set; }
        public SelectList Genres { get; set; }
        public string presonGenre { get; set; }
        public string SearchString { get; set; }
    }
}