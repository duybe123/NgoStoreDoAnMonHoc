using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IPlaceOrderUserCase
    {
        Task<string> Execute(Order order);
    }
}