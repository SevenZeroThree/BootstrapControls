using BootstrapControls.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapControls.Core.Helpers
{
    public static class TextBoxHelper
    {
        private const string DEFAULT_CSS_CLASS = "form-control";

        public static string GetCssClass(TextBoxSize size)
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
