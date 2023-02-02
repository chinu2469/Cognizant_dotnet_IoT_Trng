using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class CustDashboard
    {
        [Key]
        public int TaskId { get; set; }

        public string? Type { get; set; }
        [Required]
        public int UserAsgnId { get; set; }
        [Required]
        public int AssetAsgnId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Cost { get; set; }
    }
}


//TaskId	Type	UserAsgnId	AssetAsgnId	DueDate	StartDate	EndDate	Cost