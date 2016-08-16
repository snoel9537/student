using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Data
{
    public class ManagerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RoleId { get; set; }
        public virtual RoleDTO Role { get; set; }
    }
}