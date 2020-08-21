using System;
using Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

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
