namespace NguyenVinhDuy.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}