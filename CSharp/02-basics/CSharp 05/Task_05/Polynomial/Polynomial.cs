using System.Text;
using Tools.Validation;

namespace PolynomialLib
{
    public class Polynomial : IEquatable<Polynomial>
    {
        private double[] Coeffs { get; set; }
        public int CoeffNumber => Coeffs.Length;
        public double this[int idx]
        {
            get { return Coeffs[idx]; }
            private set { Coeffs[idx] = value; }
        }

        private Polynomial(int coeffsNumber)
        {
            Coeffs = new double[coeffsNumber];
        }
        public Polynomial(double a0, double a1) : this(2)
        {
            Coeffs[0] = a0;
            Coeffs[1] = a1;
        }
        public Polynomial(double a0, double a1, double a2) : this(3)
        {
            Coeffs[0] = a0;
            Coeffs[1] = a1;
            Coeffs[2] = a2;
        }
        public Polynomial(double a0, double a1, double a2, double a3) : this(4)
        {
            Coeffs[0] = a0;
            Coeffs[1] = a1;
            Coeffs[2] = a2;
            Coeffs[3] = a3;
        }
        public Polynomial(params double[] coeffs) : this(coeffs.Length)
        {
            for (int i = 0; i < CoeffNumber; i++)
            {
                Coeffs[i] = coeffs[i];
            }
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            Validate<Polynomial>.NotNull(p1, nameof(p1));
            Validate<Polynomial>.NotNull(p2, nameof(p2));

            var temp = new Polynomial(Math.Max(p1.CoeffNumber, p2.CoeffNumber));

            for (int i = 0; i < temp.CoeffNumber; i++)
            {
                if (i < p1.CoeffNumber)
                {
                    temp[i] += p1[i];
                }
                if (i < p2.CoeffNumber)
                {
                    temp[i] += p2[i];
                }
            }

            return temp;
        }
        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            Validate<Polynomial>.NotNull(p1, nameof(p1));
            Validate<Polynomial>.NotNull(p2, nameof(p2));

            var temp = new Polynomial(Math.Max(p1.CoeffNumber, p2.CoeffNumber));

            for (int i = 0; i < temp.CoeffNumber; i++)
            {
                if (i < p1.CoeffNumber)
                {
                    temp[i] += p1[i];
                }
                if (i < p2.CoeffNumber)
                {
                    temp[i] -= p2[i];
                }
            }

            return temp;
        }
        public static Polynomial operator *(Polynomial p, double multiplier)
        {
            Validate<Polynomial>.NotNull(p, nameof(p));

            var temp = new Polynomial(p.CoeffNumber);

            for (int i = 0; i < temp.CoeffNumber; i++)
            {
                temp[i] = p[i] * multiplier;
            }

            return temp;
        }
        public static Polynomial operator *(double multiplier, Polynomial p)
        {
            Validate<Polynomial>.NotNull(p, nameof(p));

            var temp = new Polynomial(p.CoeffNumber);

            for (int i = 0; i < temp.CoeffNumber; i++)
            {
                temp[i] = p[i] * multiplier;
            }

            return temp;
        }
        public static bool operator ==(Polynomial p1, Polynomial p2)
        {
            if (ReferenceEquals(p1, null))
            {
                if (ReferenceEquals(p2, null)) 
                    return true;

                return false;
            }

            return p1.Equals(p2);
        }
        public static bool operator !=(Polynomial p1, Polynomial p2) => !(p1 == p2);
        public bool Equals(Polynomial other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;

            if (CoeffNumber != other.CoeffNumber) return false;

            for (int i = 0; i < CoeffNumber; i++)
            {
                if (this[i] != other[i]) return false;
            }

            return true;
        }
        public override bool Equals(object obj)
        {
            return Equals((Polynomial)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                foreach (var item in Coeffs)
                {
                    hash = hash * 23 + item.GetHashCode();
                }

                return hash;
            }
        }

        public override string ToString()
        {
            if (CoeffNumber == 0)
            {
                return string.Empty;
            }
            if (CoeffNumber == 1)
            {
                return Coeffs[0].ToString();
            }
            if (Coeffs.All(x => x == 0)) 
            { 
                return "0"; 
            }

            // a1, a2, ...
            var sb = new StringBuilder();
            for (int i = CoeffNumber - 1; i >= 1; i--)
            {
                if (Coeffs[i] == 0) 
                { 
                    continue;
                }
                if (Coeffs[i] == 1 || Coeffs[i] == -1)
                {
                    sb.Append(Coeffs[i].ToString("+;-"));
                }
                else
                {
                    sb.Append(Coeffs[i].ToString("+#;-#"));
                }

                if (i > 1)
                {
                    sb.Append("x^");
                    sb.Append(i);
                }
                else
                {
                    sb.Append('x');
                }
            }

            // a0 = 0
            if (Coeffs[0] == 0) 
            {
                if (sb[0] == '+') { sb.Remove(0, 1); }
                return sb.ToString(); 
            }

            // a0 != 0
            sb.Append(Coeffs[0].ToString("+#;-#"));

            if (sb[0] == '+') { sb.Remove(0, 1); }
            return sb.ToString();
        }
    }
}
