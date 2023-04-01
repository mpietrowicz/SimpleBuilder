using System.Reflection;
using ReactiveUI;
using Splat;

namespace SimpleBuilder.WF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// splat locator register all view models
            //Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
            

            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and run Bootstrapper
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();     
        }
    }
}