using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using C2Group.Demo.Episerver.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace C2Group.Demo.Episerver.Models.Pages
{
    [ContentType(DisplayName = "Posts", GUID = "1d6b4fc1-ccdc-4ce0-a2bb-689bcf07d6a7", Description = "")]
    public class PostPage : StandardPage
    {
        [Display(
            Name = "Post List",
            Description = "Collection of Posts",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(AllowedTypes = new[] { typeof(PostBlock) })]
        public virtual ContentArea Posts { get; set; }
    }
}