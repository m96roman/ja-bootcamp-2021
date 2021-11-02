using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PersonsMVC.Middleware.Helpers
{
    public static class AlertExtesnsions
    {
        public static HtmlString ErrorAlert(this IHtmlHelper helper, object ErrorMessage)
        {
            if (ErrorMessage != null)
            {

                return new HtmlString(
                    "<div class='alert alert-danger alert - dismissible fade show' role='alert'> " +
                        "<strong>" +
                             ErrorMessage +
                         "</strong>" +
                         "<button type = 'button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span>" +
                         "</button>" +
                        "</div>");
            }

            return new HtmlString(null);
        }
    }
}
