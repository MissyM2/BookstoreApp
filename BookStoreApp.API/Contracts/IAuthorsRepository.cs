using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Repositories;

namespace BookStoreApp.API.Contracts
{
    public interface IAuthorsRepository : IGenericRepository<Author>
    {
        Task<AuthorDetailsDto> GetAuthorDetailsAsync(int id);
    }
}
