using BootstrapControls.Core.Enums;
using BootstrapControls.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.Extensions.HtmlHelperExtensions
{
    public static class Button
    {
        public static MvcHtmlString BootstrapButton(this HtmlHelper helper)
        {
            return helper.BootstrapButton(String.Empty);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, string value)
        {
            return helper.BootstrapButton(value, ButtonType.Default, ButtonSize.Default);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, string value, ButtonType type)
        {
            return helper.BootstrapButton(value, type, ButtonSize.Default);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, string value, ButtonSize size)
        {
            return helper.BootstrapButton(value, ButtonType.Default, size);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, ButtonType type)
        {
            return helper.BootstrapButton(String.Empty, type, ButtonSize.Default);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, ButtonSize size)
        {
            return helper.BootstrapButton(String.Empty, ButtonType.Default, size);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, string value, ButtonType type, ButtonSize size)
        {
            return helper.BootstrapButton(value, type, size, null);
        }

        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, string value, ButtonType type, ButtonSize size, object htmlAttributes)
        {
            var builder = new TagBuilder("button");
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;

            builder.MergeAttributes(attributes);
            builder.AddCssClass(ButtonHelper.GetCssClass(type, size));
            builder.InnerHtml = value;

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}
