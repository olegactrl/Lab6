using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    public class Quaternion
    {
        public double W { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Quaternion(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        public static Quaternion operator +(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.W + q2.W, q1.X + q2.X, q1.Y + q2.Y, q1.Z + q2.Z);
        }

        public static Quaternion operator -(Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
        }

        public static Quaternion operator *(Quaternion q1, Quaternion q2)
        {
            double w = q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z;
            double x = q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y;
            double y = q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X;
            double z = q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W;

            return new Quaternion(w, x, y, z);
        }

        public double Magnitude()
        {
            return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(W, -X, -Y, -Z);
        }

        public Quaternion Inverse()
        {
            double magnitudeSquared = W * W + X * X + Y * Y + Z * Z;
            if (magnitudeSquared > 0)
            {
                double inverseMagnitudeSquared = 1.0 / magnitudeSquared;
                return new Quaternion(W * inverseMagnitudeSquared, -X * inverseMagnitudeSquared, -Y * inverseMagnitudeSquared, -Z * inverseMagnitudeSquared);
            }
            else
            {
                throw new InvalidOperationException("Cannot invert a quaternion with zero magnitude.");
            }
        }

        public static bool operator ==(Quaternion q1, Quaternion q2)
        {
            return q1.W == q2.W && q1.X == q2.X && q1.Y == q2.Y && q1.Z == q2.Z;
        }

        public static bool operator !=(Quaternion q1, Quaternion q2)
        {
            return !(q1 == q2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Quaternion)
            {
                Quaternion other = (Quaternion)obj;
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
    }
}
