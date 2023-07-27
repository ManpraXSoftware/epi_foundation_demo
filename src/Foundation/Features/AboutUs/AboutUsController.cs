using EPiServer.Tracking.PageView;
using EPiServer.Web.Mvc;
using Foundation.Features.Shared;
using System.Web.Mvc;

namespace Foundation.Features.AboutUs
{
    public class AboutUsController : PageController<AboutUsPage>
    {
        [PageViewTracking]
        public ActionResult Index(AboutUsPage currentContent) => View(ContentViewModel.Create<AboutUsPage>(currentContent));
    }
}