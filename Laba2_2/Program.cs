using Laba2_2;
class Program
{
    public static void Main(string[]args)
    {
        Ryadky ryadok = new Ryadky();
        Console.Write("Введiть рядок: ");
        string inputRyadok = Console.ReadLine();
        ryadok.ryadok = inputRyadok;
        Console.WriteLine("_____________________________");
        Console.WriteLine("Введiть:");
        Console.WriteLine("length: довжина рядка");
        Console.WriteLine("delete: видалення символу");
        while(true)
        {
            string input0 = Console.ReadLine();
            if (input0 == "length")
            {
                Console.WriteLine("Довжина рядка: " + ryadok.length());
            }
            if (input0 == "delete")
            {
                Console.WriteLine("Введiть символ для видалення");
                string symbol = "";
                
                while (true)
                {
                    symbol = Console.ReadLine();
                    if (symbol.Length > 1)
                    {
                        Console.WriteLine("Ввести треба лише один символ");
                    }
                    else break;
                }
                ryadok.delete(symbol);
                Console.Write("Рядок пiсля видалення символу: "+ryadok.ryadok);
            }
            if (input0 == "stop")
            {
                break;
            }
        }
        Digits digits = new Digits(inputRyadok);
        string inputDigits;
        while (true)
        {
            Console.Write("Введiть значення(цифри):");
            inputDigits = Console.ReadLine();
            digits.ryadok = inputDigits;
            if (digits.check())
            {
                break;
            }
            else Console.WriteLine("Рядок повинен складатися з цифрових символiв");
        }
        Console.WriteLine("_____________________________");
        Console.WriteLine("Введiть:");
        Console.WriteLine("length: довжина рядка");
        Console.WriteLine("delete: видалення символу '5'");
        while (true)
        {
            string input1 = Console.ReadLine();
            if (input1 == "length")
            {
                Console.WriteLine("Довжина рядка: " + digits.length());
            }
            if (input1 == "delete")
            {
                digits.delete();
                Console.WriteLine("Рядок пiсля видалення символу '5' :" + digits.ryadok);
            }
            if (input1 == "stop")
            {
                break;
            }
        }
        Letters letters = new Letters("");
        string inputLetters = "";
        while (true)
        {
            Console.Write("Введiть значення(букви):");
            inputLetters = Console.ReadLine();
            letters.ryadok = inputLetters;
            if (letters.check())
            {
                break;
            }
            else Console.WriteLine("Рядок повинен складатися з лiтер");
        }
        Console.WriteLine("_____________________________");
        Console.WriteLine("Введiть:");
        Console.WriteLine("length: довжина рядка");
        Console.WriteLine("delete: видалення символу 'a'");
        while (true)
        {
            string input2 = Console.ReadLine();
            if (input2 == "length")
            {
                Console.WriteLine("Довжина рядка: " + letters.length());
            }
            if (input2 == "delete")
            {
                letters.delete();
                Console.WriteLine("Рядок пiсля видалення символу 'a' :" + letters.ryadok);
            }
            if (input2 == "stop")
            {
                break;
            }
        }
    }
}