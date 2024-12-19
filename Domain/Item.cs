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
        public string ItemName { get; private set; }
        public ItemType ItemType { get; private set; }
        public bool IsActive { get; private set; }
        public int ItemTypeId
        {
            get { return (int)this.ItemType; }
            set { ItemType = (ItemType)value; }
        }
        public string ItemDescription { get; private set; }
        public string StockCode { get; private set; }
        public string GuaranteeTime { get; private set; }
        public string? ImageName { get; private set; }
        public byte[]? Data { get; private set; }
        public string SearchText { get; private set; }
        public List<SupplierItem> SupplierItems = new List<SupplierItem>();
        public void UpdateImage(string? imageName, byte[]? data)
        {
            ImageName = imageName;
            Data = data;
        }
    }
}
