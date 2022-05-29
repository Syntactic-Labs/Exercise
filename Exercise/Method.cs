using System.Linq;

namespace Exercise
{
    internal class Method
    {

        public static int AsoluteDiffOrTrip(int n)
        {
            const int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }
            return x - n;
        }
        public static int EqTripleNotDouble(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
        public static bool IntCheck(int x, int y)
        {
            if (x == 30 || y == 30 || x + y == 30)
            {
                return true;
            }
            return false;
        }

        public static string IsThereAnIf(string ifCheck)
        {
            if (!ifCheck.StartsWith("if "))
            {
                const string? isIf = "if ";
                string newIf = isIf + ifCheck;
                return newIf;
            }
            return ifCheck;
        }

    }
}
