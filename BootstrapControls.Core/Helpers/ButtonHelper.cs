using BootstrapControls.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapControls.Core.Helpers
{
    public static class ButtonHelper
    {
        private const string DEFAULT_CSS_CLASS = "btn";

        public static string GetCssClass(ButtonType type, ButtonSize size)
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
