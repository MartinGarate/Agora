using MovilApp.ViewModels;
using MovilApp.Views.Login;

namespace MovilApp.Views;

public partial class AgoraShell : Shell
{
    // Aseg�rate de que el archivo AgoraShell.xaml tenga la directiva x:Class="MovilApp.Views.AgoraShell"
    // y que exista un elemento con x:Name="FlyoutItemsPrincipal" en el XAML.

    public AgoraShell()
    {
        InitializeComponent(); // Este m�todo se genera autom�ticamente si el XAML est� correctamente vinculado.
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el men� lateral
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute("Registrarse", typeof(SignInView));
    }

    public void EnableAppAfterLogin()
    {
        FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
        FlyoutItemsPrincipal.IsVisible = true; // Muestra el men� lateral
        Shell.Current.GoToAsync("//MainPage"); // Navega a la p�gina principal
        var viewmodel = this.BindingContext as AgoraShellViewModel;
        viewmodel.UserIsLogout = false;
    }
    public void DisableAppAfterLogin()
    {
        FlyoutItemsPrincipal.IsVisible = false; // Oculta el men� lateral
        FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
        Shell.Current.GoToAsync("//Login"); // Navega a la p�gina de login
    }
}