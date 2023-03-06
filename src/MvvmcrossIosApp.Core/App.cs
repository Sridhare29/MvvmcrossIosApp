using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmcrossIosApp.Core.ViewModels;
using MvvmcrossIosApp.Core.ViewModels.Main;

namespace MvvmcrossIosApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<Sampleviewmodel>();
            //RegisterAppStart<ActionViewModel>(); for okvc action board

        }
    }
}
