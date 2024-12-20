using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menager.Dtos.RequestDto
{
    public class CreateSupplierItemRelationRequestDto
    {
        public Guid UserId { get; set; }
        public Guid ItemId { get; set; }
        public Guid SupplierId { get; set; }
        public double Price { get; set; }
        public string SupplierName { get; set; }
        public string ItemName { get; set; }
    }
}
