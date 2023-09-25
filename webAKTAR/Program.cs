using System;
using browserAKTAR;

public class Program
{
    public static void Main()
    {
        Browser operagx = new Browser("artursuskevits.wordpress.com");
        Console.WriteLine(operagx.Current());
        while (true)
        {

            Console.WriteLine("Choose your move\n1-Go to new page\n2-Go back\n3-Go forward\n4-Check browser history\n5-Update homepage\n6-Go to homepage\nElse-Stop working");
            string youser_answer = Console.ReadLine();
            if (youser_answer == "1")
            {
                Console.WriteLine("Write new link");
                string newlink = Console.ReadLine();
                operagx.GoTo(newlink);
                Console.WriteLine(operagx.Current());
            }
            if (youser_answer == "2")
            {
                operagx.Back();
                Console.WriteLine(operagx.Current());
            }
            if (youser_answer == "3")
            {
                operagx.Forward();
                Console.WriteLine(operagx.Current());
            }
            if (youser_answer == "4")
            {
                Console.WriteLine(string.Join(", ", operagx.History()));
            }
            if (youser_answer == "5")
            {
                Browser.Change_homepage(operagx);
            }
            if (youser_answer == "6")
            {
                Browser.go_to_honepage(operagx);
            }
        }
    }
}
