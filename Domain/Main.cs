namespace Domain;

public sealed class Main
{
    #region MainText Property

    public string MainText
    {
        get => _mainText;
        set => _mainText = value;
    }

    public string _mainText;

    #endregion
    
    public Main()
    {
        MainText = "Welcome Avalonia, ReactiveUI, Clean Architecture, MVVM and DI. Did I forget about anything?";
    }
}