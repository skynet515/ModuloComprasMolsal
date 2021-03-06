using System.Web;
using System.Web.Optimization;

namespace ModuloCompras
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/bundles/SiteCss").Include(
                   "~/Content/css/sb-admin-2.css"
                  
                ));

            bundles.Add(new StyleBundle("~/bundles/VendorDataTables").Include(
                "~/Content/vendor/datatables/dataTables.bootstrap4.min.css"

             ));
            bundles.Add(new StyleBundle("~/bundles/VendorCss").Include(
                  "~/Content/vendor/fontawesome-free/css/all.min.css"
                   
               ));

            bundles.Add(new StyleBundle("~/bundles/VendorDTJs").Include(
                "~/Content/vendor/datatables/jquery.dataTables.min.js",
                 "~/Content/vendor/datatables/dataTables.bootstrap4.min.js",
                 "~/Content/js/demo/datatables-demo.js"

             ));

            bundles.Add(new ScriptBundle("~/bundles/SiteJS").Include(
                       "~/Content/vendor/jquery/jquery.min.js",
                        "~/Content/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/js/sb-admin-2.min.js",
                         "~/Scripts/site.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/UtilJs").Include(
                       "~/JScript/util/Usuario.js",
                       "~/JScript/util/Compras.js"
                     ));
        }
    }
}
