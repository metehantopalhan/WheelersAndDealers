using Data.DbContextLib;
using Domain;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Data
{
    public class SparePartsData : ISparePartsData
    {
        private SqlDbContext _dbContext;
        public SparePartsData(SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Admin> getAdminById(Guid id)
        {
            return await _dbContext.Admins.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Admin>> getAdmins()
        {
            return await _dbContext.Admins.ToListAsync();
        }

        public async Task<Item> getItemById(Guid id)
        {
            return await _dbContext.Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Item>> getItemByParameters(string? searchText, bool? isActive, int skip, int take)
        {
            var predicate = PredicateBuilder.New<Item>(true);

            if (searchText != null)
            {
                predicate.And(x => x.SearchText.Contains(searchText.ToUpper()));
            }
            if (isActive != null)
            {
                predicate.And(x => x.IsActive == isActive);
            }
            else
            {
                predicate.And(x => x.IsActive == true);
            }
            return await _dbContext.Items.Where(predicate).Skip(skip).Take(take).OrderBy(x => x.ItemName).ToListAsync();

        }

        public async Task<List<Item>> getItems()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public async Task<PurchaseOrder> getPurchaseOrderById(Guid id)
        {
            return await _dbContext.PurchaseOrders.Include(x => x.PurchaseOrderDetail).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid?> GetAdminByMailAndPassword(string email, string password)
        {
            var admin = await _dbContext.Admins.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            return admin != null ? admin.Id : null;
        }

        public async Task<Guid?> GetUserByMailAndPassword(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            return user != null ? user.Id : null;
        }
        public async Task<Guid?> GetSupplierByMailAndPassword(string email, string password)
        {
            var supplier = await _dbContext.Suppliers.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            return supplier != null ? supplier.Id : null;
        }

        public async Task<List<PurchaseOrder>> getPurchaseOrders()
        {
            return await _dbContext.PurchaseOrders.ToListAsync();
        }

        public async Task<User> getUserById(Guid id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<User>> getUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<Supplier> getSupplierById(Guid id)
        {
            return await _dbContext.Suppliers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<SupplierItem>> getSupplierContactInformations()
        {
            return await _dbContext.SupplierItems.ToListAsync();
        }

        public async Task<SupplierItem> getSupplierItemById(Guid id)
        {
            return await _dbContext.SupplierItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Supplier>> getSuppliers()
        {
            return await _dbContext.Suppliers.ToListAsync();
        }

        public async Task<List<Notification>> getNotifications()
        {
            return await _dbContext.Notifications.ToListAsync();
        }
        public async Task<Notification> getNotificationById(Guid id)
        {
            return await _dbContext.Notifications.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task PersistAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task CreateNotification(Notification notification)
        {
            await _dbContext.Notifications.AddAsync(notification);
        }

        public async Task CreateItem(Item item)
        {
            await _dbContext.AddAsync(item);
        }

        public async Task CreateSupplier(Supplier supplier)
        {
            await _dbContext.Suppliers.AddAsync(supplier);
        }

        public async Task CreateSupplierItem(SupplierItem supplierItem)
        {
            await _dbContext.SupplierItems.AddAsync(supplierItem);
        }

        public async Task CreatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            await _dbContext.PurchaseOrders.AddAsync(purchaseOrder);
        }

        public async Task CreateUser(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public async Task UploadImageForItem(Guid id, string imageName, byte[] data)
        {
            var item = await getItemById(id);
            item.UpdateImage(imageName, data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteImageForItem(Guid id)
        {
            var item = await getItemById(id);
            item.UpdateImage(null, null);
            await _dbContext.SaveChangesAsync();
        }
    }
}
