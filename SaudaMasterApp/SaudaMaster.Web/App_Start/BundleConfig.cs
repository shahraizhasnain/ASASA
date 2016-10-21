using System.Web;
using System.Web.Optimization;

namespace SaudaMaster.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/JS/jquery-1.8.3.min.js",
                      "~/Scripts/JS/jquery.js",
                      "~/Scripts/JS/bootstrap.min.js",
                      "~/Scripts/JS/jquery.dcjqaccordion.2.7.js",
                      "~/Scripts/JS/jquery.scrollTo.min.js",
                      "~/Scripts/JS/jquery.nicescroll.js",
                      "~/Scripts/JS/jquery.sparkline.js",
                      "~/Scripts/JS/jquery.easy-pie-chart.js",
                      "~/Scripts/JS/owl.carousel.js",
                      "~/Scripts/JS/jquery.customSelect.min.js",
                      "~/Scripts/JS/respond.min.js",
                      "~/Scripts/JS/common-scripts.js",
                      "~/Scripts/JS/sparkline-chart.js",
                      "~/Scripts/JS/easy-pie-chart.js",
                      "~/Scripts/JS/count.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-reset.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/style-responsive.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery.easy-pie-chart.css",
                      "~/Content/style.css"));
        }
    }
}
