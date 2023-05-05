using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string ipv6 = @"(:{1,2}[0-9a-fA-F]{1,4}|[0-9a-fA-F]{1,4}:){1,7}[0-9a-fA-F]{0,4}";
        string ipv4 = @"\b((((25[0-5])|(2[0-4]\d))|((1\d{2})|(\d{1,2})))\.){3}(((25[0-5])|(2[0-4]\d))|((1\d{2})|(\d{1,2})))\b";


        while (true)
        {
            Console.WriteLine("Введите ip: ");
            string text = Console.ReadLine();

            if (Regex.IsMatch(text, ipv6)) Console.WriteLine("Это ipv6.");
            else if (Regex.IsMatch(text, ipv4))Console.WriteLine("Это ipv4.");
            else Console.WriteLine("Совпадений нет.");
        }
    }

}