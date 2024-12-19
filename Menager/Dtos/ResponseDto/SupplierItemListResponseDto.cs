namespace Menager.Dtos.ResponseDto
{
    public class SupplierItemListResponseDto
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }
        public string SupplierName { get; set; }
    }
}
