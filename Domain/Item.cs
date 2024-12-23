﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {
        private Item()
        {

        }
        public Guid Id { get; private set; }
        public string ItemName { get; private set; }
        public ItemType ItemType { get; private set; }
        public CarBrand CarBrand { get; private set; }
        public int CarBrandId
        {
            get { return (int)this.ItemType; }
            set { CarBrand = (CarBrand)value; }
        }
        public bool IsActive { get; private set; }
        public int ItemTypeId
        {
            get { return (int)this.ItemType; }
            set { ItemType = (ItemType)value; }
        }
        public string ItemDescription { get; private set; }
        public string ProductCode { get; private set; }
        public string GuaranteeTime { get; private set; }
        public string? ImageName { get; private set; }
        public byte[]? Data { get; private set; }
        public string SearchText { get; private set; }
        public List<SupplierItem> SupplierItems = new List<SupplierItem>();
        public void UpdateImage(string? imageName, byte[]? data)
        {
            ImageName = ItemName;
            Data = data;
        }
        public Item(string itemName, string itemDescription, int itemType, int carBrandId, string productCode, string guaranteeTime)
        {
            Id = Guid.NewGuid();
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemTypeId = itemType;
            ProductCode = productCode;
            CarBrandId = CarBrandId;
            IsActive = true;
            GuaranteeTime = guaranteeTime;
            SearchText = ItemName.ToUpper() + ItemDescription.ToUpper() + ProductCode.ToUpper();
        }
        public void UpdateItem(string itemName, string itemDescription, int itemType, string productCode, string guaranteeTime, bool isActive)
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemTypeId = itemType;
            ProductCode = productCode;
            IsActive = isActive;
        }

        public void AddSupplierItem(Guid supplierId, double price, string supplierName)
        {
            SupplierItems.Add(new SupplierItem(Id, supplierId, price, supplierName, ItemName));
        }
    }
}
