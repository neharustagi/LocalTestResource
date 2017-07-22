using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LocalTestResources
{
    public class LocalisedControllerActivator: IControllerActivator
    {
        private string defaultLanguage = "en";
        public IController Create(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            string language = (string)requestContext.RouteData.Values["language"] ?? "en";
            string culture = (string)requestContext.RouteData.Values["culture"] ?? "US";

            if (!string.Equals(language, defaultLanguage))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));
            }

            return System.Web.Mvc.DependencyResolver.Current.GetService(controllerType) as IController;
        }
    }
}