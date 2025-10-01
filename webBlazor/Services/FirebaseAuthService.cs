using Microsoft.JSInterop;
using Service.Models.Login;

namespace webBlazor.Services
{
    public class FirebaseAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        public event Action OnChangeLogin;
        public FirebaseUser currentUser { get; set; }

        public FirebaseAuthService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<FirebaseUser> SignInWithEmailPassword(string email, string password, bool rememberPassword)
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser?>("firebaseAuth.signInWithEmailPassword", email, password, rememberPassword);
            if (user != null)
            {
                currentUser = user;
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<string> createUserWithEmailAndPassword(string email, string password, string displayName)
        {
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.createUserWithEmailAndPassword", email, password, displayName);
            if (userId != null)
            {
                OnChangeLogin?.Invoke();
            }
            return userId;
        }

        public async Task SignOut()
        {
            await _jsRuntime.InvokeVoidAsync("firebaseAuth.signOut");
            currentUser = null;

            OnChangeLogin?.Invoke();
        }

        public async Task<FirebaseUser?> GetUserFireBase()
        {
            var userFirebase = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.getUserFirebase");
            currentUser = userFirebase;
            return userFirebase;
        }

        public async Task<bool> IsUserAuthenticated()
        {
            var user = await GetUserFireBase();
            return user != null;
        }

        public async Task<FirebaseUser?> LoginWithGoogle()
        {
            var userFirebase = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithGoogle");

            currentUser = userFirebase;
            OnChangeLogin?.Invoke();
            return userFirebase;
        }
    }
}
