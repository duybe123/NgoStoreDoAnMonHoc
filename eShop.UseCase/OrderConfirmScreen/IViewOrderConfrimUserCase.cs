using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.OrderConfirmScreen
{
    public interface IViewOrderConfrimUserCase
    {
        Order Execute(string uniqueId);
    }
}