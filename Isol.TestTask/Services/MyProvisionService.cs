using System.Configuration;
using System.Net;
using System.Security;
using Microsoft.SharePoint.Client;
using SPMeta2.CSOM.Services;
using SPMeta2.CSOM.Standard.ModelHandlers.Taxonomy;
using SPMeta2.Models;

namespace Isol.TestTask.Services
{
    public static class MyProvisionService
    {
        private static string Uri => ConfigurationManager.AppSettings["Uri"];

        private static string Username => ConfigurationManager.AppSettings["Username"];

        private static SecureString Password
        {
            get
            {
                var password = ConfigurationManager.AppSettings["Password"];
                var securePassword = new SecureString();
                foreach (var c in password.ToCharArray())
                {
                    securePassword.AppendChar(c);
                }

                return securePassword;
            }
        }

        public static void DeployWeb(ModelNode model)
        {
            var clientContext = GetClientcontext();
            var provisionService = new CSOMProvisionService();
            provisionService.DeployWebModel(clientContext, model);
        }

        public static void DeploySite(ModelNode model)
        {
            var clientContext = GetClientcontext();
            var provisionService = new CSOMProvisionService();
            provisionService.RegisterModelHandlers(typeof(TaxonomyTermModelHandler).Assembly);
            provisionService.DeploySiteModel(clientContext, model);
        }

        private static ClientContext GetClientcontext()
        {
            var siteUrl = Uri;
            var clientContext = new ClientContext(siteUrl);
            clientContext.Credentials = new SharePointOnlineCredentials(Username, Password);
            return clientContext;
        }
    }
}
