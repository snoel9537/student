using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Data
{
    public class PhoneDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        
        public int TypeId { get; set; }
        public virtual PhoneTypeDTO Type { get; set; }

        public int ClientId { get; set; }
        public virtual ClientDTO Client { get; set; }
    }
}
