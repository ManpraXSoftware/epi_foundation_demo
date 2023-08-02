using EPiServer;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;
using Foundation.Features.Blocks.ButtonBlock;
using Foundation.Features.Shared;
using Foundation.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Features.Blocks.AboutUsNewwBlock
{
    [ContentType(DisplayName = "AboutUs New Block",
        GUID = "DBD4E197-A516-4B0D-A971-81249CC2777D",
        Description = "Used to insert a links which is styled as a list",
        GroupName = GroupNames.Content,
        AvailableInEditMode = true)]
    [ImageUrl("~/assets/icons/cms/blocks/CMS-icon-block-26.png")]
    public class AboutUsNewwBlock : FoundationBlockData
    {       
        [CultureSpecific]
        [Display(Name = "Heading", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        //[Searchable(false)]
        //[SelectOne(SelectionFactoryType = typeof(AboutUsNewwBlockStyleSelectionFactory))]
        //[Display(Name = "Style", Order = 30, GroupName = SystemTabNames.Content)]
        //public virtual string HeadingStyle { get; set; }

        [Display(Name = "Heading Link", Order = 20, GroupName = SystemTabNames.Content)]
        public virtual Url HeadingLink { get; set; }

        [Display(Name = "Links", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual LinkItemCollection Links { get; set; }

        [CultureSpecific]
        [Display(Name = "Description", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual string Description { get; set; }
    }
}