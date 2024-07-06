using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUserCase
    {
        Task<Order> Execute(int productId, int quatity);
    }
}