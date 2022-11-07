using BookStoreApp.Blazor.WebAssembly.UI.Services.Base;

namespace BookStoreApp.Blazor.WebAssembly.UI.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
        Task<Response<AuthorDetailsDto>> GetAuthor(int id);
        Task<Response<AuthorUpdateDto>> GetAuthorForUpdate(int id);
        Task<Response<int>> CreateAuthor(AuthorCreateDto author);
        Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author);
    }
}
