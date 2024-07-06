using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.AdminPortal.ProcessedOrderScreen
{
    public interface IViewPrcessedOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}