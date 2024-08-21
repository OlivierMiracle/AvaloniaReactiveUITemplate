using Domain;
using ReactiveUI;

namespace Application;

public sealed class MainViewModel  : ReactiveObject
{
    public static MainViewModel Create(Main model, IServiceProvider services)
    {
        return new MainViewModel(model);
    }
    
    private Main _main;

    public string MainText
    {
        get => _main._mainText;
        set => this.RaiseAndSetIfChanged(ref _main._mainText, value);
    }
    
    private MainViewModel(Main main)
    {
        _main = main;
    }
}