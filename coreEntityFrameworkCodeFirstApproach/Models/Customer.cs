using System.ComponentModel.DataAnnotations;

namespace coreEntityFrameworkCodeFirstApproach.Models
{
    public class Customer
    {
        [Key]
        public int CustorerId { get; set; }
        public string? CustomerName { get; set; }
        public double  CustomerAmount { get; set; }

    }
}
