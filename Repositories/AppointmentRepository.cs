using SewSew.Data;
using SewSew.Models;

namespace SewSew.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _dbContext;
        public AppointmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Appointment> IAppointmentRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Appointment> IAppointmentRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
