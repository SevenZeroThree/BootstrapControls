using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace BootstrapControls.MVC
{
    public class BootstrapHtmlHelper
    {
        public ViewDataDictionary ViewData
        {
            get;
            private set;
        }

        public ViewContext ViewContext
        {
            get;
            private set;
        }

        public BootstrapHtmlHelper(ViewContext viewContext, IViewDataContainer viewDataContainer)
            : this(viewContext, viewDataContainer, RouteTable.Routes) { }

        public BootstrapHtmlHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection)
        {
            ViewContext = viewContext;
            ViewData = new ViewDataDictionary(viewDataContainer.ViewData);
        }
    }

    public class BootstrapHtmlHelper<TModel> : BootstrapHtmlHelper
    {
        public new ViewDataDictionary<TModel> ViewData
        {
            get;
            private set;
        }

        public BootstrapHtmlHelper(ViewContext viewContext, IViewDataContainer container)
            : this(viewContext, container, RouteTable.Routes) { }

        public BootstrapHtmlHelper(ViewContext viewContext, IViewDataContainer viewDataContainer, RouteCollection routeCollection)
            :base(viewContext, viewDataContainer, routeCollection)
        {
            ViewData = new ViewDataDictionary<TModel>(viewDataContainer.ViewData);
        }
    }
}
