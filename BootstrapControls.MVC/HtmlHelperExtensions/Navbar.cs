using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.MVC.HtmlHelperExtensions
{
    public static class NavbarHelpers
    {
        public static MvcHtmlString Navbar(this BootstrapHtmlHelper helper, string applicationName, IDictionary<string, string> links)
        {
            return helper.Navbar(applicationName, links, null);
        }

        public static MvcHtmlString Navbar(this BootstrapHtmlHelper helper, string applicationName, IDictionary<string, string> links, object htmlAttributes)
        {
            var navWrapper = new TagBuilder("div");
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;

            navWrapper.MergeAttributes(attributes);
            navWrapper.AddCssClass("navbar navbar-default");
            navWrapper.Attributes["role"] = "navigation";

            var navContainer = new TagBuilder("div");
            navContainer.AddCssClass("container");

            var navHeader = new TagBuilder("div");
            navHeader.AddCssClass("navbar-header");

            var navCollapseButton = new TagBuilder("button");
            navCollapseButton.AddCssClass("navbar-toggle");
            navCollapseButton.Attributes["type"] = "button";
            navCollapseButton.Attributes["data-toggle"] = "collapse";
            navCollapseButton.Attributes["data-target"] = ".navbar-collapse";

            var navIconBar = new TagBuilder("span");
            navIconBar.AddCssClass("icon-bar");

            navCollapseButton.InnerHtml = navIconBar.ToString() + navIconBar.ToString() + navIconBar.ToString();

            var applicationNameTag = new TagBuilder("a");
            applicationNameTag.Attributes["href"] = "/";
            applicationNameTag.AddCssClass("navbar-brand");
            applicationNameTag.InnerHtml = applicationName;


            navHeader.InnerHtml = navCollapseButton.ToString() + applicationNameTag.ToString();

            var navCollapse = new TagBuilder("div");
            navCollapse.AddCssClass("navbar-collapse collapse");

            var navbarNav = new TagBuilder("ul");
            navbarNav.AddCssClass("nav navbar-nav");

            if (links != null)
            {
                foreach (var link in links)
                {
                    var navBarItem = new TagBuilder("li");

                    var navbarItemLink = new TagBuilder("a");
                    navbarItemLink.Attributes["href"] = link.Value;
                    navbarItemLink.InnerHtml = link.Key;

                    navBarItem.InnerHtml = navbarItemLink.ToString();
                    navbarNav.InnerHtml += navBarItem.ToString();
                }
            }

            navCollapse.InnerHtml = navbarNav.ToString();

            navContainer.InnerHtml = navHeader.ToString() + navCollapse.ToString();
            navWrapper.InnerHtml = navContainer.ToString();

            //if (icon != Glyphicon.NONE)
            //{
            //    navWrapper.InnerHtml = helper.Glyphicon(icon) + " ";
            //}

            //navWrapper.InnerHtml = navWrapper.InnerHtml + value;

            return MvcHtmlString.Create(navWrapper.ToString());
        }
    }
}
