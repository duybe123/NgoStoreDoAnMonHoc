using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUserCase
    {
        Task<Order> Execute();
    }
}