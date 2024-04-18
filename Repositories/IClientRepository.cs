using SewSew.Models;
namespace SewSew.Repositories
{
    public interface IClientRepository
    {
        Task<Client> GetByIdAsync(int id);
        IEnumerable<Client> GetAllAsync();
        Task AddAsync(Client client);
        Task UpdateAsync(Client client);
        Task DeleteAsync(int Id);
    }
}
