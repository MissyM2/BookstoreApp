namespace BookStoreApp.Blazor.Server.UI.Services.Base
{
    public partial class Client : IClient
    {
        public HttpClient httpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}
