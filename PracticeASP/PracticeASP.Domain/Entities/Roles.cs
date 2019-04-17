using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeASP.Domain.Entities
{
    public class Roles
    {   
        [Key]
        public int RoleID { get; set; }
        public string Role { get; set; }
    }
}
