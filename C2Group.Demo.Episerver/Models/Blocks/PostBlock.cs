using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace C2Group.Demo.Episerver.Models.Blocks
{
    [ContentType(DisplayName = "PostBlock", GUID = "c0c7b76a-89cb-4fdb-a571-e5c42e99d03b", Description = "")]
    public class PostBlock : BlockData
    {
        [Display(
            Name = "Post Header Copy",
            Description = "Post header copy",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string HeaderCopy { get; set; }

        [Display(
            Name = "Post Main Copy",
            Description = "Post main copy",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [UIHint(UIHint.Textarea)]
        public virtual string MainCopy { get; set; }

        [Display(
            Name = "Post Author Name",
            Description = "Post author name",
            GroupName = SystemTabNames.Content)]
        public virtual string AuthorName { get; set; }

    }
}