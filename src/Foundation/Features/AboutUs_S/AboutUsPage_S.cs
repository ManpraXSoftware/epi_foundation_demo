using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Foundation.Features.Shared;
using Foundation.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Features.AboutUs_S
{
    [ContentType(DisplayName = "About Us Page",
      GUID = "01237655-ef7b-47a2-a399-985f513bb4ec",
      Description = "Used for About Us page of all sites",
      AvailableInEditMode = true,
      GroupName = GroupNames.Content)]
    [ImageUrl("~/assets/icons/cms/pages/CMS-icon-page-02.png")]
    public class AboutUsPage_S : FoundationPageData
    {
        [CultureSpecific]
        [Display(Name = "Sub content area", GroupName = SystemTabNames.Content, Order = 200)]
        public virtual ContentArea SubContentArea { get; set; }
    }
}