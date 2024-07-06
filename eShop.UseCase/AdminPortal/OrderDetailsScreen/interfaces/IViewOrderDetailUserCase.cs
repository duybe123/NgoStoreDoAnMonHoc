using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IViewOrderDetailUserCase
    {
        Order Execute(int orderId);
    }
}