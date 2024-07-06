using NguyenVinhDuy.CoreBusiness.Model;

namespace NguyenVinhDuy.UseCase.AdminPortal.OutStandingOrderScreen
{
    public interface IViewOutStandingOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}