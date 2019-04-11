using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PracticeASP.Domain.Entities;

namespace PracticeASP.BussinesLogic.DBModels
{
    public class TW_LABORATORIES : DbContext
    {
        public TW_LABORATORIES() : base("name=DefaultConnection"){
        }
        public DbSet<URegisterData> Users { get; set; }
    }
}
