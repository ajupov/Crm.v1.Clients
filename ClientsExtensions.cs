using Crm.V1.Clients.Activities.Clients;
using Crm.V1.Clients.Companies.Clients;
using Crm.V1.Clients.Contacts.Clients;
using Crm.V1.Clients.Deals.Clients;
using Crm.V1.Clients.Leads.Clients;
using Crm.V1.Clients.OAuth.Clients;
using Crm.V1.Clients.Products.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.V1.Clients
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
                .AddSingleton<ICompaniesClient, CompaniesClient>()
                .AddSingleton<ICompanyChangesClient, CompanyChangesClient>()
                .AddSingleton<ICompanyAttributesClient, CompanyAttributesClient>()
                .AddSingleton<ICompanyAttributeChangesClient, CompanyAttributeChangesClient>()
                .AddSingleton<ICompanyCommentsClient, CompanyCommentsClient>()
                .AddSingleton<IContactsClient, ContactsClient>()
                .AddSingleton<IContactChangesClient, ContactChangesClient>()
                .AddSingleton<IContactAttributesClient, ContactAttributesClient>()
                .AddSingleton<IContactAttributeChangesClient, ContactAttributeChangesClient>()
                .AddSingleton<IContactCommentsClient, ContactCommentsClient>()
                .AddSingleton<IDealsClient, DealsClient>()
                .AddSingleton<IDealChangesClient, DealChangesClient>()
                .AddSingleton<IDealAttributesClient, DealAttributesClient>()
                .AddSingleton<IDealAttributeChangesClient, DealAttributeChangesClient>()
                .AddSingleton<IDealStatusesClient, DealStatusesClient>()
                .AddSingleton<IDealStatusChangesClient, DealStatusChangesClient>()
                .AddSingleton<IDealTypesClient, DealTypesClient>()
                .AddSingleton<IDealTypeChangesClient, DealTypeChangesClient>()
                .AddSingleton<IDealCommentsClient, DealCommentsClient>()
                .AddSingleton<ILeadsClient, LeadsClient>()
                .AddSingleton<ILeadChangesClient, LeadChangesClient>()
                .AddSingleton<ILeadAttributesClient, LeadAttributesClient>()
                .AddSingleton<ILeadAttributeChangesClient, LeadAttributeChangesClient>()
                .AddSingleton<ILeadSourcesClient, LeadSourcesClient>()
                .AddSingleton<ILeadSourceChangesClient, LeadSourceChangesClient>()
                .AddSingleton<ILeadCommentsClient, LeadCommentsClient>()
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
