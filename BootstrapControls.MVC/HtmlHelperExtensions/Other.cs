using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.MVC.HtmlHelperExtensions
{
    public static class Other
    {
        public static MvcHtmlString CloseIcon(this BootstrapHtmlHelper helper)
        {
            return helper.CloseIcon(String.Empty);
        }

        public static MvcHtmlString CloseIcon(this BootstrapHtmlHelper helper, string dismiss)
        {
            return helper.CloseIcon(dismiss, null);
        }

        // Bootstrap.Dismiss(string dismiss).....?????
        public static MvcHtmlString CloseIcon(this BootstrapHtmlHelper helper, string dismiss, object htmlAttributes)
        {
            var builder = new TagBuilder("button");
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;

            builder.MergeAttributes(attributes);
            builder.AddCssClass("close");

            builder.Attributes["type"] = "button";
            builder.Attributes["aria-hidden"] = "true";

            if (!String.IsNullOrWhiteSpace(dismiss))
            {
                builder.Attributes["data-dismiss"] = dismiss;
            }

            builder.InnerHtml = "&times;";

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}
