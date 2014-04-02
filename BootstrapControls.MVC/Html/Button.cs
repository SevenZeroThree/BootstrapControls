using BootstrapControls.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.Extensions.Html
{
    public static class Button
    {
        private const string DEFAULT_CSS_CLASS = "btn";

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
            builder.AddCssClass(GetCssClass(type, size));
            builder.InnerHtml = value;

            return MvcHtmlString.Create(builder.ToString());
        }

        private static string GetCssClass(ButtonType type, ButtonSize size)
        {
            var cssClassBuilder = new StringBuilder();
            cssClassBuilder.Append(DEFAULT_CSS_CLASS);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(GetButtonTypeCssClass(type));
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(GetButtonSizeCssClass(size));

            return cssClassBuilder.ToString();
        }

        private static string GetButtonTypeCssClass(ButtonType type)
        {
            return "btn-" + type.ToString().ToLower();
        }

        private static string GetButtonSizeCssClass(ButtonSize size)
        {
            var cssClass = string.Empty;

            switch (size)
            {
                case ButtonSize.Large:
                    cssClass = "btn-lg";
                    break;
                case ButtonSize.Small:
                    cssClass = "btn-sm";
                    break;
                case ButtonSize.ExtraSmall:
                    cssClass = "btn-xs";
                    break;
                case ButtonSize.Default:
                default:
                    break;

            }

            return cssClass;
        }
    }
}
