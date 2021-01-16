using MVCBookshelf.Controllers;
using System;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCBookshelf
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception lastErrorInfo = Server.GetLastError();
            Exception errorInfo = null;

            bool isNotFound = false;
            if (lastErrorInfo != null)
            {
                errorInfo = lastErrorInfo.GetBaseException();
                var error = errorInfo as HttpException;
                if (error != null)
                    isNotFound = error.GetHttpCode() == (int)System.Net.HttpStatusCode.NotFound;
            }
            if (isNotFound)
            {
                Server.ClearError();
                Response.Redirect("~/Error/NotFound");// Do what you need to render in view
            }
        }

/*        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Response.Clear();
            HttpException httpException = exception as HttpException;
            RouteData routeData = new RouteData();
            routeData.Values.Add("controller", "Error");
            if (httpException != null)
            {
                switch(httpException.GetHttpCode())
                {
                    case 404:
                        routeData.Values.Add("action", "NotFound");
                        break;
                }
                Server.ClearError();
                Response.TrySkipIisCustomErrors = true;
            }
            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(
                new HttpContextWrapper(Context), routeData));
        }*/
    }
}