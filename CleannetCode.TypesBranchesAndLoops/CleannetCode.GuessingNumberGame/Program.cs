// See https://aka.ms/new-console-template for more information

Console.Write("Привет! ");
Console.WriteLine("Поиграем? (да)");
var yesOption = new[] { "да", "lf" }; //lf - если пользователь не сменил раскладку разрешим просто продолжить
var isPlaying = yesOption.Contains(Console.ReadLine().ToString().ToLower()) ?  true :  false;
var attemptCounter = 0;
while (isPlaying){
    (int startNum, int endNum) range = (0, 999);
    Random r = new Random();
    int secretNum = r.Next(range.startNum, range.endNum);
    Console.Write($"Я загадал число от {range.startNum} до {range.endNum}. ");
    Console.WriteLine("Попробуй угадать");
    //Console.WriteLine($"{secretNum}");
    var isGuesed = false;
    while (!isGuesed)
    {
        attemptCounter++;
        int userNum=-1;
        
        var isIntNum = false;
        Console.WriteLine($"Введи число от {range.startNum} до {range.endNum}");

        while (!isIntNum & (userNum<range.startNum | userNum > range.endNum))
        { 
            string? userInput = Console.ReadLine();
            isIntNum = int.TryParse(userInput, out userNum);
            if (!isIntNum)
            { 
                Console.WriteLine($"Ты ввел {userInput}"); 
                Console.WriteLine($"Попробуй еще раз. Введи число от {range.startNum} до {range.endNum}. Твое число: ");
            }
        }
        if (userNum < secretNum)
        {
            Console.WriteLine($"Мое число больше твоего {userNum}. \\_(°.° )_/");
        }
        else if (userNum > secretNum)
        {
            Console.WriteLine($"Твое число {userNum} больше моего. W(°O°)W");
        }
        else
        {
            Console.WriteLine($"Супер! Ты угадал! Мое число {secretNum}. (*^-^*)<3");
            Console.WriteLine($"Попыток: {attemptCounter}.");
            
            isGuesed = true;
            attemptCounter = 0;
        }
    }
    Console.WriteLine("Еще разок? (да)");
    isPlaying = Console.ReadLine() == "да" ?  true :  false;
}
Console.Write("Пока! Мне понравилось! (^*^)");

