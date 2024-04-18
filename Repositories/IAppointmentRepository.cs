using SewSew.Models;

namespace SewSew.Repositories
{
    public interface IAppointmentRepository
    {
        Task<Appointment> GetByIdAsync(int id);
        IEnumerable<Appointment> GetAllAsync();
        Task AddAsync(Appointment appointment);
        Task UpdateAsync(Appointment appointment);
        Task DeleteAsync(int Id);
    }
}
