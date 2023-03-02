using System;
using System.Collections.Generic;
using MvvmCross.ViewModels;

namespace MvvmcrossIosApp.Core.Model
{
    public class SectionModel : MvxViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public bool IsExpanded { get; set; }
    }
}

