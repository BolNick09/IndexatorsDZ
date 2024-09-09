using IndexatorsDZ.Task2;

namespace IndexatorsDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            Arr arr1 = new Arr (num);

            for (int i = 0; i < 10; i++)            
                Console.WriteLine(arr1.code);
            
            Console.WriteLine("Code = -7");
            arr1.code = -7;

            for (int i = 0; i < 10; i++)
                Console.WriteLine(arr1.code);

            Console.WriteLine("--------------------------------");

            IntegerDigits number = new IntegerDigits(12345);
            number.Value = 67890;
            number[0] = 1;
            number[2] = 5;
            Console.WriteLine(number.Value);

            Console.WriteLine("--------------------------------");

            TextArray textArray = new TextArray(new string[] { "Hello", "World", "!" });
            Console.WriteLine(textArray[0]); // Hello
            textArray[0] = "Hi";
            Console.WriteLine(textArray[0]); // Hi
            Console.WriteLine(textArray[1, 1]); // o
            textArray[1, 1] = 'a';
            Console.WriteLine(textArray[1, 1]); // a

        }
    }
}
