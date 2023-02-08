using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Info_APP.Models
{
    public class Vehicle
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string StatePassing { get; set; } = string.Empty;

        public string RegionalCode { get; set; } = string.Empty;

        public string Alphabets { get; set; } = string.Empty;
        public string VehicleNumber { get; set; } = string.Empty;
        public string UserState { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
    }
}
