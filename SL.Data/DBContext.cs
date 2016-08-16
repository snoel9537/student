using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace SL.Data
{
    public class DBContext : DbContext
    {
        public DbSet<ClientDTO> Clients { get; set; }
        public DbSet<ManagerDTO> Managers { get; set; }
        public DbSet<OrganizationDTO> Organizations { get; set; }
        public DbSet<PhoneDTO> Phones { get; set; }
        public DbSet<PhoneTypeDTO> PhoneTypes { get; set; }
        public DbSet<RoleDTO> Roles { get; set; }

    }
}
