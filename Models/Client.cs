using System.ComponentModel.DataAnnotations.Schema;

namespace SewSew.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("Measurements")]
        public int MeasurementsId {  get; set; }
        public Measurements measurements { get; set; }
        public IEnumerable<Appointments> appointments { get; set; }
    }
}
