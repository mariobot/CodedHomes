using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace CodedHomes.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(30,ErrorMessage="Max 30 Characters")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(30,ErrorMessage="Max 30 Characters")]
        public string Username { get; set; }

        [MaxLength(15, ErrorMessage = "Max 15 Characters")]
        public string document { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [MaxLength(15, ErrorMessage = "Max 15 Characters")]
        public string phone { get; set; }
    }
}
