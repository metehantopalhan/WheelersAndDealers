namespace Menager.Dtos.RequestDto
{
    public class UpdateSupplierItemRequestDto
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public double Price { get; set; }
        public string SupplierName { get; set; }
        public string ItemName { get; set; }
        public bool IsActive { get; set; }
    }
}
