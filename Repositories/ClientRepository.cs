using SewSew.Data;
using SewSew.Models;

namespace SewSew.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _dbContext;
        public ClientRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
