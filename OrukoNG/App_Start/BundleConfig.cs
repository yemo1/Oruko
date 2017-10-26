using System.Web;
using System.Web.Optimization;

namespace OrukoNG
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery.js",	
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/jquery.scrollUp.min.js",
                      "~/Scripts/price-range.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/main.js",
                      "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/content/bootstrap.min.css",
            //          "~/content/font-awesome.min.css",
            //          "~/content/prettyPhoto.css",
            //          "~/content/price-range.css",
            //          "~/content/animate.css",
            //          "~/content/main.css",
            //          //"~/content/site.css",
            //          "~/content/responsive.css"));


             bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
	                  "~/css/font-awesome.min.css",
	                  "~/css/prettyPhoto.css",
	                  "~/css/price-range.css",
	                  "~/css/animate.css",
	                  "~/css/main.css",
                      //"~/content/site.css",
	                  "~/css/responsive.css"));
        }
        
    }
}
