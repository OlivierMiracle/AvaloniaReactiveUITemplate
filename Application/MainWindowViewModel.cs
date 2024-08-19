using ReactiveUI;

namespace Application;

public sealed class MainWindowViewModel : ReactiveObject
{
    #region MainViewModel Property

    private MainViewModel _mainViewModel;

    public MainViewModel MainViewModel
    {
        get => _mainViewModel;
        set => this.RaiseAndSetIfChanged(ref _mainViewModel, value);
    }

    #endregion

    public MainWindowViewModel(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }
}