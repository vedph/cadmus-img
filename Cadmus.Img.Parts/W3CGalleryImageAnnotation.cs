using System.Collections.Generic;

namespace Cadmus.Img.Parts;

/// <summary>
/// A gallery image annotation using a W3C-like model for annotations
/// compatible with the default Annotorious model. This can be used for
/// default Annotorious annotations using the preset UI provided by that
/// library.
/// </summary>
/// <seealso cref="GalleryImageAnnotation" />
public class W3CGalleryImageAnnotation : GalleryImageAnnotation
{
    /// <summary>
    /// Gets or sets an optional set of notes in the annotation's body.
    /// </summary>
    public List<string>? Notes { get; set; }

    /// <summary>
    /// Gets or sets an optional set of tags in the annotation's body.
    /// </summary>
    public List<string>? Tags { get; set; }

    public W3CGalleryImageAnnotation()
    {
        Notes = new List<string>();
        Tags = new List<string>();
    }
}
