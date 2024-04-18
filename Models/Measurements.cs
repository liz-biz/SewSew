using System.ComponentModel.DataAnnotations.Schema;

namespace SewSew.Models
{
    public class Measurements
    {
        public int MeasurementsId { get; set; }
        public double Bust {  get; set; }
        public double Waist { get; set; }
        public double Hips { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client client { get; set; }
    }
}
