using BootstrapControls.Core.Enums;
using BootstrapControls.Core.Fonts;
using BootstrapControls.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.MVC.HtmlHelperExtensions
{
    public static class InputGroup
    {
        public static MvcHtmlString TextBoxInputGroup(this BootstrapHtmlHelper helper, string placeholder, IFontIcon inputGroup)
        {
            return helper.TextBoxInputGroup(placeholder, inputGroup, TextBoxSize.Default);
        }

        public static MvcHtmlString TextBoxInputGroup(this BootstrapHtmlHelper helper, string placeholder, string inputGroup)
        {
            return helper.TextBoxInputGroup(placeholder, inputGroup, TextBoxSize.Default);
        }

        public static MvcHtmlString TextBoxInputGroup(this BootstrapHtmlHelper helper, string placeholder, IFontIcon inputGroup, TextBoxSize size)
        {
            var glyphicon = helper.Glyphicon(inputGroup);
            return helper.TextBoxInputGroup(placeholder, glyphicon, TextBoxSize.Default);
        }

        public static MvcHtmlString TextBoxInputGroup(this BootstrapHtmlHelper helper, string placeholder, string inputGroup, TextBoxSize size)
        {
            var inputGroupWrapper = new TagBuilder("div");
            inputGroupWrapper.AddCssClass("input-group");

            var addon = new TagBuilder("span");
            addon.AddCssClass("input-group-addon");
            addon.InnerHtml = inputGroup;

            var builder = new TagBuilder("input");

            builder.AddCssClass(TextBoxHelper.GetCssClass(size));
            builder.Attributes["placeholder"] = placeholder;
            builder.Attributes["type"] = "text";

            inputGroupWrapper.InnerHtml = addon.ToString();
            inputGroupWrapper.InnerHtml = inputGroupWrapper.InnerHtml + builder.ToString();

            return MvcHtmlString.Create(inputGroupWrapper.ToString());
        }
    }
}
