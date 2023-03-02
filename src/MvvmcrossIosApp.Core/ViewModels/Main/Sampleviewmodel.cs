using System;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmcrossIosApp.Core.ViewModels.Main
{
    public class Sampleviewmodel : MvxViewModel
    {


        private MvxCommand _buttonClickCommand;
        public MvxCommand ButtonClickCommand
        {
            get
            {
                _buttonClickCommand = _buttonClickCommand ?? new MvxCommand(DoButtonClick);
                return _buttonClickCommand;
            }
        }

        private void DoButtonClick()
        {
            // Code to execute when button is clicked.
            Console.WriteLine("Hello world");

        }


    }
}

