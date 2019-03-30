using System;
using System.ComponentModel.DataAnnotations;

namespace PracticeASP.Domain.Entities
{
    public class UAuthData
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string IP_address { get; set; }
        public DateTime LastAuthDate { get; set; }
    }
}
