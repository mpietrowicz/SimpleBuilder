using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using SimpleBuilder.WF.ViewModels;
using Splat;

namespace SimpleBuilder.WF
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {
            ConfigureServices();
        }

        private void ConfigureServices()
        {
           // register all viewmodels in the assembly
           Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

        }
        
        public void Run()
        {
            // Create ShellViewModel and register as IScreen
            var viewModel = new MainFormViewModel();
            Locator.CurrentMutable.RegisterConstant(viewModel, typeof(IScreen));
            // Resolve view for ShellViewModel
            var view = ViewLocator.Current.ResolveView(viewModel);
            view.ViewModel = viewModel;
            // Run application
            Application.Run((Form)view);
        }
    }
}
