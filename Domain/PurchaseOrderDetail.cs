﻿using Common;

namespace Domain
{
    public class PurchaseOrderDetail
    {
        private PurchaseOrderDetail()
        { 

        }
        public Guid Id { get;private set; }
        public Guid PurchaseOrderId { get; private set; }
        public PurchaseOrder PurchaseOrder { get; private set; }
        public Guid SupplierItemId { get; private set; }
        public SupplierItem SupplierItem { get; private set; }
        public int Quantity {  get; private set; }
        public CargoStatus CargoStatus { get; private set; }
        public int CargoStatusId
        {
            get { return (int)this.CargoStatusId; }
            set { CargoStatus = (CargoStatus)value; }
        }
        public string? DestinationBranch { get; private set; }
        public string? CargoNumber { get; private set; }
        public double PurchaseOrderDetailPrice {  get; private set; }
        public PurchaseOrderDetailStatus PurchaseOrderDetailStatus { get; private set; }
        public int PurchaseOrderDetailStatusId
        {
            get { return (int)this.PurchaseOrderDetailStatusId; }
            set { PurchaseOrderDetailStatus = (PurchaseOrderDetailStatus)value; }
        }
    }
}
