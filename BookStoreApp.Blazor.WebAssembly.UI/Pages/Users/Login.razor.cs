using BookStoreApp.Blazor.WebAssembly.UI.Services.Authentication;
using BookStoreApp.Blazor.WebAssembly.UI.Services.Base;
using Microsoft.AspNetCore.Components;
using System;

namespace BookStoreApp.Blazor.WebAssembly.UI.Pages.Users
{
    public partial class Login
    {
        [Inject] IAuthenticationService authService { get; set; }
        [Inject] NavigationManager navManager { get; set; }

        LoginUserDto LoginModel = new LoginUserDto();
        string message = string.Empty;
        public async Task HandleLogin()
        {

            var response = await authService.AuthenticateAsync(LoginModel);

            if (response.Success)
            {
                navManager.NavigateTo("/");
            }
            message = response.Message;
        }
    }
}
