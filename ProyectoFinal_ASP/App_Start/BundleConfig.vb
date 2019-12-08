Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css"))

        '-- CSS Hireo
        bundles.Add(New StyleBundle("~/Content/Hireo_css").Include(
                      "~/Content/HireoTemplate/css/style.css",
                      "~/Content/HireoTemplate/css/colors/blue.css"))

        '-- Scripts Hireo
        bundles.Add(New ScriptBundle("~/Content/Hireo_js").Include(
                    "~/Content/HireoTemplate/js/jquery-3.3.1.min.js",
                    "~/Content/HireoTemplate/js/jquery-migrate-3.0.0.min.js",
                    "~/Content/HireoTemplate/js/mmenu.min.js",
                    "~/Content/HireoTemplate/js/tippy.all.min.js",
                    "~/Content/HireoTemplate/js/simplebar.min.js",
                    "~/Content/HireoTemplate/js/bootstrap-slider.min.js",
                    "~/Content/HireoTemplate/js/bootstrap-select.min.js",
                    "~/Content/HireoTemplate/js/snackbar.js",
                    "~/Content/HireoTemplate/js/clipboard.min.js",
                    "~/Content/HireoTemplate/js/counterup.min.js",
                    "~/Content/HireoTemplate/js/magnific-popup.min.js",
                    "~/Content/HireoTemplate/js/slick.min.js",
                    "~/Content/HireoTemplate/js/custom.js",
                    "~/Content/HireoTemplate/js/infobox.min.js",
                    "~/Content/HireoTemplate/js/markerclusterer.js",
                    "~/Content/HireoTemplate/js/maps.js.js"))

    End Sub
End Module

