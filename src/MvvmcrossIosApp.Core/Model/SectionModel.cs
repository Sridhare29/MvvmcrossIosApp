using System;
using System.Collections.Generic;

namespace MvvmcrossIosApp.Core.Model
{
    public class SectionModel
    {
        public string Title { get; set; }
        public List<string> Items { get; set; }
        public bool IsExpanded { get; set; }
    }
}

