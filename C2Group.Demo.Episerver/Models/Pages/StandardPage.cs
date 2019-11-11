using System;
using System.ComponentModel.DataAnnotations;

using C2Group.Demo.Episerver.Models.Blocks;

using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace C2Group.Demo.Episerver.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "47e532e8-9195-4df7-8fb9-c9d840efbfbc", Description = "")]
    public class StandardPage : PageData
    {
        [Display(
             Name = "Header Image Desktop",
             GroupName = SystemTabNames.Content,
             Order = 0)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageDesktop { get; set; }

        [Display(
            Name = "Header Image Mobile",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageMobile { get; set; }

        [Display(
            Name = "About Link",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual PageReference AboutPageReference { get; set; }

        [Display(
            Name = "Contact Link",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual PageReference ContactPageReference { get; set; }

        [Display(
            Name = "Home Link",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual PageReference HomePageReference { get; set; }

        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Teaser",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        [UIHint(UIHint.Block)]
        public virtual TeaserBlock TeaserBlock { get; set; }
    }
}