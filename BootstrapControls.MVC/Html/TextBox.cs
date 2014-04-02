using BootstrapControls.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.Extensions.Html
{
    public static class TextBox
    {
        private const string DEFAULT_CSS_CLASS = "form-control";

        public static MvcHtmlString BootstrapTextBox(this HtmlHelper helper)
        {
            return helper.BootstrapTextBox(String.Empty);
        }

        public static MvcHtmlString BootstrapTextBox(this HtmlHelper helper, string placeholder)
        {
            return helper.BootstrapTextBox(placeholder, TextBoxSize.Default);
        }

        public static MvcHtmlString BootstrapTextBox(this HtmlHelper helper, string placeholder, TextBoxSize size)
        {
            return helper.BootstrapTextBox(placeholder, size, null);
        }

        public static MvcHtmlString BootstrapTextBox(this HtmlHelper helper, string placeholder, TextBoxSize size, object htmlAttributes)
        {
            var builder = new TagBuilder("input");
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;

            builder.MergeAttributes(attributes);
            builder.AddCssClass(GetCssClass(size));
            builder.Attributes["placeholder"] = placeholder;
            builder.Attributes["type"] = "text";

            return MvcHtmlString.Create(builder.ToString());
        }

        private static string GetCssClass(TextBoxSize size)
        {
            var cssClassBuilder = new StringBuilder();
            cssClassBuilder.Append(DEFAULT_CSS_CLASS);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(GetTextBoxSizeCssClass(size));

            return cssClassBuilder.ToString();
        }

        private static string GetTextBoxSizeCssClass(TextBoxSize size)
        {
            var cssClass = string.Empty;

            switch (size)
            {
                case TextBoxSize.Large:
                    cssClass = "input-lg";
                    break;
                case TextBoxSize.Small:
                    cssClass = "input-sm";
                    break;
                case TextBoxSize.Default:
                default:
                    break;

            }

            return cssClass;
        }
    }
}
