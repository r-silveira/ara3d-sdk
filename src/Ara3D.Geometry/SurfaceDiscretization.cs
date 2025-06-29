﻿using Ara3D.Collections;

namespace Ara3D.Geometry
{
    /// <summary>
    /// This class is used for sampling parameterized surfaces and computing quad-mesh strip indices.
    /// column == u (x), row == v (y)
    /// </summary>
    public class SurfaceDiscretization
    {
        public IReadOnlyList<Number> Us { get; }
        public IReadOnlyList<Number> Vs { get; }
        public IReadOnlyList2D<Vector2> Uvs { get; }
        public bool ClosedU { get; }
        public bool ClosedV { get; }
        public IReadOnlyList2D<Integer4> QuadIndices { get; }

        public SurfaceDiscretization(Integer nColumns, Integer nRows, bool closedU, bool closedV)
        {
            ClosedU = closedU;
            ClosedV = closedV;
            
            Us = closedU 
                ? nColumns.LinearSpace
                : (nColumns + 1).LinearSpace;
            Vs = closedV
                ? nColumns.LinearSpace
                : (nColumns + 1).LinearSpace;

            Uvs = Vs.CartesianProduct(Us, (u, v) => new Vector2(u, v));
            
            QuadIndices = nRows.Range.CartesianProduct(nColumns.Range, (y, x) => QuadMeshFaceVertices(x, y, Us.Count, Vs.Count));
        }

        public static Integer4 QuadMeshFaceVertices(Integer col, Integer row, Integer nx, Integer ny)
        {
            var a = row * nx + col;
            var b = row * nx + (col + 1) % nx;
            var c = (row + 1) % ny * nx + (col + 1) % nx;
            var d = (row + 1) % ny * nx + col;
            return (a, b, c, d);
        }

    }
}