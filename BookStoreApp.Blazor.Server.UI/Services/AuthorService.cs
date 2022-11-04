using Blazored.LocalStorage;
using BookStoreApp.Blazor.Server.UI.Services.Base;
using Microsoft.AspNetCore.Authorization;

namespace BookStoreApp.Blazor.Server.UI.Services
{
    public class AuthorService : BaseHttpService, IAuthorService
    {
        private readonly IClient client;
        public AuthorService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this.client = client;

        }

        public async Task<Response<List<AuthorReadOnlyDto>>> GetAuthors()
        {
            Response<List<AuthorReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.AuthorsAllAsync();
                response = new Response<List<AuthorReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {

                response = ConvertApiExceptions<List<AuthorReadOnlyDto>>(exception);
            }
            return response;
        }
    }
}
