using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SupplierContactInformation
    {
        private SupplierContactInformation()
        {

        }
        public Guid Id { get; private set; }
        public Guid SupplierId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string SupplierLocation { get; private set; }
    }
}
