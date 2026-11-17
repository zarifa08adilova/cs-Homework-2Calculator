class Program
{
    enum Operations
    {
        Sum = 1,
        Substract,
        Multiply,
        Divide,
        Percent,
    }

    static void Main(string[] args)
    {
        bool temp = true;

        while (temp)
        {
            Console.WriteLine("         Menu");
            Console.WriteLine("----------------------");
            Console.WriteLine(" 1. Sum");
            Console.WriteLine(" 2. Substract");
            Console.WriteLine(" 3. Multiply");
            Console.WriteLine(" 4. Divide");
            Console.WriteLine(" 5. Percent");
            Console.WriteLine("----------------------");


            Console.Write("Choose operation: ");
            Operations operation = (Operations)Convert.ToInt32(Console.ReadLine());

            Console.Write(" 1st number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write(" 2st number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            switch (operation)
            {
                case Operations.Sum:
                    float summ = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {summ}");
                    break;
                case Operations.Substract:
                    float subs = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {subs}");
                    break;
                case Operations.Multiply:
                    float mult = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {mult}");
                    break;
                case Operations.Divide:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Can't divide by 0.");
                    }
                    else if (num2 != 0)
                    {
                        float div = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {div}");
                    }
                    break;
                case Operations.Percent:
                    float per = (num1 * num2) / 100;
                    Console.WriteLine($"{num2}% of {num1} is {per}");
                    break;
                default:
                    Console.WriteLine("Wrong Choice.");
                    break;
            }
        }
    }
}