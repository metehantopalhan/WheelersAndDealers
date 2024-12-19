using Domain;

namespace Data
{
    public interface ISparePartsData
    {
        public Task<User> getUserById(Guid id);
        public Task<PurchaseOrder> getPurchaseOrderById(Guid id);
        public Task<Item> getItemById(Guid id);
        public Task<Admin> getAdminById(Guid id);
        public Task<Supplier> getSupplierById(Guid id);
        public Task<SupplierContactInformation> getSupplierContactInformationById(Guid id);
        public Task<SupplierItem> getSupplierItemById(Guid id);
        public Task<List<User>> getUsers();
        public Task<List<PurchaseOrder>> getPurchaseOrders();
        public Task<List<Item>> getItems();
        public Task<List<Admin>> getAdmins();
        public Task<List<Supplier>> getSuppliers();
        public Task<List<SupplierContactInformation>> getSupplierConcactInformations();
        public Task<List<SupplierItem>> getSupplierContactInformations();
        public Task PersistAsync();
        Task<List<Notification>> getNotifications();
        Task<Notification> getNotificationById(Guid id);
        Task CreateNotification(Notification notification);
        Task CreateItem(Item item);
        Task CreateSupplier(Supplier supplier);
        Task CreateSupplierItem(SupplierItem supplierItem);
        Task CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        Task UploadImageForItem(Guid id, string imageName, byte[] data);
        Task DeleteImageForItem(Guid id);
    }
}
