using AutoMapper;
using Domain;
using Menager.Dtos.ResponseDto;

namespace Menager
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Item, GetItemByIdResponseDto>()
            .ForMember(destinationMember => destinationMember.SupplierItemLists, operation => operation.MapFrom(sourceMember => sourceMember.SupplierItems));

            CreateMap<Item, GetItemByParametersResponseDto>();
            CreateMap<Notification, GetNotificationResponseDto>();
            CreateMap<PurchaseOrder, GetPurchaseOrderByIdResponseDto>()
                .ForMember(destinationMember => destinationMember.PurchaseOrderDetailList, operation => operation.MapFrom(sourceMember => sourceMember.PurchaseOrderDetail));
            CreateMap<User, GetUserByParametersResponseDto>();
            CreateMap<SupplierItem, GetItemSuppliersWithItemIdResponseDto>();
        }
    }
}
