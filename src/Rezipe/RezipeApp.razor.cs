using Xamarin.Forms;

namespace Rezipe
{
    public partial class RezipeApp
    {
        private DataTemplate GetShellItemTemplate()
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
                    TextColor = Color.Black,
                    FontSize = 20d,
                    FontAttributes = FontAttributes.Bold,
                    VerticalTextAlignment = TextAlignment.Center,
                };

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
