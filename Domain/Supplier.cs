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
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public string SupplierLocation { get; private set; }
        public Supplier(string supplierName, string supplierDescription, string email, string password, string phone, string supplierLocation)
        {
            Id = Guid.NewGuid();
            SupplierName = supplierName;
            SupplierDescription = supplierDescription;
            IsActive = true;
            Email = email;
            Phone = phone;
            SupplierLocation = supplierLocation;
            Password = password;
        }
        public void UpdateSupplier(string supplierName, string supplierDescription, string phone, string supplierLocation)
        {
            SupplierName = supplierName;
            SupplierDescription = supplierDescription;
            IsActive = true;
            Phone = phone;
            SupplierLocation = supplierLocation;
        }
        public void UpdateEmailPassword(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
