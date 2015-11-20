using System.Web;
using System.Web.Optimization;

namespace JSAppBasicTemplate
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
