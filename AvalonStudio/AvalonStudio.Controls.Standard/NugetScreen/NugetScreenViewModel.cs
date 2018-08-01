using System;
using System.Composition;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using AvalonStudio.Controls.Standard.SolutionExplorer;
using AvalonStudio.Controls.Standard.WelcomeScreen;
using AvalonStudio.Extensibility;
using AvalonStudio.Extensibility.Studio;
using AvalonStudio.Shell;

namespace AvalonStudio.Controls.Standard.NugetScreen
{
    [Export(typeof(NugetScreenViewModel))]
    [Export(typeof(IExtension))]
    [Shared]
    public class NugetScreenViewModel : DocumentTabViewModel, IActivatableExtension
    {
        public NugetScreenViewModel()
        {
            Title = "Nuget";
        }
        
        public void BeforeActivation()
        {
        }

        public void Activation()
        {
            var shell = IoC.Get<IShell>();
            var studio = IoC.Get<IStudio>();

            shell.AddOrSelectDocument(this);
        }
    }
}