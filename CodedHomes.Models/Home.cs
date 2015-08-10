using System;
using System.ComponentModel.DataAnnotations;

namespace CodedHomes.Models
{
    public class Home : IAuditInfo
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100,ErrorMessage="Max 100 characters")]
        public string StreetAdress { get; set; }

        [MaxLength(100, ErrorMessage = "Max 100 characters")]
        public string StreetAdress2 { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Max 50 characters")]
        public string City { get; set; }
        
        [Required]
        public int ZipCode { get; set; }
        
        public int? Bathrooms { get; set; }
        
        public int? Bedrooms { get; set; }
        
        public int? SquareFeet { get; set; }
        
        public int? Price { get; set; }
        
        public string Description { get; set; }

        [MaxLength(200)]
        public string ImageName { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime ModifiedOn { get; set; }
    }
}
