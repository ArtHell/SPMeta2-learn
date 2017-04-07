using Isol.TestTask.Models;
using Isol.TestTask.Services;

namespace Isol.TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var siteTaxonomyModel = MySiteModel.GetTaxonomyModel();
            MyProvisionService.DeploySite(siteTaxonomyModel);

            var siteProjectModel = MySiteModel.GetProjectModel();
            MyProvisionService.DeploySite(siteProjectModel);

            var webProjectModel = MyWebModel.GetProjectModel();
            MyProvisionService.DeployWeb(webProjectModel);

            var siteDocumentModel = MySiteModel.GetDocumentModel();
            MyProvisionService.DeploySite(siteDocumentModel);

            var webDocumentModel = MyWebModel.GetDocumentModel();
            MyProvisionService.DeployWeb(webDocumentModel);
        }
    }
}
