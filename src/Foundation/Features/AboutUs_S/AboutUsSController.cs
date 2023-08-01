using EPiServer.Tracking.PageView;
using EPiServer.Web.Mvc;
using Foundation.Features.Home;
using Foundation.Features.Shared;
using System.Web.Mvc;

namespace Foundation.Features.AboutUs_S
{
    public class AboutUsSController : PageController<AboutUsPage_S>
    {
        [PageViewTracking]
        public ActionResult Index(AboutUsPage_S currentContent) => View(ContentViewModel.Create<AboutUsPage_S>(currentContent));
    }
}