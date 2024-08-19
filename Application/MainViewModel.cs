using Domain;
using ReactiveUI;

namespace Application;

public sealed class MainViewModel  : ReactiveObject
{
    private Main _main;

    public string MainText
    {
        get => _main._mainText;
        set => this.RaiseAndSetIfChanged(ref _main._mainText, value);
    }
}