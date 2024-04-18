using System.ComponentModel.DataAnnotations.Schema;

namespace SewSew.Models
{
    public class Appointments
    {
        public int AppointmentsId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double AppointmentTime { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client client { get; set; }
    }
}
