using System;
using Xamarin.Forms;

namespace Rezipe
{
    public partial class RezipeApp
    {
#if DEBUG
        public static bool DebugMode => true;
#else
        public static bool DebugMode => false;
#endif

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var theme = Application.Current.RequestedTheme;
            DebugPage.WriteLine($"Current theme: {theme}");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Shell.Current.ItemTemplate = GetShellItemTemplate();

                // Set ShellItem to the container of the Favorite Recipes page
                Shell.Current.CurrentItem = favRecipesPage.NativeControl;

                // Set ShellContent within tabs to the actual Favorite Recipes page
                Shell.Current.CurrentItem.CurrentItem = favRecipesPage.NativeControl;
            }
        }

        private static DataTemplate GetShellItemTemplate()
        {
            return new DataTemplate(() =>
            {
                var grid = new Grid()
                {
                    ColumnDefinitions = new ColumnDefinitionCollection
                    {
                        new ColumnDefinition{ Width = 50, },
                        new ColumnDefinition{ Width = GridLength.Star, },
                    },
                };

                var itemImage = new Image
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    HeightRequest = 22,
                    WidthRequest = 22,
                };

                var itemLabel = new Label
                {
                    FontSize = 20d,
                    FontAttributes = FontAttributes.Bold,
                    VerticalTextAlignment = TextAlignment.Center,
                };
                itemLabel.SetAppThemeColor(Label.TextColorProperty, light: Color.Black, dark: Color.White);

                itemImage.SetBinding(Image.SourceProperty, "FlyoutIcon");
                itemLabel.SetBinding(Label.TextProperty, "Title");

                grid.Children.Add(itemImage);
                grid.Children.Add(itemLabel, 1, 0);

                var normalState = new VisualState { Name = "Normal" };
                normalState.Setters.Add(new Setter { Property = Grid.BackgroundColorProperty, Value = Color.DarkGray, });
                var selectedState = new VisualState { Name = "Selected" };
                selectedState.Setters.Add(new Setter { Property = Grid.BackgroundColorProperty, Value = Color.LightGray, });

                var commonStateGroup = new VisualStateGroup { Name = "CommonStates" };
                commonStateGroup.States.Add(normalState);
                commonStateGroup.States.Add(selectedState);

                VisualStateManager.SetVisualStateGroups(grid, new VisualStateGroupList
                {
                    commonStateGroup,
                });

                return grid;
            });
        }
    }
}
