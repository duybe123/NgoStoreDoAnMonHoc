using NguyenVinhDuy.CoreBusiness.Model;
using NguyenVinhDuy.UseCase.AdminPortal.OrderDetailsScreen.interfaces;
using NguyenVinhDuy.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVinhDuy.UseCase.AdminPortal.OrderDetailsScreen  
{
    public class ViewOrderDetailUserCase : IViewOrderDetailUserCase
    {
        private readonly IOrderRespository _orderRespository;
        public ViewOrderDetailUserCase(IOrderRespository orderRespository)
        {
            this._orderRespository = orderRespository;
        }
        public Order Execute(int orderId)
        {

            return _orderRespository.GetOrder(orderId);
        }
    }
}
