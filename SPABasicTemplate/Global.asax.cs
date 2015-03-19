using System.Web;
using System.Web.Optimization;

namespace SPABasicTemplate
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
