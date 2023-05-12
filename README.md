# Cadmus Imaging Core

Core components for Cadmus imaging parts.

## GalleryImageAnnotationsPart

ID: `it.vedph.img.gallery-image-annotations`

- annotations (`GalleryImageAnnotation[]`):
  - id\* (`string`)
  - target\* (`GalleryImage`):
    - id\* (`string`)
    - uri\* (`string`)
    - title\* (`string`)
    - description (`string`)
  - selector\* (`string`)
  - note (`string`)
  - tags (`string[]`)

## History

### 0.0.2

- 2023-05-12: updated packages.
