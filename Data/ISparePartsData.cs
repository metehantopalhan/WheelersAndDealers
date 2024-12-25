using Domain;

namespace Data
{
    public interface ISparePartsData
    {
        Task<User> getUserById(Guid id);
        Task<PurchaseOrder> getPurchaseOrderById(Guid id);
        Task<Item> getItemById(Guid id);
        Task<Admin> getAdminById(Guid id);
        Task<Supplier> getSupplierById(Guid id);
        Task<SupplierItem> getSupplierItemById(Guid id);
        Task<List<SupplierItem>> getSupplierItemByItemId(Guid id);
        Task<List<User>> getUsers();
        Task<List<PurchaseOrder>> getPurchaseOrders();
        Task<List<Item>> getItems();
        Task<List<Admin>> getAdmins();
        Task<List<Supplier>> getSuppliers();
        Task<List<SupplierItem>> getSupplierContactInformations();
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
        Task CreateUser(User user);
        Task<List<Item>> getItemByParameters(string? searchText, bool? isActive, int skip, int take);
        Task<Guid?> GetAdminByMailAndPassword(string email, string password);
        Task<Guid?> GetUserByMailAndPassword(string email, string password);
        Task<Guid?> GetSupplierByMailAndPassword(string email, string password);
        Task CreatePurchaseOrderDetail(PurchaseOrderDetail purchaseOrderdetail);
    }
}
