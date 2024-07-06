﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVinhDuy.UseCase.PluginInterface.StateStore
{
    public interface IShoppingCartStateStore:IStateStore
    {
        Task<int> GetItemsCount();
        void UpdateLineItemsCount();

        void UpdateProductQuatity();
    }
}