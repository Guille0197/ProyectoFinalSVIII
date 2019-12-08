Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function AllJob() As ActionResult

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function JobListPma() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
