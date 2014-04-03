using BootstrapControls.Core;
using BootstrapControls.Core.Enums;
using BootstrapControls.Core.Fonts;
using BootstrapControls.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BootstrapControls.MVC.HtmlHelperExtensions
{
    public static class ButtonHelpers
    {
        public static MvcHtmlString Button(this BootstrapHtmlHelper helper)
        {
            return helper.Button(String.Empty);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, Glyphicon icon)
        {
            return helper.Button(String.Empty, ButtonType.Default, ButtonSize.Default, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value)
        {
            return helper.Button(value, ButtonType.Default, ButtonSize.Default);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, Glyphicon icon)
        {
            return helper.Button(value, ButtonType.Default, ButtonSize.Default, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonType type)
        {
            return helper.Button(value, type, ButtonSize.Default);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonType type, Glyphicon icon)
        {
            return helper.Button(value, type, ButtonSize.Default, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonSize size)
        {
            return helper.Button(value, ButtonType.Default, size);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonSize size, Glyphicon icon)
        {
            return helper.Button(value, ButtonType.Default, size, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, ButtonType type)
        {
            return helper.Button(String.Empty, type, ButtonSize.Default);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, ButtonType type, Glyphicon icon)
        {
            return helper.Button(String.Empty, type, ButtonSize.Default, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, ButtonSize size)
        {
            return helper.Button(String.Empty, ButtonType.Default, size);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, ButtonSize size, Glyphicon icon)
        {
            return helper.Button(String.Empty, ButtonType.Default, size, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonType type, ButtonSize size)
        {
            return helper.Button(value, type, size, Glyphicon.NONE);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonType type, ButtonSize size, Glyphicon icon)
        {
            return helper.Button(value, type, size, icon, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonType type, ButtonSize size, object htmlAttributes)
        {
            return helper.Button(value, type, size, Glyphicon.NONE, null);
        }

        public static MvcHtmlString Button(this BootstrapHtmlHelper helper, string value, ButtonType type, ButtonSize size, Glyphicon icon, object htmlAttributes)
        {
            var builder = new TagBuilder("button");
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;

            builder.MergeAttributes(attributes);
            builder.AddCssClass(ButtonHelper.GetCssClass(type, size));

            if (icon != Glyphicon.NONE)
            {
                builder.InnerHtml = helper.Glyphicon(icon) + " ";
            }

            builder.InnerHtml = builder.InnerHtml + value;

            return MvcHtmlString.Create(builder.ToString());
        }
    }
}
