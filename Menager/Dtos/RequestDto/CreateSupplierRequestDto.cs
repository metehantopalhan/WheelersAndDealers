namespace Menager.Dtos.RequestDto
{
    public class CreateSupplierRequestDto
    {
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public SupplierContactInformationRequest SupplierContactInformationRequest { get; set; }
    }
}
