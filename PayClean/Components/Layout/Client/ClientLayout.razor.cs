using MudBlazor;
using MudBlazor.Utilities;

namespace PayClean.Components.Layout.Client;

public partial class ClientLayout
{
    private bool _drawerOpen = true;
    
    private static readonly MudColor PrimaryColor = new("#51a89b");
    
    private readonly MudTheme _myCustomTheme = new()
    {
        Palette = new PaletteLight()
        {
            Primary = PrimaryColor,
            AppbarBackground = PrimaryColor
        }
    };
    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    private void Logout()
    {
        Console.WriteLine("Saiu da aplicação");
    }
}