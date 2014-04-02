using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.MVC.HtmlHelperExtensions
{
    public static class GlyphiconHtmlExtensions
    {
        public static string Glyphicon(this HtmlHelper helper, BootstrapControls.Core.Glyphicon icon)
        {
            var builder = new TagBuilder("i");
            builder.AddCssClass(icon.ToString());

            return builder.ToString();
        }
    }
}
