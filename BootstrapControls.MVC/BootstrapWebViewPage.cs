using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapControls.MVC
{
    public abstract class BootstrapWebViewPage : WebViewPage
    {
        public BootstrapHtmlHelper Bootstrap { get; set; }

        public override void InitHelpers()
        {
            base.InitHelpers();
            Bootstrap = new BootstrapHtmlHelper<object>(base.ViewContext, this);
        }
    }

    public abstract class BootstrapWebViewPage<TModel> : BootstrapWebViewPage
    {
        public new BootstrapHtmlHelper<TModel> Bootstrap { get; set; }

        public override void InitHelpers()
        {
            base.InitHelpers();
            Bootstrap = new BootstrapHtmlHelper<TModel>(base.ViewContext, this);
        }
    }
}
