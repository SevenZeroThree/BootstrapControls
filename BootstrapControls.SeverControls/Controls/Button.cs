using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace BootstrapControls.SeverControls.Controls
{
    public class Button : System.Web.UI.WebControls.Button
    {
        private const string DEFAULT_CSS_CLASS = "btn";

        #region Properties

        public ButtonType ButtonType { get; set; }
        public ButtonSize ButtonSize { get; set; }
        public bool IsBlock { get; set; }
        public Glyphicons Glyphicon { get; set; }
        public GlyphiconPosition GlyphiconPosition { get; set; }

        protected override string TagName
        {
            get
            {
                return "button";
            }
        }

        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Button;
            }
        }

        #endregion

        #region Control Events

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (GlyphiconPosition == SeverControls.GlyphiconPosition.Left)
            {
                AddGlyphicon();
            }

            // Adds the text of the button
            var literal = new LiteralControl(this.Text);
            Controls.Add(literal);

            if (GlyphiconPosition == SeverControls.GlyphiconPosition.Right)
            {
                AddGlyphicon();
            }
        }

        private void AddGlyphicon()
        {
            // Adds the glyphicon
            var glyphiconTemplate = "<span class=\"glyphicon glyphicon-{0}\"></span>";
            
            if (GlyphiconPosition == GlyphiconPosition.Left)
            {
                glyphiconTemplate = glyphiconTemplate + "&nbsp;";
            }
            else
            {
                glyphiconTemplate = "&nbsp;" + glyphiconTemplate;
            }

            var glyphiconSpan = new LiteralControl(String.Format(glyphiconTemplate, Glyphicon.ToString().ToLower()));
            Controls.Add(glyphiconSpan);
        }

        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            base.CssClass = GetCssClass();

            base.Render(writer);
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            RenderChildren(writer);
        }

        #endregion

        #region Helper Methods
        
        private string GetCssClass()
        {
            var cssClassBuilder = new StringBuilder();
            cssClassBuilder.Append(DEFAULT_CSS_CLASS);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(GetButtonTypeCssClass());
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(GetButtonSizeCssClass());
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(IsBlock ? "btn-block" : String.Empty);
            cssClassBuilder.Append(" ");
            cssClassBuilder.Append(base.CssClass);

            return cssClassBuilder.ToString();
        }

        private string GetButtonTypeCssClass()
        {
            return "btn-" + ButtonType.ToString().ToLower();
        }

        private string GetButtonSizeCssClass()
        {
            var cssClass = string.Empty;

            switch (ButtonSize)
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

        #endregion
    }

    #region Enums

    public enum ButtonType
    {
        Default,
        Primary,
        Success,
        Info,
        Warning,
        Danger,
        Link
    }

    public enum ButtonSize
    {
        Default,
        Large,
        Small,
        ExtraSmall
    }

    #endregion
}
