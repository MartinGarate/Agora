using MovilApp.ViewModels;
using MovilApp.Views.Login;

namespace MovilApp.Views;

public partial class AgoraShell : Shell
{
    // Asegúrate de que el archivo AgoraShell.xaml tenga la directiva x:Class="MovilApp.Views.AgoraShell"
    // y que exista un elemento con x:Name="FlyoutItemsPrincipal" en el XAML.

    public AgoraShell()
    {
        InitializeComponent(); // Este método se genera automáticamente si el XAML está correctamente vinculado.
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute("Registrarse", typeof(SignInView));
    }

    public void EnableAppAfterLogin()
    {
        FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
        FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
        Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
        var viewmodel = this.BindingContext as AgoraShellViewModel;
        viewmodel.UserIsLogout = false;
    }
    public void DisableAppAfterLogin()
    {
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
        FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
        Shell.Current.GoToAsync("//Login"); // Navega a la página de login
    }
}