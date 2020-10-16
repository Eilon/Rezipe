using Microsoft.AspNetCore.Components;
using System;
using Xamarin.Forms;

namespace Rezipe
{
    public class RezipeComponentBase : ComponentBase, IDisposable
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            Application.Current.RequestedThemeChanged += OnRequestedThemeChanged;
        }

        private void OnRequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            DebugPage.WriteLine($"Theme changed on {GetType().Name} to: {e.RequestedTheme}");

            // Re-render UI when app theme changes between dark/light
            StateHasChanged();
        }

        public void Dispose()
        {
            Application.Current.RequestedThemeChanged -= OnRequestedThemeChanged;
        }

        protected Color GetThemeColor(Color lightColor, Color darkColor)
        {
            return Application.Current.RequestedTheme == OSAppTheme.Dark ? darkColor : lightColor;
        }
    }
}
