using SewSew.Models;

namespace SewSew.Repositories
{
    public interface IMeasurementRepository
    {
        Task<Measurement> GetByIdAsync(int id);
        IEnumerable<Measurement> GetAllAsync();
        Task AddAsync(Measurement measurement);
        Task UpdateAsync(Measurement measurement);
        Task DeleteAsync(int Id);
    }
}
