namespace Menager.Dtos.RequestDto
{
    public class UpdateSupplierItemRequestDto
    {
        public Guid ItemId { get; set; }
        public Guid SupplierId { get; set; }
        public double Price { get; set; }
        public string SupplierName { get; set; }
        public string ItemName { get; set; }
        public bool IsActive {  get; set; }
    }
}
