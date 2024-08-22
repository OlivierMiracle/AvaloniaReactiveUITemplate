using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using Splat;

namespace Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());
        
        return services;
    }
}