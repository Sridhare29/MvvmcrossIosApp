using System;
using System.Collections.Generic;
using MvvmCross.ViewModels;

namespace MvvmcrossIosApp.Core.ViewModels
{
    public class MyListViewModel : MvxViewModel
    {
        public MyListViewModel()
        {
        }
        public List<string> Items { get; } = new List<string>
    {
        "Item 1",
        "Item 2",
        "Item 3",
        "Item 4",
        "Item 5"
    };
    }
}

