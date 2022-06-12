using Tools.Validation;

namespace VectorLib
{
    public class Vector3D : IEquatable<Vector3D>
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        /// <summary>
        /// Calculates vector length (the origin is at the axis origin [0, 0, 0])
        /// </summary>
        /// <returns></returns>
        public double Length() => Math.Sqrt(X * X + Y * Y + Z * Z);

        public Vector3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public Vector3D(double x, double y) : this(x, y, .0) { }
        public Vector3D(double x) : this(x, .0, .0) { }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            Validate<Vector3D>.NotNull(v1, nameof(v1));
            Validate<Vector3D>.NotNull(v2, nameof(v2));

            return new(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            Validate<Vector3D>.NotNull(v1, nameof(v1));
            Validate<Vector3D>.NotNull(v2, nameof(v2));

            return new(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public static double operator *(Vector3D v1, Vector3D v2)
        {
            Validate<Vector3D>.NotNull(v1, nameof(v1));
            Validate<Vector3D>.NotNull(v2, nameof(v2));

            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        public static bool operator ==(Vector3D v1, Vector3D v2)
        {
            if (ReferenceEquals(v1, null))
            {
                if (ReferenceEquals(v2, null))
                {
                    return true;
                }

                return false;
            }

            return v1.Equals(v2);
        }
        public static bool operator !=(Vector3D v1, Vector3D v2) => !(v1 == v2);

        public bool Equals(Vector3D other)
        {
            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return X == other.X && Y == other.Y && Z == other.Z;
        }
        public override bool Equals(object obj)
        {
            return Equals((Vector3D)obj);
        }

        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        public override string ToString()
        {
            return X + ", " + Y + ", " + Z;
        }
    }
}
