namespace Menager.Dtos.RequestDto
{
    public class CreateSupplierRequestDto
    {
        public Guid UserId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string SupplierLocation { get; set; }
    }
}
