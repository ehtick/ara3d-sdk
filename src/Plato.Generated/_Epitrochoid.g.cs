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
    public partial struct Epitrochoid: IAngularCurve2D, IOpenShape
    {
        // Fields
        [DataMember] public readonly Number Radius1;
        [DataMember] public readonly Number Radius2;
        [DataMember] public readonly Number Dist;

        // With functions 
        [MethodImpl(AggressiveInlining)] public Epitrochoid WithRadius1(Number radius1) => new Epitrochoid(radius1, Radius2, Dist);
        [MethodImpl(AggressiveInlining)] public Epitrochoid WithRadius2(Number radius2) => new Epitrochoid(Radius1, radius2, Dist);
        [MethodImpl(AggressiveInlining)] public Epitrochoid WithDist(Number dist) => new Epitrochoid(Radius1, Radius2, dist);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public Epitrochoid(Number radius1, Number radius2, Number dist) { Radius1 = radius1; Radius2 = radius2; Dist = dist; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static Epitrochoid Create(Number radius1, Number radius2, Number dist) => new Epitrochoid(radius1, radius2, dist);

        // Static default implementation
        public static readonly Epitrochoid Default = default;

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Number, Number, Number)(Epitrochoid self) => (self.Radius1, self.Radius2, self.Dist);
        [MethodImpl(AggressiveInlining)] public static implicit operator Epitrochoid((Number, Number, Number) value) => new Epitrochoid(value.Item1, value.Item2, value.Item3);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Number radius1, out Number radius2, out Number dist) { radius1 = Radius1; radius2 = Radius2; dist = Dist;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(Epitrochoid other) => Radius1.Equals(other.Radius1) && Radius2.Equals(other.Radius2) && Dist.Equals(other.Dist);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(Epitrochoid other) => !Radius1.Equals(other.Radius1) && Radius2.Equals(other.Radius2) && Dist.Equals(other.Dist);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is Epitrochoid other ? Equals(other).Value : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Radius1, Radius2, Dist);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Radius1\" = {Radius1}, \"Radius2\" = {Radius2}, \"Dist\" = {Dist} }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented interface functions
        [MethodImpl(AggressiveInlining)] public Point2D Eval(Angle t) => t.Epitrochoid(this.Radius1, this.Radius2, this.Dist);
[MethodImpl(AggressiveInlining)] public Point2D Eval(Number t) => this.Eval(t.Turns);
[MethodImpl(AggressiveInlining)] public IReadOnlyList<Point2D> Sample(Integer numPoints){
            var _var18 = this;
            return numPoints.LinearSpace.Map((x)  => _var18.Eval(x));
        }

[MethodImpl(AggressiveInlining)] public PolyLine2D ToPolyLine2D(Integer numPoints) => (this.Sample(numPoints), this.Closed);
public Boolean Closed { [MethodImpl(AggressiveInlining)] get  => ((Boolean)false); } 

        // Unimplemented interface functions
    }
    // Extension methods for the type
    public static class EpitrochoidExtensions
    {
    }
}
