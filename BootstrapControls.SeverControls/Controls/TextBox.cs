using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrapControls.WebForms.Controls
{
    public class TextBox : System.Web.UI.WebControls.TextBox
    {
        private const string DEFAULT_CSS_CLASS = "form-control";

        #region Properties

        public string Placeholder { get; set; }
        public TextBoxSize Size { get; set; }

        //private string _cssClass;
        //public override string CssClass
        //{
        //    get 
        //    { 
        //        return DEFAULT_CSS_CLASS + " " + base.CssClass;

        //    }
        //    set 
        //    { 
        //        base.CssClass = value;
        //    }
        //}

        #endregion

        //protected override void OnInit(EventArgs e)
        //{
        //    base.OnInit(e);
        //}

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            //var textBox = new System.Web.UI.WebControls.TextBox();
            //textBox.CssClass = DEFAULT_CSS_CLASS + " " + _cssClass;
            //textBox.RenderControl(writer);

            base.Attributes.Add("placeholder", Placeholder);
            base.CssClass = base.CssClass = GetCssClass(); ;

            base.Render(writer);
        }

        private string GetCssClass()
        {
            var cssClassBuilder = new StringBuilder();
            cssClassBuilder.Append(DEFAULT_CSS_CLASS);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(GetTextBoxSizeCssClass());
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(base.CssClass);

            return cssClassBuilder.ToString();
        }

        private string GetTextBoxSizeCssClass()
        {
            var cssClass = string.Empty;

            switch (Size)
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

    public enum TextBoxSize
    {
        Default,
        Large,
        Small
    }
}
