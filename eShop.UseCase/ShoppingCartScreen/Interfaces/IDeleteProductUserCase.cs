using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IDeleteProductUserCase
    {
        Task<Order> Execute(int productId);
    }
}