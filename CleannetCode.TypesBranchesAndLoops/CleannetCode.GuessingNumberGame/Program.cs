// See https://aka.ms/new-console-template for more information

Console.Write("Привет!");
Console.WriteLine("Поиграем? (да)");
var isPlaying = Console.ReadLine() == "да" ?  true :  false;
//enum Res { Больше, Меньше, Угадал }

if (isPlaying)
{
    (int startNum, int endNum) range = (1, 10);
    Random r = new Random();
    int guesedNum = r.Next(range.startNum, 2);//range.endNum);
    Console.Write($"Я загадал число от {range.startNum} до {range.endNum}.");
    Console.Write("Попробуй угадать");
    Console.Write($"{guesedNum}");
    String answer = Console.ReadLine();
    

    switch (answer)
    {
        case "":
            Console.WriteLine("");
            break;
        
        default:
            Console.WriteLine("");
            break;
    }
       
    
    Console.ReadLine();
}
Console.Write("Пока!");
Console.ReadLine();