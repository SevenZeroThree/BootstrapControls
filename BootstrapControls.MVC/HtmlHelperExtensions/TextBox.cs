using BootstrapControls.Core.Enums;
using BootstrapControls.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.MVC.HtmlHelperExtensions
{
    public static class TextBoxHelpers
    {
        public static MvcHtmlString TextBox(this BootstrapHtmlHelper helper)
        {
            return helper.TextBox(String.Empty);
        }

        public static MvcHtmlString TextBox(this BootstrapHtmlHelper helper, string placeholder)
        {
            return helper.TextBox(placeholder, TextBoxSize.Default);
        }

        public static MvcHtmlString TextBox(this BootstrapHtmlHelper helper, string placeholder, TextBoxSize size)
        {
            return helper.TextBox(placeholder, size, null);
        }

        public static MvcHtmlString TextBox(this BootstrapHtmlHelper helper, string placeholder, TextBoxSize size, object htmlAttributes)
        {
            var builder = new TagBuilder("input");
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;

            builder.MergeAttributes(attributes);
            builder.AddCssClass(TextBoxHelper.GetCssClass(size));
            builder.Attributes["placeholder"] = placeholder;
            builder.Attributes["type"] = "text";

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}
