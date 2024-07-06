using NguyenVinhDuy.CoreBusiness.Service;
using NguyenVinhDuy.CoreBusiness.Service.Interfaces;
using NguyenVinhDuy.DataStore.HardCodes.Helper;

//using eShop.DataStore.HardCode;
using NguyenVinhDuy.DataStore.SQL.Dapper;
using NguyenVinhDuy.ShopingCart.LocalStorage;
using NguyenVinhDuy.StateStore.DI;
using NguyenVinhDuy.UseCase.AdminPortal.OrderDetailsScreen;
using NguyenVinhDuy.UseCase.AdminPortal.OrderDetailsScreen.interfaces;
using NguyenVinhDuy.UseCase.AdminPortal.OutStandingOrderScreen;
using NguyenVinhDuy.UseCase.AdminPortal.ProcessedOrderScreen;
using NguyenVinhDuy.UseCase.OrderConfirmScreen;
using NguyenVinhDuy.UseCase.PluginInterface.DataStore;
using NguyenVinhDuy.UseCase.PluginInterface.StateStore;
using NguyenVinhDuy.UseCase.PluginInterface.UI;
using NguyenVinhDuy.UseCase.SearchProductScreen;
using NguyenVinhDuy.UseCase.ShoppingCartScreen;
using NguyenVinhDuy.UseCase.ShoppingCartScreen.Interfaces;
using NguyenVinhDuy.UseCase.ViewProductScreen;
using NguyenVinhDuy.UseCase.ViewProductScreen.Interfaces;
using NguyenVinhDuy.Web.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddAuthentication("eShop.CookieAuth").AddCookie("eShop.CookieAuth", config =>
{
    config.Cookie.Name = "eShop.CookieAuth";
    config.LoginPath = "/authenticate";
});


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<IProductRepository,ProductRepository>();
builder.Services.AddTransient<IOrderRespository, OrderRepository>();
builder.Services.AddTransient<IDataAccess>(sp=>new DataAccess(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<IShopingCart, ShopingCart>();
builder.Services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IViewProductUseCase, ViewProductUseCase>();
builder.Services.AddTransient<ISearchProductUseCase, SearchProductUseCase>();
builder.Services.AddTransient<IAddProductToCartUserCase, AddProductToCartUserCase>();
builder.Services.AddTransient<IViewShoppingCartUserCase,ViewShoppingCartUserCase>();
builder.Services.AddTransient<IDeleteProductUserCase, DeleteProductUserCase>();
builder.Services.AddTransient<IUpdateQuantityUserCase, UpdateQuantityUserCase>();
builder.Services.AddTransient<IPlaceOrderUserCase, PlaceOrderUserCase>();
builder.Services.AddTransient<IViewOrderConfrimUserCase, ViewOrderConfrimUserCase>();

builder.Services.AddTransient<IViewOutStandingOrderUserCase,ViewOutStandingOrderUserCase>();
builder.Services.AddTransient<IViewOrderDetailUserCase, ViewOrderDetailUserCase>();
builder.Services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();
builder.Services.AddTransient<IViewPrcessedOrderUserCase, ViewPrcessedOrderUserCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
