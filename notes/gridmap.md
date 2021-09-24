# GridMap

*Project notes*



## Project in early stage

The ideas for this library are still coalescing, and its public API should be considered unstable.

Take a look if you are curious, but do not depend on this library just yet.



## About

GridMap is a C# library providing simple but efficient data model of grid-based 2D maps.

GridMap is borrowing on idea of feature objects present in GIS data systems. As such, a **Map** is a collection of **Features** where each feature has a geometry (**GridShape** in this case) and an arbitrary collection of **Attributes**.

Based on this data model, GridMap offers a range of algorithms allowing you to test spatial relations of features, find paths and more.

Grid maps are usually graphically represented with tiles. Although GridMap doesn't have any rendering functionality, it will provide auto-tiling algorithms allowing to automatically compute tile index for each cell. 



## Backlog

Feature object model consisting of geometry (grid shape) and attributes.

List of common attributes:

- walkable
- swimmable
- flyable
- tilemap

Obstructions - objects rendering certain fields inaccessible

Cumulative attributes

List of adjacent features

Filtering by attribute

Getting summed up list of cells by attribute or other criteria

List of overlapping features

List of features at cell

Path finding

List of interface cells

