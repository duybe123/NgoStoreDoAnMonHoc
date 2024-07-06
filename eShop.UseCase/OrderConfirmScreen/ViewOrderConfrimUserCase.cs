using NguyenVinhDuy.CoreBusiness.Model;
using NguyenVinhDuy.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVinhDuy.UseCase.OrderConfirmScreen
{
    public class ViewOrderConfrimUserCase : IViewOrderConfrimUserCase
    {
        private readonly IOrderRespository _oderRepository;
        public ViewOrderConfrimUserCase(IOrderRespository orderRespository)
        {
            this._oderRepository = orderRespository;
        }
        public Order Execute(string uniqueId)
        {
            return _oderRepository.GetOrderByUniqueId(uniqueId);
        }
    }
}
