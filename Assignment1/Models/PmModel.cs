using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public partial class PmModel
    {
        [Key]
        public int PM_Id { get; set; }
        
        public string? PM_Name { get; set; }
        public string? Asset { get; set; }
        public string? Schedules { get; set; }
        public string? Assigned_To { get; set; }
        public string? Location { get; set; }
    }
}
