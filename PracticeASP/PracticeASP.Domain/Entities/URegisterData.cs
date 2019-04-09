using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeASP.Domain.Entities
{
    public class URegisterData
    {
        public string Name { get; set; }
        public string Prenumele { get; set; }
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string IP_address { get; set; }
        public DateTime LastAuthDate { get; set; }
    }
}
