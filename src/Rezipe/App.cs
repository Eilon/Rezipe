using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.MobileBlazorBindings;
using Rezipe.Stores;
using Xamarin.Forms;

namespace Rezipe
{
    public class App : Application
    {
        public IHost AppHost { get; }

        public App()
        {
            AppHost = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    //services.AddSingleton<AppState>();
                    services.AddSingleton<ShellNavigationManager>();
                    services.AddSingleton<RecipeStore>();
                    services.AddSingleton<UserStore>();
                })
                .Build();

            MainPage = new ContentPage();
            AppHost.AddComponent<RezipeApp>(parent: this);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
