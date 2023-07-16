﻿using Cadmus.Core;
using Fusi.Tools.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadmus.Img.Parts;

/// <summary>
/// A set of annotations targeting an image picked from a gallery.
/// <para>Tag: <c>it.vedph.img.w3c-gallery-image-annotations</c>.</para>
/// </summary>
[Tag("it.vedph.img.w3c-gallery-image-annotations")]
public sealed class W3CGalleryImageAnnotationsPart : PartBase
{
    /// <summary>
    /// Gets or sets the annotations.
    /// </summary>
    public List<W3CGalleryImageAnnotation> Annotations { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GalleryImageAnnotationPart"/>
    /// class.
    /// </summary>
    public W3CGalleryImageAnnotationsPart()
    {
        Annotations = new List<W3CGalleryImageAnnotation>();
    }

    /// <summary>
    /// Get all the key=value pairs (pins) exposed by the implementor.
    /// </summary>
    /// <param name="item">The optional item. The item with its parts
    /// can optionally be passed to this method for those parts requiring
    /// to access further data.</param>
    /// <returns>The pins: <c>tot-count</c> and a collection of pins with
    /// these keys: ....</returns>
    public override IEnumerable<DataPin> GetDataPins(IItem? item = null)
    {
        DataPinBuilder builder = new(DataPinHelper.DefaultFilter);

        builder.Set("tot", Annotations?.Count ?? 0, false);

        if (Annotations?.Count > 0)
        {
            foreach (W3CGalleryImageAnnotation annotation in Annotations)
            {
                builder.AddValue("id", annotation.Id);

                if (!string.IsNullOrEmpty(annotation.Target?.Id))
                    builder.AddValue("target-id", annotation.Target.Id);

                // by convention, a tag prefixed with "eid_" is assumed
                // to represent an EID with its value following the prefix
                if (annotation.Tags?.Count > 0)
                {
                    foreach (string tag in annotation.Tags.Where(t =>
                        t.Length > 4 &&
                        t.StartsWith("eid_", StringComparison.Ordinal)))
                    {
                        builder.AddValue("eid", tag[4..]);
                    }
                }
            }
        }

        return builder.Build(this);
    }

    /// <summary>
    /// Gets the definitions of data pins used by the implementor.
    /// </summary>
    /// <returns>Data pins definitions.</returns>
    public override IList<DataPinDefinition> GetDataPinDefinitions()
    {
        return new List<DataPinDefinition>(new[]
        {
            new DataPinDefinition(DataPinValueType.Integer,
               "tot-count",
               "The total count of annotations."),
            new DataPinDefinition(DataPinValueType.String,
                "target-id", "The target ID(s) of the annotations images."),
            new DataPinDefinition(DataPinValueType.String,
                "eid", "The EID(s) assigned to annotations.")
        });
    }

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append("[GalleryImageAnnotations]");

        if (Annotations?.Count > 0)
        {
            sb.Append(' ');
            int n = 0;
            foreach (var entry in Annotations)
            {
                if (++n > 3) break;
                if (n > 1) sb.Append("; ");
                sb.Append(entry);
            }
            if (Annotations.Count > 3)
                sb.Append("...(").Append(Annotations.Count).Append(')');
        }

        return sb.ToString();
    }
}
