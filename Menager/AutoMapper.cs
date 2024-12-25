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
            CreateMap<SupplierItem, SupplierItemListResponseDto>();

            CreateMap<Item, GetItemByParametersResponseDto>();
            CreateMap<Notification, GetNotificationResponseDto>();
            CreateMap<PurchaseOrder, GetPurchaseOrderByIdResponseDto>()
                .ForMember(destinationMember => destinationMember.PurchaseOrderDetailList, operation => operation.MapFrom(sourceMember => sourceMember.PurchaseOrderDetail));
            CreateMap<PurchaseOrderDetail, PurchaseOrderDetailResponseDto>();
            CreateMap<User, GetUserByParametersResponseDto>();
            CreateMap<SupplierItem, GetItemSuppliersWithItemIdResponseDto>();
        }
    }
}
