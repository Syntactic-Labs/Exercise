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

        public static string FirstAndLastSwap(string str)
        {
            return str.Length > 1 ? str[^1..] + str[1..^1] + str[..1] : str;
        }

        public static string FourTimesFirstTwo(string str)
        {
            return str.Length < 2 ? str : SubStringMultiFour(str);
        }
        public static string SubStringMultiFour(string strLoop)
        {
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                result += strLoop[..2];
            }
            return result;
        }
        public static bool ThreeOrSeven(int x)
        {
            return x % 3 == 0 || x % 7 == 0;
        }
        public static void ReverseInput()
        {
            var x = Console.ReadLine();
            var y = Console.ReadLine();
            var z = Console.ReadLine();
            Console.WriteLine(z + y + x);
        }
        public static void NumberPyramid()
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {

                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }
                Console.WriteLine("\n");
                width -= 1;

            }
        }

    }
}