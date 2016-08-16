using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Data
{
    public class OrganizationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public virtual List<OrganizationDTO> Organisations { get; set; }
        public virtual List<ClientDTO> Clients { get; set; }


        public int ParentOrganizationId { get; set; }
        public virtual OrganizationDTO ParentOrganization { get; set; }
    }
}
