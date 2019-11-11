using System;
using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace C2Group.Demo.Episerver.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", GUID = "f84917f4-f2cd-4ab7-95f7-957d62b7b792", Description = "")]
    public class TeaserBlock : BlockData
    {

        [Display(
            Name = "Teaser Title",
            Description = "Bold top portion of Teaser",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual string TeaserTitle { get; set; }

        [Display(
            Name = "Teaser Copy",
            Description = "Teaser copy",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual string TeaserCopy { get; set; }

    }
}