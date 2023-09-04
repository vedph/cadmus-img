# Cadmus Imaging Core

Core components for Cadmus imaging parts.

## W3CGalleryImageAnnotationsPart

ID: `it.vedph.img.w3c-gallery-image-annotations`

- annotations (`W3CGalleryImageAnnotation[]`):
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

### 2.0.1

- 2023-09-04: updated packages.

### 2.0.0

- 2023-07-14: refactored models so that now the previous annotation and its part are W3C-types, whereas `GalleryImageAnnotation` is just a base class for project-specific concrete types. The part and its tag have been renamed accordingly.

### 1.0.1

- 2023-06-17: updated packages.
- 2023-06-02: updated test packages.

### 1.0.0

- 2023-05-24: updated packages (breaking change in general parts introducing [AssertedCompositeId](https://github.com/vedph/cadmus-bricks-shell/blob/master/projects/myrmidon/cadmus-refs-asserted-ids/README.md#asserted-composite-id)).

### 0.0.2

- 2023-05-12: updated packages.
