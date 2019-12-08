Imports System.Web.Mvc

Namespace Controllers
    Public Class SinglePageJobController
        Inherits Controller

        ' GET: SinglePageJob
        Function Index() As ActionResult
            Return View()
        End Function

    End Class
End Namespace