﻿namespace Menager.Dtos.RequestDto
{
    public class UpdatePurchaseOrderDetailRequestDto
    {
        public Guid Id { get; set; }
        public int CargoStatusId { get; set; }
        public string? DestinationBranch { get; set; }
        public string? CargoNumber { get; private set; }
        public int PurchaseOrderStatusId { get; set; }
    }
}
