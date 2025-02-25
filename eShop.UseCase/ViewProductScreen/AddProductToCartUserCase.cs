﻿using NguyenVinhDuy.UseCase.PluginInterface.DataStore;
using NguyenVinhDuy.UseCase.PluginInterface.StateStore;
using NguyenVinhDuy.UseCase.PluginInterface.UI;
using NguyenVinhDuy.UseCase.ViewProductScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVinhDuy.UseCase.ViewProductScreen
{
    public class AddProductToCartUserCase : IAddProductToCartUserCase
    {
        //khai báo
        private readonly IProductRepository _productRepository;
        private readonly IShopingCart _shopingCart;
        private readonly IShoppingCartStateStore _shoppingCartStateStore;

        public AddProductToCartUserCase(IProductRepository productRespository, IShopingCart shopingCart,IShoppingCartStateStore shoppingCartStateStore)
        {
            this._productRepository = productRespository;
            this._shopingCart = shopingCart;
            this._shoppingCartStateStore = shoppingCartStateStore;
        }
        public async void Execute(int productId)
        {
            //khởi tạo product
            var product = _productRepository.GetProductById(productId);
            await _shopingCart.AddProductAsync(product);

            this._shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
