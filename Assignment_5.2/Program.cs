namespace Assignment_5._2
{
    internal class Program
    {
        static int LastWord(ref string s)
        {
            string [] words = s.Split(' ');
            s = words[words.Length - 1];
            return words[words.Length - 1].Length;
        }

        static void PrintNatualNumbers(int n, int count = 1)
        {
            if (count == n + 1) return;
            Console.Write($"{(count)} " );
            PrintNatualNumbers(n, count = count + 1);
        }

        static void PrintNaturalNumbersReverse(int n)
        {
            if(n == 0) return;

            Console.Write($"{n} ");
            PrintNaturalNumbersReverse(n - 1);
        }

        static bool IsPalindrome(string s, int left = 0, int right = 0)
        {
            right = s.Length - 1 - left;
            if (left >= right) return true;

            if (s[left] != s[right]) return false;
            
            return true && IsPalindrome(s, left + 1, right);
        }

        static void Print()
        {
            Console.WriteLine("This shows information about the last letter in your sentence.");
            Console.Write("Enter a sentence: ");

            string answer1 = Console.ReadLine();
            int length = LastWord(ref answer1);

            Console.WriteLine($"The last word is \"{answer1}\" with length {length}.\n");

            int result; 

            Console.WriteLine("This prints that first natural numbers.");

            while (true)
            {
                Console.Write("How many numbers to print: ");
                bool isVal = int.TryParse(Console.ReadLine(), out result);

                if (isVal) break;
            }

            PrintNatualNumbers(result);


            Console.WriteLine("\n\nThis prints that first natural numbers in reverse.");

            while (true)
            {
                Console.Write("How many numbers to print: ");
                bool isVal2 = int.TryParse(Console.ReadLine(), out result);

                if (isVal2) break;
            }

            PrintNaturalNumbersReverse(result);

            Console.WriteLine("\n\nIs your word a Palindrome?");
            Console.Write("Enter your word: ");
            string word = Console.ReadLine();

            switch (IsPalindrome(word))
            {
                case true:
                    Console.WriteLine("The string is Palindrome.");
                    break;
                    
                case false:
                    Console.WriteLine("The string is not a Palindrome.");
                    break;
            }



        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
