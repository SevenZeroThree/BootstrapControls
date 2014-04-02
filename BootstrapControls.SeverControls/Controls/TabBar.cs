using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BootstrapControls.WebForms.Controls
{
    [
    AspNetHostingPermission(SecurityAction.Demand,
        Level = AspNetHostingPermissionLevel.Minimal),
    AspNetHostingPermission(SecurityAction.InheritanceDemand,
        Level = AspNetHostingPermissionLevel.Minimal),
    DefaultProperty("TabItems"),
    ParseChildren(true, "TabItems"),
    ToolboxData(
        "<{0}:TabBar runat=\"server\"> </{0}:TabBar>")
    ]
    public class TabBar : WebControl
    {
        private List<TabItem> _tabItems;

        [
        Category("Behavior"),
        Description("The contacts collection"),
        DesignerSerializationVisibility(
            DesignerSerializationVisibility.Content),
        //Editor(typeof(ContactCollectionEditor), typeof(UITypeEditor)),
        PersistenceMode(PersistenceMode.InnerDefaultProperty)
        ]
        public List<TabItem> TabItems
        {
            get
            {
                if (_tabItems == null)
                {
                    _tabItems = new List<TabItem>();
                }
                return _tabItems;
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            // This prevents asp.net from wrapping the control in a span tag
            RenderContents(writer);
        }

        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute("class", "nav nav-tabs");
            writer.RenderBeginTag(HtmlTextWriterTag.Ul);
            foreach (var tabItem in _tabItems)
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
                writer.AddAttribute("href", "#" + tabItem.Name);
                writer.AddAttribute("data-toggle", "tab");
                writer.RenderBeginTag(HtmlTextWriterTag.A);
                writer.Write(tabItem.Name);
                writer.RenderEndTag();
                writer.RenderEndTag();
            }

            writer.RenderEndTag();

            writer.AddAttribute("class", "tab-content");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            foreach (var tabItem in _tabItems)
            {
                writer.AddAttribute("id", tabItem.Name);
                writer.AddAttribute("class", "tab-pane");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                writer.Write(tabItem.InnerHtml);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }
    }

    [ParseChildren(true, "InnerHtml")]
    public class TabItem
    {
        public TabItem()
            : this(String.Empty)
        {

        }

        public TabItem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        [ReadOnly(true)]
        public string InnerHtml { get; set; }
    }
}
