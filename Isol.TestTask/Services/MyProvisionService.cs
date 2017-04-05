using System.Configuration;
using System.Net;
using Microsoft.SharePoint.Client;
using SPMeta2.CSOM.Services;
using SPMeta2.Models;

namespace Isol.TestTask.Services
{
    public static class MyProvisionService
    {
        private static string Uri => ConfigurationManager.AppSettings["Uri"];

        private static string Username => ConfigurationManager.AppSettings["Username"];

        private static string Password => ConfigurationManager.AppSettings["Password"];

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
            provisionService.DeploySiteModel(clientContext, model);
        }

        private static ClientContext GetClientcontext()
        {
            var siteUrl = Uri;
            var clientContext = new ClientContext(siteUrl);
            clientContext.Credentials = new NetworkCredential(Username, Password);
            return clientContext;
        }
    }
}
