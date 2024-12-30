using AutoMapper;
using Common;
using Data;
using Domain;
using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;
using System.Runtime.InteropServices;

namespace Menager
{
    public class SparePartsMenager : ISpareParts
    {
        private readonly IMapper _mapper;
        private readonly ISparePartsData _sparePartsData;
        public SparePartsMenager(IMapper mapper, ISparePartsData sparePartsData)
        {
            _mapper = mapper;
            _sparePartsData = sparePartsData;
        }
        public async Task<(string, bool)> CreateItem(CreateItemRequestDto requestDto)
        {
            var admin = await _sparePartsData.getAdminById(requestDto.UserId);
            if (admin == null)
            {
                return ("You are not allowed to do this action", false);
            }

            Item item = new Item(requestDto.ItemName, requestDto.ItemDescription, requestDto.ItemTypeId, requestDto.CarBrandId, requestDto.ProductCode, requestDto.GuaranteeTime, requestDto.Category, requestDto.Origin, requestDto.Year);
            await _sparePartsData.CreateItem(item);
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task CreateNotification(CreateNotificationRequestDto requestDto)
        {
            var notification = new Notification(requestDto.DestinatonPersonId, requestDto.UserId, requestDto.Description);
            await _sparePartsData.CreateNotification(notification);
            await _sparePartsData.PersistAsync();
        }

        public async Task<(string, bool)> CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto)
        {
            var user = await _sparePartsData.getUserById(requestDto.UserId);
            if (user == null)
            {
                return ("You are not allowed to do this action", false);
            }

            PurchaseOrder purchaseOrder = new PurchaseOrder(requestDto.UserId, requestDto.PurchaseOrderPrice, requestDto.TitleOfDestinationAddress, requestDto.TitleOfBill, requestDto.DestinationAddressDescription, requestDto.BillDescription);
            user.AddPurchaseOrder(purchaseOrder);
            await _sparePartsData.CreatePurchaseOrder(purchaseOrder);
            await _sparePartsData.PersistAsync();

            foreach (var purchaseOrderDetail in requestDto.PurchaseOrderDetailList)
            {
                var detail = purchaseOrder.AddPurchaseOrderDetail(purchaseOrder.Id, purchaseOrderDetail.SupplierItemId, purchaseOrderDetail.ItemId, purchaseOrderDetail.Quantity, purchaseOrderDetail.PurchaseOrderDetailPrice);
                await _sparePartsData.CreatePurchaseOrderDetail(detail);
            }
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task<(string, bool)> CreateSupplier(CreateSupplierRequestDto requestDto)
        {
            var admin = await _sparePartsData.getAdminById(requestDto.UserId);
            if (admin == null)
            {
                return ("You are not allowed to do this action", false);
            }

            var supplier = new Supplier(requestDto.SupplierName, requestDto.SupplierDescription, requestDto.Email, requestDto.Password, requestDto.Phone, requestDto.SupplierLocation);
            await _sparePartsData.CreateSupplier(supplier);
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task CreateUser(CreateUserRequestDto requestDto)
        {
            var user = new User(requestDto.Name, requestDto.Surname, requestDto.Email, requestDto.Password);
            await _sparePartsData.CreateUser(user);
            await _sparePartsData.PersistAsync();
        }

        public async Task<GetItemByIdResponseDto> GetItemById(Guid id)
        {
            var item = await _sparePartsData.getItemById(id);
            return _mapper.Map<GetItemByIdResponseDto>(item);
        }

        public async Task<List<GetItemByParametersResponseDto>> GetItemByParameters(string? searchText, bool? isActive, int skip, int take, int? itemType, int? brandId)
        {
            var itemList = await _sparePartsData.getItemByParameters(searchText, isActive, skip, take, itemType, brandId);
            return _mapper.Map<List<GetItemByParametersResponseDto>>(itemList);
        }

        public async Task<GetNotificationResponseDto> GetNotificationsById(Guid id)
        {
            var notification = await _sparePartsData.getNotificationById(id);
            return _mapper.Map<GetNotificationResponseDto>(notification);
        }

        public async Task<GetPurchaseOrderByIdResponseDto> GetPurchaseOrderById(Guid id)
        {
            var purchaseOrder = await _sparePartsData.getPurchaseOrderById(id);
            return _mapper.Map<GetPurchaseOrderByIdResponseDto>(purchaseOrder);
        }

        public async Task<GetUserByParametersResponseDto> GetUsers()
        {
            var users = await _sparePartsData.getUsers();
            return _mapper.Map<GetUserByParametersResponseDto>(users);
        }

        public async Task<Guid?> LoginForAdmin(string email, string password)
        {
            return await _sparePartsData.GetAdminByMailAndPassword(email, password);
        }
        public async Task<Guid?> LoginForUser(string email, string password)
        {
            return await _sparePartsData.GetUserByMailAndPassword(email, password);
        }
        public async Task<Guid?> LoginForSupplier(string email, string password)
        {
            return await _sparePartsData.GetUserByMailAndPassword(email, password);
        }

        public async Task<(string, bool)> UpdateItem(UpdateItemRequestDto requestDto)
        {
            var admin = await _sparePartsData.getAdminById(requestDto.UserId);
            if (admin == null)
            {
                return ("You are not allowed to do this action", false);
            }
            Item item = await _sparePartsData.getItemById(requestDto.ItemId);
            item.UpdateItem(requestDto.ItemName, requestDto.ItemDescription, requestDto.ItemType, requestDto.ProductCode, requestDto.GuaranteeTime, requestDto.IsActive, requestDto.Category, requestDto.Origin, requestDto.Year);
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task<(string, bool)> CreateItemSupplierRelation(CreateSupplierItemRelationRequestDto requestDto)
        {
            var admin = await _sparePartsData.getAdminById(requestDto.UserId);
            if (admin == null)
            {
                return ("You are not allowed to do this action", false);
            }
            Item item = await _sparePartsData.getItemById(requestDto.ItemId);
            var supplierItem = item.AddSupplierItem(requestDto.SupplierId, requestDto.Price, requestDto.SupplierName);
            await _sparePartsData.CreateSupplierItem(supplierItem);
            await _sparePartsData.PersistAsync();
            return ("", true);

        }

        public async Task UpdateNotification(UpdateNotificationRequestDto requestDto)
        {
            Notification notification = await _sparePartsData.getNotificationById(requestDto.Id);
            notification.UpdateNotification(requestDto.Description, requestDto.HasRead);
            await _sparePartsData.PersistAsync();
        }

        public async Task<(string, bool)> UpdatePurchaseOrder(UpdatePurchaseOrderRequestDto requestDto)
        {
            var purchaseOrder = await _sparePartsData.getPurchaseOrderById(requestDto.Id);
            if (purchaseOrder is null)
            {
                throw new Exception("Purchase order could not be found");
            }
            foreach (var purchaseOrderDetail in purchaseOrder.PurchaseOrderDetail)
            {
                var detail = requestDto.UpdatePurchaseOrderList.FirstOrDefault(x => x.Id == purchaseOrderDetail.Id);
                if (detail == null)
                {
                    return ("Related detail could not be found", false);
                }
                purchaseOrderDetail.UpdatePurchaseOrderDetail(detail.CargoStatusId, detail.DestinationBranch ?? " ", detail.CargoNumber ?? " ", detail.PurchaseOrderStatusId);
            }
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task<(string, bool)> UpdateSupplier(UpdateSuppplierRequestDto requestDto)
        {
            var admin = await _sparePartsData.getAdminById(requestDto.UserId);
            if (admin == null)
            {
                return ("You are not allowed to do this action", false);
            }
            var supplier = await _sparePartsData.getSupplierById(requestDto.Id);
            if (supplier == null)
            {
                return ("Supplier could not be found", false);
            }

            supplier.UpdateSupplier(requestDto.SupplierName, requestDto.SupplierDescription, requestDto.Phone, requestDto.SupplierLocation);
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task<(string, bool)> UpdateSupplierItem(UpdateSupplierItemRequestDto requestDto)
        {
            var admin = await _sparePartsData.getAdminById(requestDto.UserId);
            if (admin == null)
            {
                throw new Exception("You are not allowed to do this action");
            }
            var supplierItem = await _sparePartsData.getSupplierItemById(requestDto.Id);
            if (supplierItem == null)
            {
                return ("Supplier could not be found", false);
            }

            supplierItem.UpdateSupplierItem(requestDto.IsActive, requestDto.Price, requestDto.SupplierName, requestDto.ItemName);
            await _sparePartsData.PersistAsync();
            return ("", true);
        }

        public async Task UpdateUser(UpdateUserRequestDto requestDto)
        {
            var user = await _sparePartsData.getUserById(requestDto.Id);
            if (user == null)
            {
                throw new Exception("User could not be found");
            }
            user.UpdateUser(requestDto.Name, requestDto.Surname, requestDto.Email, requestDto.Password);
            await _sparePartsData.PersistAsync();
        }

        public async Task UploadImage(UploadImageRequestDto requestDto)
        {
            var item = await _sparePartsData.getItemById(requestDto.Id);
            if (item is null)
            {
                throw new Exception("Item could not be found");
            }
            item.UpdateImage(item.ItemName, requestDto.ImageData);
            await _sparePartsData.PersistAsync();
        }
        public async Task DeleteImage(Guid id)
        {
            var item = await _sparePartsData.getItemById(id);
            if (item is null)
            {
                throw new Exception("Item could not be found");
            }
            item.UpdateImage(null, null);
            await _sparePartsData.PersistAsync();
        }

        public async Task<List<GetItemSuppliersWithItemIdResponseDto>> GetItemSupplierByItemId(Guid id)
        {
            List<SupplierItem> itemSupplier = await _sparePartsData.getSupplierItemByItemId(id);
            return _mapper.Map<List<GetItemSuppliersWithItemIdResponseDto>>(itemSupplier);
        }
    }
}
