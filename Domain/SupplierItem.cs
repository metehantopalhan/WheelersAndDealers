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
        internal SupplierItem(Guid itemId, Guid supplierId, double price, string supplierName, string itemName)
        {
            Id = Guid.NewGuid();
            ItemId = itemId;
            SupplierId = supplierId;
            Price = price;
            SupplierName = supplierName;
            ItemName = itemName;
            IsActive = true;
        }

        public void UpdateSupplierItem(bool isActive, double price, string supplierName, string itemName)
        {
            IsActive = isActive;
            Price= price;
            SupplierName = supplierName;
            ItemName = itemName;
        }

    }
}
