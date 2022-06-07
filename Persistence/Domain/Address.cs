using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.API.Persistence.Domain
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Municipality { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Sector { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string StreetName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string ZipCode { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? AddressDescription { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
    }
}
