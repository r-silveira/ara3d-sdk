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
    public partial struct Parabola: IRealFunction, IOpenShape
    {
        // Fields

        // With functions 

        // Regular Constructor

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Parabola Create() => new Parabola();

        // Static default implementation
        public static readonly Parabola Default = default;

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Parabola;
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Parabola other) => true;
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Parabola other) => false;
        [MethodImpl(AggressiveInlining)] public static Boolean operator==(Parabola a, Parabola b) => true;
        [MethodImpl(AggressiveInlining)] public static Boolean operator!=(Parabola a, Parabola b) => false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes();
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{  }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented interface functions
        [MethodImpl(AggressiveInlining)] public Number Eval(Number x) => x.Sqr;
public Boolean Closed { [MethodImpl(AggressiveInlining)] get  => ((Boolean)false); } 

        // Unimplemented interface functions
    }
    // Extension methods for the type
    public static class ParabolaExtensions
    {
    }
}
