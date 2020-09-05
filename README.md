# Crm.V1.Clients
API clients for [Lite CRM](https://litecrm.org)

## Usage
```
public static class Program
{
    public static Task Main()
    {
        var configuration = Configuration.GetConfiguration();

        return configuration
            .ConfigureServices((context, services) =>
            {
                const string clientId = "Your_Client_Id";
                const string apiHost = "https://api.litecrm.org";
                const string oauthHost = "https://identity.litecrm.org";

                services
                    .ConfigureClients(clientId, apiHost, oauthHost);
            .Configure((context, builder) => {})
            .Build()
            .RunAsync();
    }
}
```

## Development
1. Clone this repository
2. Switch to a `new branch`
3. Make changes into `new branch`
4. Upgrade `PackageVersion` property value in `.csproj` file
5. Create pull request from `new branch` to `master` branch
6. Require code review
7. Merge pull request after approving
8. You can see package in [Github Packages](https://github.com/ajupov/Crm.V1.Clients/packages)
