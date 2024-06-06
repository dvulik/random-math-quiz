using System.Formats.Asn1;

Random rnd = new Random();

int points = 0;

for (int i = 0; i < 10; i++)
{
    int rnd1 = rnd.Next(1,10);
    int rnd2 = rnd.Next(1,10);
    
    Console.WriteLine("question " + (i+1));
    System.Console.WriteLine(rnd1 + "*" + rnd2);

    int answ = rnd1 * rnd2;
    int input = int.Parse(Console.ReadLine());

    if (answ == input) 
    {
        points++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("correct! you have " + points + " points");  
        Console.ForegroundColor = ConsoleColor.Gray;
        Thread.Sleep(1000);
        Console.Clear();
    } 
    
    else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("incorrect! the answer is "  + answ);
        Console.ForegroundColor = ConsoleColor.Gray;
        Thread.Sleep(1000);
        Console.Clear();
    }

}
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.WriteLine("you have " + points + "/10 points. gg" );
Console.ForegroundColor = ConsoleColor.Gray;






Console.ReadKey();

