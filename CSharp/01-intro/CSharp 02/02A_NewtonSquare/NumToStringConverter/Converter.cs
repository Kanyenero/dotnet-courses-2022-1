namespace NumToStringConverter
{
    public static partial class Converter
    {
        private static readonly string base32Alph = "0123456789ABCDEFGHJKMNPQRSTVWXYZ";
        private static readonly string base64Alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        public static string ToBin(int num)
        {
            return ToBase(num, BaseSystem.Bin);
        }

        public static string ToOct(int num)
        {
            return ToBase(num, BaseSystem.Oct);
        }

        public static string ToHex(int num)
        {
            return ToBase(num, BaseSystem.Hex);
        }

        public static string ToBase32(int num)
        {
            return ToBase(num, BaseSystem.Base32);
        }

        public static string ToBase64(int num)
        {
            return ToBase(num, BaseSystem.Base64);
        }

        public static string ToBase(int num, BaseSystem sys)
        {
            return ToBase(num, (int)sys);
        }

        private static string ToBase(int num, int sys)
        {
            string res = string.Empty;
            string currAlph;

            switch (sys)
            {
                case 2:
                case 8:
                case 16:
                case 32:
                    {
                        currAlph = base32Alph.Substring(0, sys);
                        break;
                    }
                case 64:
                    {
                        currAlph = base64Alph;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Incorrect base system");
                    };
            }

            while (num > 0)
            {
                int mod = num % sys;
                num /= sys;

                res += currAlph[mod];
            }

            return Reverse(res);
        }

        public static string ToBinStandard(int num)
        {
            return Convert.ToString(num, 2);
        }

        public static string ToOctStandard(int num)
        {
            return Convert.ToString(num, 8);
        }

        public static string ToHexStandard(int num)
        {
            return Convert.ToString(num, 16);
        }

        public static string ToBase64Standard(int num)
        {
            return Convert.ToBase64String(BitConverter.GetBytes(num));
        }

        public static string ToBaseStandard(int num, BaseSystem sys)
        {
            return ToBaseStandard(num, (int)sys);
        }

        private static string ToBaseStandard(int num, int sys)
        {
            switch (sys)
            {
                case 2:
                case 8:
                case 16:
                    {
                        return Convert.ToString(num, sys);
                    }
                case 64:
                    {
                        return Convert.ToBase64String(BitConverter.GetBytes(num));
                    }
                default:
                    {
                        throw new ArgumentException("Incorrect base system");
                    };
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}