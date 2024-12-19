using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;

namespace Menager
{
    public class SparePartsMenager : ISpareParts
    {
        public Task CreateItem(CreateItemRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateNotification(CreateNotificationRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateSupplier(CreateSupplierRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateSupplierItem(CreateSupplierItemRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task CreateUser(CreateUserRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<GetItemByIdResponseDto> GetItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetItemByParametersResponseDto>> GetItemByParameters(string? searchText, bool? isActive, int? skip, int? take)
        {
            throw new NotImplementedException();
        }

        public Task<GetNotificationResponseDto> GetNotificationsById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GetPurchaseOrderByIdResponseDto> GetPurchaseOrderById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserByMailPasswordResponseDto> GetUserByMailPasswarord(GetUserRequestdto requestdto)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserByParametersResponseDto> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Login(string mail, string password)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItem(UpdateItemRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNotification(UpdateNotificationRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePurchaseOrder(UpdatePurchaseOrderRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSupplier(UpdateSuppplierRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSupplierItemRequestDto(UpdateSupplierItemRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UpdateUserRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task UploadImage(UploadImageRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
