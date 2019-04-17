using System;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace PracticeASP.Domain.Entities
{
    public class URegisterData
    {
        [Key]
        public string Name { get; set; }
        public string Prenumele { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IP_address { get; set; }
        public DateTime LastAuthDate { get; set; }
        public int RoleID { get; set; }
    }
}
