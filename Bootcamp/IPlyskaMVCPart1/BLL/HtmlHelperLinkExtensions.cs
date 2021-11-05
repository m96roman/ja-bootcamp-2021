using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;

namespace IPlyskaMVCPart1.BLL
{
    public static class HtmlHelperLinkExtensions
    {
        public static IHtmlContent ActionLink(this IHtmlHelper helper, string linkText, string actionName, string controllerName, object routeValues)
        {
            if (helper == null)
            {
                throw new ArgumentNullException(nameof(helper));
            }

            if (linkText == null)
            {
                throw new ArgumentNullException(nameof(linkText));
            }

            ViewContext viewContext = helper.ViewContext;
            routeValues = viewContext.RouteData.Values;

            return helper.ActionLink(
                linkText,
                actionName,
                controllerName: null,
                protocol: null,
                hostname: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: null);
        }
    }
}
