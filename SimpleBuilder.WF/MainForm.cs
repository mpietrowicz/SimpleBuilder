using ReactiveUI;
using SimpleBuilder.WF.ViewModels;
using Splat;

namespace SimpleBuilder.WF
{
    public partial class MainForm : Form, IViewFor<MainFormViewModel>
    {
        public MainForm()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                d(this.BindCommand(ViewModel, vm => vm.CloseApplication, v => v.exitToolStripMenuItem));
            });
        }

        object? IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as MainFormViewModel;
        }

        public MainFormViewModel? ViewModel { get; set; }
    }
}