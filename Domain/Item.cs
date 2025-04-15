using Common;
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
        public Guid SellerUserId { get; private set; }
        public string ItemName { get; private set; }
        public double Price { get; private set; }
        public ItemBrand CarBrand { get; private set; }
        public int ItemBrandId
        {
            get { return (int)this.CarBrand; }
            set { CarBrand = (ItemBrand)value; }
        }

        public ItemType ItemType { get; private set; }
        public int ItemTypeId
        {
            get { return (int)this.ItemType; }
            set { ItemType = (ItemType)value; }
        }
        public bool IsActive { get; private set; }
        public string ItemDescription { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string? ImageName { get; private set; }
        public byte[]? Data { get; private set; }
        public string SearchText { get; private set; }
        public Model ItemModel { get; private set; }
        public int ItemModelId
        {
            get { return (int)this.ItemModelId; }
            set { ItemModel = (Model)value; }
        }
        //public List<SupplierItem> SupplierItems { get; set; } = new List<SupplierItem>();
        public void UpdateImage(string? imageName, byte[]? data)
        {
            ImageName = ItemName;
            Data = data;
        }
        public Item(Guid sellerUserId, string itemName, string itemDescription, int itemBrandId, int itemModelId, int itemType, int price)
        {
            Id = Guid.NewGuid();
            SellerUserId = sellerUserId;
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemBrandId = itemBrandId;
            ItemModelId = itemModelId;
            ItemTypeId = itemType;
            IsActive = true;
            Price = price;
            SearchText = ItemName.ToUpper() + ItemDescription.ToUpper() + ItemModel.ToString().ToUpper() + itemBrandId.ToString().ToUpper();
            CreateDate = DateTime.Now;
        }
        public void UpdateItem(string itemName, string itemDescription, int itemBrand, int itemModelId, int itemTypeId, bool isActive, int price)
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemTypeId |= itemTypeId;
            ItemBrandId = itemBrand;
            ItemModelId = itemModelId;
            IsActive = isActive;
            Price = price;
        }

        public void UpdateStatus(bool isActive)
        {
            IsActive = isActive;
        }

        //public SupplierItem AddSupplierItem(Guid supplierId, double price, string supplierName)
        //{
        //    var supplier = new SupplierItem(Id, supplierId, price, supplierName, ItemName);
        //    SupplierItems.Add(supplier);
        //    return supplier;
        //}
    }
}
