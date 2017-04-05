using Isol.TestTask.Models;
using Isol.TestTask.Services;

namespace Isol.TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var siteModel = MySiteModel.GetModel();
            MyProvisionService.DeploySite(siteModel);

            var webModel = MyWebModel.GetModel();
            MyProvisionService.DeployWeb(webModel);
        }
    }
}
