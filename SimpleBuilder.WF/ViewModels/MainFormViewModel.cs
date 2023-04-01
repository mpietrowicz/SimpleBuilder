using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;

namespace SimpleBuilder.WF.ViewModels
{
    public class MainFormViewModel : ReactiveObject , IActivatableViewModel, IScreen
    {
        public MainFormViewModel()
        {
            CloseApplication = ReactiveCommand.Create(() => Environment.Exit(0));
        }

        public ReactiveCommand<Unit, Unit> CloseApplication { get; set; }

        public ViewModelActivator Activator { get; } = new();
        public RoutingState Router { get; } = new RoutingState();
    }
}
