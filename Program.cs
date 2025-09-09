namespace Laba_6_Alecseev_ISP_232_ISRPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //while (true)
            //{
            //    Console.Write("Введите exit для выхода: ");
            //    string s = Console.ReadLine();
            //    if (s == "exit") { break; }
            //    try
            //    {
            //        double number1 = Convert.ToDouble(Console.ReadLine());
            //        double number2 = Convert.ToDouble(Console.ReadLine());
            //        string op = Console.ReadLine();
            //        double result = 0;
            //        switch (op)
            //        {
            //            case "+":
            //                result = sum(number1, number2);
            //                break;
            //            case "-":
            //                result = dif(number1, number2);
            //                break;
            //            case "*":
            //                result = mul(number1, number2);
            //                break;
            //            case "/":
            //                if (number2 == 0)
            //                {
            //                    throw new DivideByZeroException("Нельзя делить на ноль");
            //                }
            //                result = div(number1, number2);
            //                break;
            //            case "^":
            //                result = deg(number1, number2);
            //                break;
            //            default: Console.WriteLine("Не известная операция"); break;

            //        }
            //        Console.WriteLine($"{number1} {op} {number2} = {result}");
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("Введите коректные числа");
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("Ошибка:" + ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Неизветная ошибка" + ex.Message);
            //    }
            //    finally { Console.WriteLine("Работа завершина"); }
            //}
            //Задание 3
            //Console.Write("Делимое = ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //double number2 = 0;
            //Console.Write("Длитель = ");
            //while (number2 == 0)
            //{
            //    try
            //    {
            //        number2 = Convert.ToDouble(Console.ReadLine());

            //        if (number2 == 0)
            //        {
            //            throw new DivideByZeroException("На ноль делить нельзя. Повторите ввод делителя: ");
            //        }
            //        Console.WriteLine(number1 / number2);
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.Write("На ноль делить нельзя. Повторите ввод делителя: ");
            //    }
            //}
        }
        //Задание 1
        //static double sum(double x, double y) { return x + y; }
        //static double dif(double x, double y) { return x - y; }
        //static double mul(double x, double y) { return x * y; }
        //static double div(double x, double y) { return x / y; }
        //static double deg(double x, double y) { return Math.Pow(x, y); }
    }
}
