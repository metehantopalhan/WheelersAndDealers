using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;

namespace Menager
{
    public interface ISpareParts
    {
        Task<Guid?> LoginForAdmin(string mail, string password);
        Task<(string, bool)> CreateItem(CreateItemRequestDto requestDto);
        Task<(string, bool)> UpdateItem(UpdateItemRequestDto requestDto);
        Task<List<GetItemByParametersResponseDto>> GetItemByParameters(string? searchText, bool? isActive, int skip, int take, int? itemType, int? brandId);
        Task<GetItemByIdResponseDto> GetItemById(Guid id);
        Task UploadImage(UploadImageRequestDto requestDto);
        Task CreateNotification(CreateNotificationRequestDto requestDto);
        Task UpdateNotification(UpdateNotificationRequestDto requestDto);
        Task<GetNotificationResponseDto> GetNotificationsById(Guid id);
        Task<(string, bool)> CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto);
        Task<(string, bool)> UpdatePurchaseOrder(UpdatePurchaseOrderRequestDto requestDto);
        Task<GetPurchaseOrderByIdResponseDto> GetPurchaseOrderById(Guid id);
        Task<(string, bool)> CreateSupplier(CreateSupplierRequestDto requestDto);
        Task<(string, bool)> UpdateSupplier(UpdateSuppplierRequestDto requestDto);
        Task CreateUser(CreateUserRequestDto requestDto);
        Task UpdateUser(UpdateUserRequestDto requestDto);
        Task<(string, bool)> UpdateSupplierItem(UpdateSupplierItemRequestDto requestDto);
        Task<List<GetItemSuppliersWithItemIdResponseDto>> GetItemSupplierByItemId(Guid id);
        Task<GetUserByParametersResponseDto> GetUsers();
        Task<Guid?> LoginForUser(string mail, string password);
        Task<Guid?> LoginForSupplier(string mail, string password);
        Task<(string, bool)> CreateItemSupplierRelation(CreateSupplierItemRelationRequestDto requestDto);
        Task DeleteImage(Guid id);
    }
}
