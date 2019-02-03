using System.Web;
using System.Web.Optimization;

namespace Gaffgc_App
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery-1.11.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/js/bootstrap.min.js"));

            // Xenon Theme bundles
            bundles.Add(new ScriptBundle("~/bundles/xenon").Include(
                    "~/assets/js/xenon.js",
                    "~/assets/js/joinable.js",
                    "~/assets/js/handlebars.min.js",
                    "~/assets/js/moment.min.js",
                    "~/assets/js/resizable.js",
                    "~/assets/js/TweenLite.min.js",
                    "~/assets/js/TweenMax.min.js",
                    "~/assets/js/typehead.bundle.js",
                    "~/assets/js/xenon-api.js",
                    "~/assets/js/xenon-notes.js",
                    "~/assets/js/xenon-toggles.js",
                    "~/assets/js/xenon-widgets.js",
                    "~/assets/js/xenon-custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/min").IncludeDirectory("~/assets/js/min/", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/vmap").Include(
                "~/assets/js/jvectormap/jquery-jvectormap-1.2.2.min.js",
                "~/assets/js/jvectormap/regions/*.js"));

            // uikit
            bundles.Add(new ScriptBundle("~/bundles/uikit").IncludeDirectory("~/assets/js/uikit/", "*.js", true));
            bundles.Add(new StyleBundle("~/Content/uikit").IncludeDirectory("~/assets/js/uikit/", "*.css", true));

            bundles.Add(new ScriptBundle("~/bundles/toastr").IncludeDirectory("~/assets/js/toastr/", "*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/assets/css/bootstrap.css",
                       "~/assets/css/xenon-core.css",
                       "~/assets/css/xenon-components.css",
                       "~/assets/css/xenon-forms.css",
                       "~/assets/css/xenon-skins.css",
                       "~/assets/css/toastr.css",
                       "~/assets/css/xenon.css",
                       "~/assets/css/custom.css"));
        }
    }
}
