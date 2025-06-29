﻿namespace Ara3D.Studio.Samples;

public class QuadDemo : IModelGenerator
{
    [Range(0f, 10f)] public float Scale = 1f;

    public bool DoubleSided;
    public bool Flip;

    public static IReadOnlyList2D<T> ToArray2D<T>(T[] xs, int rows)
    {
        var cols = xs.Length / rows;
        if (xs.Length % cols != 0) throw new Exception($"Number of values {xs.Length} not divisible by {rows}");
        return new FunctionalReadOnlyList2D<T>(cols, rows, (col, row) => xs[row * cols + col]);
    }

    public Model3D Eval(EvalContext eval)
    {
        // Bottom Row
        var x00 = new Point3D(-0.5f, -0.5f, 0);
        var x01 = new Point3D(+0.5f, -0.5f, 0);
        // Top Row
        var x10 = new Point3D(-0.5f, +0.5f, 0);
        var x11 = new Point3D(+0.5f, +0.5f, 0);
        var points = ToArray2D([x00, x01, x10, x11], 2).Map(p => p * Scale);
        var grid = new QuadGrid3D(points, false, false);
        var result = grid.Triangulate();
        if (Flip)
            result = result.FlipFaces();
        if (DoubleSided)
            result = result.DoubleSided();
        var element = new Element(result, new Material(new Color(0.8f, 0.4f, 0.2f, 1.0f), 0.5f, 0.2f));
        return element;
    }
}