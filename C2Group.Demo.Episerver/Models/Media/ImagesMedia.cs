using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace C2Group.Demo.Episerver.Models.Media
{
    [ContentType(DisplayName = "ImagesMedia", GUID = "a4afb648-f7c0-4207-8ac0-f0c532de99ca", Description = "Used for generic image types")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImagesMedia : ImageData
    {
    }
}