using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Data
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }

        public virtual List<PhoneDTO> Phones { get; set; }

        public int OrganizationId { get; set; }
        public virtual OrganizationDTO Organization { get; set; }

        public int ManagerId { get; set; }
        public virtual ManagerDTO Manager { get; set; }

    }
}
