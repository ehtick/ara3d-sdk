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
    public partial struct PlaneProjection3D: ITransform3D
    {
        // Fields
        [DataMember] public readonly Vector3 Direction;
        [DataMember] public readonly Plane Plane;

        // With functions 
        [MethodImpl(AggressiveInlining)] public PlaneProjection3D WithDirection(Vector3 direction) => new PlaneProjection3D(direction, Plane);
        [MethodImpl(AggressiveInlining)] public PlaneProjection3D WithPlane(Plane plane) => new PlaneProjection3D(Direction, plane);

        // Regular Constructor
        [MethodImpl(AggressiveInlining)] public PlaneProjection3D(Vector3 direction, Plane plane) { Direction = direction; Plane = plane; }

        // Static factory function
        [MethodImpl(AggressiveInlining)] public static PlaneProjection3D Create(Vector3 direction, Plane plane) => new PlaneProjection3D(direction, plane);

        // Static default implementation
        public static readonly PlaneProjection3D Default = default;

        // Implicit converters to/from value-tuples and deconstructor
        [MethodImpl(AggressiveInlining)] public static implicit operator (Vector3, Plane)(PlaneProjection3D self) => (self.Direction, self.Plane);
        [MethodImpl(AggressiveInlining)] public static implicit operator PlaneProjection3D((Vector3, Plane) value) => new PlaneProjection3D(value.Item1, value.Item2);
        [MethodImpl(AggressiveInlining)] public void Deconstruct(out Vector3 direction, out Plane plane) { direction = Direction; plane = Plane;  }

        // Object virtual function overrides: Equals, GetHashCode, ToString
        [MethodImpl(AggressiveInlining)] public Boolean Equals(PlaneProjection3D other) => Direction.Equals(other.Direction) && Plane.Equals(other.Plane);
        [MethodImpl(AggressiveInlining)] public Boolean NotEquals(PlaneProjection3D other) => !Direction.Equals(other.Direction) && Plane.Equals(other.Plane);
        [MethodImpl(AggressiveInlining)] public override bool Equals(object obj) => obj is PlaneProjection3D other ? Equals(other).Value : false;
        [MethodImpl(AggressiveInlining)] public override int GetHashCode() => Intrinsics.CombineHashCodes(Direction, Plane);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"{{ \"Direction\" = {Direction}, \"Plane\" = {Plane} }}";

        // Explicit implementation of interfaces by forwarding properties to fields

        // Implemented interface functions
        public Matrix4x4 Matrix { [MethodImpl(AggressiveInlining)] get  => Ara3D.Geometry.Matrix4x4.CreateShadow(this.Direction, this.Plane); } 
[MethodImpl(AggressiveInlining)] public Point3D Multiply(Point3D v) => this.TransformPoint(v);
[MethodImpl(AggressiveInlining)]  public static Point3D operator *(PlaneProjection3D x, Point3D v) => x.Multiply(v);
        [MethodImpl(AggressiveInlining)] public Vector3 Multiply(Vector3 v) => this.TransformNormal(v);
[MethodImpl(AggressiveInlining)]  public static Vector3 operator *(PlaneProjection3D x, Vector3 v) => x.Multiply(v);
        [MethodImpl(AggressiveInlining)] public Transform3D Multiply(Matrix4x4 m) => this.Compose(m);
[MethodImpl(AggressiveInlining)]  public static Transform3D operator *(PlaneProjection3D x, Matrix4x4 m) => x.Multiply(m);
        public Transform3D Transform3D { [MethodImpl(AggressiveInlining)] get  => this.Matrix; } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Transform3D(PlaneProjection3D x) => x.Transform3D;
        [MethodImpl(AggressiveInlining)] public Point3D TransformPoint(Point3D v) => v.Vector3.Transform(this.Matrix);
[MethodImpl(AggressiveInlining)] public Vector3 TransformNormal(Vector3 v) => v.TransformNormal(this.Matrix);
public Matrix4x4 Matrix4x4 { [MethodImpl(AggressiveInlining)] get  => this.Matrix; } 
[MethodImpl(AggressiveInlining)]  public static implicit operator Matrix4x4(PlaneProjection3D t) => t.Matrix4x4;
        public Transform3D Invert { [MethodImpl(AggressiveInlining)] get  => this.Matrix.Invert; } 
[MethodImpl(AggressiveInlining)] public Transform3D Compose(Matrix4x4 m) => this.Matrix.Multiply(m);

        // Unimplemented interface functions
    }
    // Extension methods for the type
    public static class PlaneProjection3DExtensions
    {
    }
}
