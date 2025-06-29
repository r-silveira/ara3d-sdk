// Autogenerated file: DO NOT EDIT
// Created on 2025-06-07 6:14:52 PM

using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using static System.Runtime.CompilerServices.MethodImplOptions;
using Ara3D.Collections;

namespace Ara3D.Geometry
{
    [DataContract, StructLayout(LayoutKind.Sequential, Pack=1)]
    public partial struct Polygon: IPolygon2D<Polygon>
    {
        // Fields
        [DataMember] public readonly IReadOnlyList<Point2D> Points;

        // With functions 
        [MethodImpl(AggressiveInlining)] public Polygon WithPoints(IReadOnlyList<Point2D> points) => new Polygon(points);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public Polygon(IReadOnlyList<Point2D> points) { Points = points; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Polygon Create(IReadOnlyList<Point2D> points) => new Polygon(points);

        // Static default implementation
        public static readonly Polygon Default = default;

        // Implicit converters to/from single field

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Polygon other) => Points.Equals(other.Points);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Polygon other) => !Points.Equals(other.Points);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Polygon other ? Equals(other).Value : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Points);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Points\" = {Points} }}";

        // Explicit implementation of interfaces by forwarding properties to fields
        IReadOnlyList<Point2D> IPointGeometry2D<Polygon>.Points { [MethodImpl(AggressiveInlining)] get => Points; }

        // Implemented interface functions
        [MethodImpl(AggressiveInlining)] public IReadOnlyList<Point2D> Sample(Integer numPoints){
            var _var51 = this;
            return numPoints.LinearSpace.Map((x)  => _var51.Eval(x));
        }

[MethodImpl(AggressiveInlining)] public PolyLine2D ToPolyLine2D(Integer numPoints) => (this.Sample(numPoints), this.Closed);
public Boolean Closed { [MethodImpl(AggressiveInlining)] get  => ((Boolean)true); } 

        // Unimplemented interface functions
        [MethodImpl(AggressiveInlining)] public Polygon Deform(System.Func<Point2D, Point2D> f) => throw new NotImplementedException();
[MethodImpl(AggressiveInlining)] public Point2D Eval(Number t) => throw new NotImplementedException();
[MethodImpl(AggressiveInlining)] public Polygon Transform(Transform2D t) => throw new NotImplementedException();
}
    // Extension methods for the type
    public static class PolygonExtensions
    {
        [MethodImpl(AggressiveInlining)] public static Polygon Deform(this Polygon x, System.Func<Point2D, Point2D> f) => x.Deform(f);
        [MethodImpl(AggressiveInlining)] public static Point2D Eval(this Polygon x, Number t) => x.Eval(t);
        [MethodImpl(AggressiveInlining)] public static Polygon Transform(this Polygon x, Transform2D t) => x.Transform(t);
    }
}
