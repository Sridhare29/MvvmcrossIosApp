using System;
using System.Collections.Generic;

namespace Application
{
    public class SectionModel
    {
        public SectionModel()
        {
        public string Title { get; set; }
        public List<string> Items { get; set; }
        public bool IsExpanded { get; set; }
    }
    }
}

