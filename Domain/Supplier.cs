namespace Domain
{
    public class Supplier
    {
        private Supplier()
        {

        }
        public Guid Id { get; private set; }
        public string SupplierName { get; private set; }
        public string SupplierDescription { get; private set; }
        public bool IsActive { get; private set; }
        public SupplierContactInformation SupplierContactInformation { get; private set; }
    }
}
