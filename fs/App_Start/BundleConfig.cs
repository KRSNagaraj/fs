using System.Web;
using System.Web.Optimization;

namespace fs
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/fs").Include(
                  "~/Content/js/jquery-1.11.1.js",
                  "~/Content/js/modernizr-2.6.2.min.js",
                  "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                  "~/Content/vendor/rs-plugin/js/jquery.themepunch.plugins.min.js",
                  "~/Content/vendor/rs-plugin/js/jquery.themepunch.revolution.js",
                  "~/Content/js/jquery.shuffle.min.js",
                  "~/Content/vendor/mmenu/js/jquery.mmenu.min.js",
                  "~/Content/vendor/owl/js/owl.carousel.min.js",
                  "~/Content/js/wow.min.js",
                  //"http://cdnjs.cloudflare.com/ajax/libs/waypoints/2.0.3/waypoints.min.js",
                  "~/Content/js/jquery.counterup.min.js",
                  "~/Content/js/jquery.easing.min.js",
                  "~/Content/js/scrolling-nav.js",
                  "~/Content/js/smoothscroll.min.js",
                  "~/Content/js/script.js",
                  "~/Content/js/email.js"));


            bundles.Add(new StyleBundle("~/Content/fs").Include(
                      "~/Content/vendor/rs-plugin/css/settings.css",
                      "~/Content/vendor/rs-plugin/css/extralayer.css",
                      "~/Content/vendor/flat-icon/flaticon.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.min.css",
                      "~/Content/vendor/owl/css/owl.carousel.css",
                      "~/Content/vendor/owl/css/owl.theme.default.css",
                      "~/Content/vendor/owl/css/owl.theme.css",
                      "~/Content/vendor/mmenu/css/jquery.mmenu.css",
                      "~/Content/vendor/bootstrap/css/bootstrap.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/hover.css",
                      "~/Content/css/style.css",
                      "~/Content/css/responsive.css",

                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css-ori").Include(
          "~/Content/bootstrap.css",
          "~/Content/site.css"));

        }
    }
}
