namespace Question3442
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxDifference("ililm"));
        }

        public static int MaxDifference(string s)
        {
            var letters = new int[26];

            foreach (var c in s)
            {
                letters[c - 'a']++;
            }

            var maxOdd = int.MinValue;
            var hasOdd = false;

            var minEven = int.MaxValue;
            var hasEven = false;

            foreach (var l in letters) 
            {
                if (l == 0) continue;
                else if (l % 2 == 0 && l < minEven)
                {
                    minEven = l;
                    hasEven = true;
                }
                else if(l % 2 != 0 && l > maxOdd)
                {
                    maxOdd = l;
                    hasOdd = true;
                }
            }

            return (hasEven && hasOdd) ? maxOdd - minEven : -1;
        }
    }
}
