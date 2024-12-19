namespace Menager.Dtos.RequestDto
{
    public class UpdateSuppplierRequestDto
    {
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public bool IsActive { get; set; }
        public SupplierContactInformationRequest UpdateSupplierContactInformation {  get; set; }
    }
}
