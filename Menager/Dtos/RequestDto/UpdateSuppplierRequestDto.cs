namespace Menager.Dtos.RequestDto
{
    public class UpdateSuppplierRequestDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string SupplierLocation { get; set; }
    }
}
