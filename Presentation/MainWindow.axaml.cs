using Application;
using Avalonia.ReactiveUI;

namespace Presentation;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}