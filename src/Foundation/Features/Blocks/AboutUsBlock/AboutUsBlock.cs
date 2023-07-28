using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using Foundation.Features.Shared;
using Foundation.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Features.Blocks.AboutUsBlock
{
    [ContentType(DisplayName = "AboutUs Block",
        GUID = "D225C4CB-EE51-4287-89E3-57AE51C755F5",
        Description = "Used to insert a links which is styled as a list",
        GroupName = GroupNames.Content,
        AvailableInEditMode = true)]
    [ImageUrl("~/assets/icons/cms/blocks/CMS-icon-block-26.png")]
    public class AboutUsBlock : FoundationBlockData
    {
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        #region Content        
        [Display(Name = "Link", Order = 20, GroupName = SystemTabNames.Content)]
        public virtual Url ButtonLink { get; set; }

        [CultureSpecific]
        [Display(Name = "Reassuring caption", Order = 40, GroupName = SystemTabNames.Content, Prompt = "Cancel anytime...")]
        public virtual string ButtonCaption { get; set; }
        #endregion
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);            
        }        
    }
}