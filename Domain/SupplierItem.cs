namespace Domain
{
    public class SupplierItem
    {
        private SupplierItem()
        {

        }
        public Guid Id { get; private set; }
        public Guid ItemId { get; private set; }
        public Item Item { get; private set; }
        public Guid SupplierId { get; private set; }
        public Supplier Supplier { get; private set; }
        public bool IsActive { get; private set; }
        public double Price { get; private set; }
        public string SupplierName { get; private set; }
        public string ItemName { get; private set; }
        
    }
}
