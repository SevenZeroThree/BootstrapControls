using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapControls.SeverControls.Controls
{
    public class GridView : System.Web.UI.WebControls.GridView
    {
        private const string DEFAULT_CSS_CLASS = "table";

        public bool Striped { get; set; }
        public bool Bordered { get; set; }
        public bool HoverRows { get; set; }
        public bool Condensed { get; set; }

        protected override void OnPreRender(EventArgs e)
        {
            HeaderRow.TableSection = System.Web.UI.WebControls.TableRowSection.TableHeader;

            base.OnPreRender(e);
        }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            base.CssClass = base.CssClass = GetCssClass(); ;
            base.GridLines = System.Web.UI.WebControls.GridLines.None;
            
            base.Render(writer);
        }

        private string GetCssClass()
        {
            var cssClassBuilder = new StringBuilder();
            cssClassBuilder.Append(DEFAULT_CSS_CLASS);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(Striped ? "table-striped" : String.Empty);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(Bordered ? "table-bordered" : String.Empty);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(HoverRows ? "table-hover" : String.Empty);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(Condensed ? "table-condensed" : String.Empty);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(base.CssClass);

            return cssClassBuilder.ToString();
        }
    }
}
