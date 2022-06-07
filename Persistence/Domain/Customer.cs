using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.API.Persistence.Domain
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(13)]
        public string IdentificationCard { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection<Address> Addresses { get; set; } 

        [Required]
        public DateTime RegisterDate { get; set; }

        public Customer()
        {
            Addresses = new List<Address>();
        }
    }
}
