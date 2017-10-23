using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace localization_Test.Controllers
{
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = (string)RouteData.Values["culture"] ?? "en-US";

            cultureName = Helpers.CultureHelper.GetNeutralCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(cultureName);
            return base.BeginExecuteCore(callback, state);
        }
    } 
}