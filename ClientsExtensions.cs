using Crm.v1.Clients.Clients.Customers.Clients;
using Crm.v1.Clients.Clients.Orders.Clients;
using Crm.v1.Clients.Clients.Products.Clients;
using Crm.v1.Clients.Clients.Tasks.Clients;
using Crm.v1.Clients.OAuth.Clients;
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
                .AddHttpClient()
                .Configure<ClientsSettings>(settings =>
                {
                    settings.ApiHost = apiHost;
                    settings.OAuthHost = oauthHost;
                    settings.ClientId = clientId;
                });

            services
                .AddSingleton<IOAuthClient, OAuthClient>()
                .AddSingleton<IActivitiesClient, ActivitiesClient>()
                .AddSingleton<IActivityChangesClient, ActivityChangesClient>()
                .AddSingleton<IActivityAttributesClient, ActivityAttributesClient>()
                .AddSingleton<IActivityAttributeChangesClient, ActivityAttributeChangesClient>()
                .AddSingleton<IActivityStatusesClient, ActivityStatusesClient>()
                .AddSingleton<IActivityStatusChangesClient, ActivityStatusChangesClient>()
                .AddSingleton<IActivityTypesClient, ActivityTypesClient>()
                .AddSingleton<IActivityTypeChangesClient, ActivityTypeChangesClient>()
                .AddSingleton<IActivityCommentsClient, ActivityCommentsClient>()
                .AddSingleton<IDealsClient, DealsClient>()
                .AddSingleton<IDealChangesClient, DealChangesClient>()
                .AddSingleton<IDealAttributesClient, DealAttributesClient>()
                .AddSingleton<IDealAttributeChangesClient, DealAttributeChangesClient>()
                .AddSingleton<IDealStatusesClient, DealStatusesClient>()
                .AddSingleton<IDealStatusChangesClient, DealStatusChangesClient>()
                .AddSingleton<IDealTypesClient, DealTypesClient>()
                .AddSingleton<IDealTypeChangesClient, DealTypeChangesClient>()
                .AddSingleton<IDealCommentsClient, DealCommentsClient>()
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
                .AddSingleton<IProductStatusChangesClient, ProductStatusChangesClient>();
        }
    }
}
