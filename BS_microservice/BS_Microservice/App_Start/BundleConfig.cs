using System.Web.Optimization;

namespace BS_Microservice
{
    /// <summary>
    /// Bundle configuration
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Bundle regitration method
        /// </summary>
        /// <param name="bundles">The bundle collection</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JS
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Assets/scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Assets/scripts/jquery.unobtrusive*",
                        "~/Assets/scripts/jquery.validate*"));

            // CSS
            bundles.Add(new StyleBundle("~/Assets/css").Include("~/Assets/css/site.css"));

            bundles.Add(new StyleBundle("~/Assets/css/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}