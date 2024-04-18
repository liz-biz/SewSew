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
        public Measurement measurements { get; set; }
        public IEnumerable<Appointment> appointments { get; set; }
    }
}
