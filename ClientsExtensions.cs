using Ajupov.Utils.All.Http.FormDataHttpClient;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Account.Clients;
using Crm.v1.Clients.Auth.Clients;
using Crm.v1.Clients.Customers.Clients;
using Crm.v1.Clients.OAuth.Clients;
using Crm.v1.Clients.Orders.Clients;
using Crm.v1.Clients.Products.Clients;
using Crm.v1.Clients.Stock.Clients;
using Crm.v1.Clients.Suppliers.Clients;
using Crm.v1.Clients.Tasks.Clients;
using Crm.v1.Clients.User.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.v1.Clients
{
    public static class ClientsExtensions
    {
        public static void ConfigureClients(
            this IServiceCollection services,
            string clientId,
            string apiHost = ClientsDefaults.ApiHost,
            string oauthHost = ClientsDefaults.IdentityHost)
        {
            services
                .Configure<ClientsOptions>(settings => { settings.Host = apiHost; })
                .Configure<OAuthClientsOptions>(settings =>
                {
                    settings.Host = oauthHost;
                    settings.ClientId = clientId;
                });

            services
                .AddHttpClient();

            services
                .AddSingleton<IJsonHttpClientFactory, JsonHttpClientFactory>()
                .AddSingleton<IFormDataHttpClientFactory, FormDataHttpClientFactory>();

            services
                .AddSingleton<IOAuthClient, OAuthClient>()
                .AddSingleton<IAccountFlagsClient, AccountFlagsClient>()
                .AddSingleton<IAccountSettingChangesClient, AccountSettingChangesClient>()
                .AddSingleton<IAccountSettingsClient, AccountSettingsClient>()
                .AddSingleton<IUserFlagsClient, UserFlagsClient>()
                .AddSingleton<IUserSettingChangesClient, UserSettingChangesClient>()
                .AddSingleton<IUserSettingsClient, UserSettingsClient>()
                .AddSingleton<IAuthClient, AuthClient>()
                .AddSingleton<IUserInfoClient, UserInfoClient>()
                .AddSingleton<ITasksClient, TasksClient>()
                .AddSingleton<ITaskChangesClient, TaskChangesClient>()
                .AddSingleton<ITaskAttributesClient, TaskAttributesClient>()
                .AddSingleton<ITaskAttributeChangesClient, TaskAttributeChangesClient>()
                .AddSingleton<ITaskStatusesClient, TaskStatusesClient>()
                .AddSingleton<ITaskStatusChangesClient, TaskStatusChangesClient>()
                .AddSingleton<ITaskTypesClient, TaskTypesClient>()
                .AddSingleton<ITaskTypeChangesClient, TaskTypeChangesClient>()
                .AddSingleton<ITaskCommentsClient, TaskCommentsClient>()
                .AddSingleton<IOrdersClient, OrdersClient>()
                .AddSingleton<IOrderChangesClient, OrderChangesClient>()
                .AddSingleton<IOrderAttributesClient, OrderAttributesClient>()
                .AddSingleton<IOrderAttributeChangesClient, OrderAttributeChangesClient>()
                .AddSingleton<IOrderStatusesClient, OrderStatusesClient>()
                .AddSingleton<IOrderStatusChangesClient, OrderStatusChangesClient>()
                .AddSingleton<IOrderTypesClient, OrderTypesClient>()
                .AddSingleton<IOrderTypeChangesClient, OrderTypeChangesClient>()
                .AddSingleton<IOrderCommentsClient, OrderCommentsClient>()
                .AddSingleton<ICustomersClient, CustomersClient>()
                .AddSingleton<ICustomerChangesClient, CustomerChangesClient>()
                .AddSingleton<ICustomerAttributesClient, CustomerAttributesClient>()
                .AddSingleton<ICustomerAttributeChangesClient, CustomerAttributeChangesClient>()
                .AddSingleton<ICustomerSourcesClient, CustomerSourcesClient>()
                .AddSingleton<ICustomerSourceChangesClient, CustomerSourceChangesClient>()
                .AddSingleton<ICustomerCommentsClient, CustomerCommentsClient>()
                .AddSingleton<IProductsClient, ProductsClient>()
                .AddSingleton<IProductChangesClient, ProductChangesClient>()
                .AddSingleton<IProductAttributesClient, ProductAttributesClient>()
                .AddSingleton<IProductAttributeChangesClient, ProductAttributeChangesClient>()
                .AddSingleton<IProductCategoriesClient, ProductCategoriesClient>()
                .AddSingleton<IProductCategoryChangesClient, ProductCategoryChangesClient>()
                .AddSingleton<IProductStatusesClient, ProductStatusesClient>()
                .AddSingleton<IProductStatusChangesClient, ProductStatusChangesClient>()
                .AddSingleton<ISuppliersClient, SuppliersClient>()
                .AddSingleton<ISupplierChangesClient, SupplierChangesClient>()
                .AddSingleton<ISupplierAttributesClient, SupplierAttributesClient>()
                .AddSingleton<ISupplierAttributeChangesClient, SupplierAttributeChangesClient>()
                .AddSingleton<ISupplierCommentsClient, SupplierCommentsClient>()
                .AddSingleton<IStockArrivalsClient, StockArrivalsClient>()
                .AddSingleton<IStockArrivalChangesClient, StockArrivalChangesClient>()
                .AddSingleton<IStockBalancesClient, StockBalancesClient>()
                .AddSingleton<IStockBalanceChangesClient, StockBalanceChangesClient>()
                .AddSingleton<IStockConsumptionsClient, StockConsumptionsClient>()
                .AddSingleton<IStockConsumptionChangesClient, StockConsumptionChangesClient>()
                .AddSingleton<IStockRoomsClient, StockRoomsClient>()
                .AddSingleton<IStockRoomChangesClient, StockRoomChangesClient>();
        }
    }
}
