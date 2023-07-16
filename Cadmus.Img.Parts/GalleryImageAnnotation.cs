using System;

namespace Cadmus.Img.Parts;

/// <summary>
/// Base class for annotations targeting a <see cref="GalleryImage"/>. Derive
/// your own annotation from this type by adding new properties to it.
/// </summary>
public class GalleryImageAnnotation
{
    /// <summary>
    /// Gets or sets the image identifier. By default this is a GUID
    /// prefixed by a hash character, but you can use any other type of
    /// identifiers.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Essential metadata about the target image.
    /// </summary>
    public GalleryImage? Target { get; set; }

    /// <summary>
    /// Gets or sets the selector used for defining the portion of the image
    /// being annotated.
    /// </summary>
    public string Selector { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GalleryImageAnnotation"/>
    /// class.
    /// </summary>
    public GalleryImageAnnotation()
    {
        Id = "#" + Guid.NewGuid().ToString();
        Selector = "";
    }

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return $"{Id} => {Target}";
    }
}
