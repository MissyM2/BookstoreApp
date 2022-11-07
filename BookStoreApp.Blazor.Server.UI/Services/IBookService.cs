using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services
{
    public interface IBookService
    {
        Task<Response<List<BookReadOnlyDto>>> Get();
        Task<Response<BookDetailsDto>> Get(int id);
        Task<Response<BookUpdateDto>> GetBookForUpdate(int id);
        Task<Response<int>> Create(BookCreateDto book);
        Task<Response<int>> Edit(int id, BookUpdateDto book);
        Task<Response<int>> Delete(int id);

    }
}
