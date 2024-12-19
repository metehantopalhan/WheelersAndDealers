using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;

namespace Menager
{
    public interface ISpareParts
    {
        Task<Guid> Login(string mail, string password);
        Task CreateItem(CreateItemRequestDto requestDto);
        Task UpdateItem(UpdateItemRequestDto requestDto);
        Task<List<GetItemByParametersResponseDto>> GetItemByParameters(string? searchText, bool? isActive, int? skip, int? take);
        Task<GetItemByIdResponseDto> GetItemById(Guid id);
        Task UploadImage(UploadImageRequestDto requestDto);
        Task CreateNotification(CreateNotificationRequestDto requestDto);
        Task UpdateNotification(UpdateNotificationRequestDto requestDto);
        Task<GetNotificationResponseDto> GetNotificationsById(Guid id);
        Task CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto);
        Task UpdatePurchaseOrder(UpdatePurchaseOrderRequestDto requestDto);
        Task<GetPurchaseOrderByIdResponseDto> GetPurchaseOrderById(Guid id);
        Task CreateSupplier(CreateSupplierRequestDto requestDto);
        Task UpdateSupplier(UpdateSuppplierRequestDto requestDto);
        Task CreateUser(CreateUserRequestDto requestDto);
        Task UpdateUser(UpdateUserRequestDto requestDto);
        Task CreateSupplierItem(CreateSupplierItemRequestDto requestDto);
        Task UpdateSupplierItemRequestDto(UpdateSupplierItemRequestDto requestDto);
        Task<GetUserByMailPasswordResponseDto> GetUserByMailPasswarord(GetUserRequestdto requestdto);
        Task<GetUserByParametersResponseDto> GetUsers();
    }
}
