using System;
using System.Collections.Generic;
using MvvmCross.ViewModels;
using MvvmcrossIosApp.Core.Model;

namespace MvvmcrossIosApp.Core.ViewModels.Main
{
    public class BasicviewModel : MvxViewModel               
    {
    

        private List<SectionModel> _sections;

        public List<SectionModel> Sections
        {
            get { return _sections; }
            set { SetProperty(ref _sections, value); }
        }

        public BasicviewModel()
        {
            // Initialize the data model
            Sections = new List<SectionModel>
        {
            new SectionModel
            {
                Title = "Section 1",
                Items = new List<string> { "Item 1", "Item 2", "Item 3" },
                IsExpanded = false
            },
            new SectionModel
            {
                Title = "Section 2",
                Items = new List<string> { "Item 4", "Item 5", "Item 6" },
                IsExpanded = false
            },
            new SectionModel
            {
                Title = "Section 3",
                Items = new List<string> { "Item 7", "Item 8", "Item 9" },
                IsExpanded = false
            }
        };
        }

        public void ToggleSection(int index)
        {
            Sections[index].IsExpanded = !Sections[index].IsExpanded;
            RaisePropertyChanged(() => Sections);
        }
    }
}       

