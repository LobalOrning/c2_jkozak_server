using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Forms.Core.Models;
using EPiServer.SpecializedProperties;

namespace C2Group.Demo.Episerver.Models.Pages
{
    [ContentType(DisplayName = "ContactPage", GUID = "9a657085-55a6-4978-a1d6-4341387b46d0", Description = "")]
    public class ContactPage : StandardPage
    {
        [Display(
            Name = "Contact Form",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual ContentArea ContactForm { get; set; }
    }
}