using System.Web;
using System.Web.Optimization;

namespace HomeDepot.CalculateOhmValue.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/jquery-1.12.4.js",
                        "~/Scripts/jquery-ui.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
          "~/Scripts/HomeDepot.Utilities.js",
          "~/Scripts/HomeDepot.Scripts.js"
          ));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/Site.css","~/Content/jquery-ui.css"
               ));
        }
    }
}